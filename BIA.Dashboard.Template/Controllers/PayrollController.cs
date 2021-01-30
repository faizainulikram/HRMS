﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BIA.Dashboard.Template.Data;
using BIA.Dashboard.Template.Models;
using BIA.Dashboard.Template.Models.Identity;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using FileUpload.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BIA.Dashboard.Template.Services;
using BIA.Dashboard.Template.Infrastructure;
using Microsoft.CodeAnalysis;

namespace BIA.Dashboard.Template.Controllers
{
    [Authorize(Policy = "Payroll")]
    public class PayrollController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IEmailSender _emailSender;

        public PayrollController(ApplicationDbContext context, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            _context = context;
            hostingEnvironment = environment;
            this.userManager = userManager;
            _emailSender = emailSender;
        }

        private void PopulateUserDropdownList(object selectedUser = null)
        {
            var personnelQuery = from s in _context.PersonnelInformation
                                 select new
                                 {
                                     Id = s.PersonnelId,
                                     NameIc = s.Name + " (" + s.IdentityCardNumber + ")"
                                 };
            ViewBag.PersonnelId = new SelectList(personnelQuery.AsNoTracking(), "Id", "NameIc", selectedUser);
        }

        private void PopulateLedgerDropdownList(object selectedLedger = null)
        {
            var ledgerQuery = from s in _context.PayrollLedger
                              select new
                              {
                                  Id = s.PayrollLedgerId,
                                  CodeName = s.LedgerCode + " (" + s.Name + ")"
                              };
            ViewBag.PayrollId = new SelectList(ledgerQuery.AsNoTracking(), "Id", "CodeName", selectedLedger);
        }

        [HttpGet]
        public async Task<JsonResult> GetIcNumber(int id)
        {
            var personnelInformation = await _context.PersonnelInformation.FirstOrDefaultAsync(x => x.PersonnelId == id);

            var icNumber = personnelInformation.IdentityCardNumber.Replace("-", "");

            return Json(icNumber);
        }

        // GET: PersonnelInformations
        public IActionResult Index()
        {
            return View();
        }

        // GET: EarningAdvice
        public async Task<IActionResult> EarningAdvice(string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var deductions = _context.EarningPayrollAdvices.Include(x => x.PersonnelInformation).AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                deductions = deductions.Where(s => (s.AdviceNumber.Contains(searchString)
                || s.ICNumber.Contains(searchString)
                || s.Remarks.Contains(searchString)
                || s.Ledger.Name.Contains(searchString)
                ));
            }

            int pageSize = 10;
            return View(await PaginatedList<EarningPayrollAdvice>.CreateAsync(deductions.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: DeductionAdvice
        public async Task<IActionResult> DeductionAdvice(string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var deductions = _context.DeductionPayrollAdvices.Include(x => x.PersonnelInformation).AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                deductions = deductions.Where(s => (s.AdviceNumber.Contains(searchString)
                || s.ICNumber.Contains(searchString)
                || s.Remarks.Contains(searchString)
                || s.Ledger.Name.Contains(searchString)
                ));
            }

            int pageSize = 10;
            return View(await PaginatedList<DeductionPayrollAdvice>.CreateAsync(deductions.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: BankAdvice
        public async Task<IActionResult> BankAccountAdvice(string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var bankaccounts = _context.BankAccountAdvices.Include(x => x.PersonnelInformation).AsQueryable();
            if (!String.IsNullOrEmpty(searchString))
            {
                bankaccounts = bankaccounts.Where(s => (s.AdviceNumber.Contains(searchString)
                || s.ICNumber.Contains(searchString)
                || s.Remarks.Contains(searchString)
                || s.BankCode.Contains(searchString)
                || s.BranchCode.Contains(searchString)
                || s.BankAccountType.Contains(searchString)
                || s.AccountNumber.Contains(searchString)
                || s.AccountName.Contains(searchString)
                ));
            }

            int pageSize = 10;
            return View(await PaginatedList<BankAccountPayrollAdvice>.CreateAsync(bankaccounts.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: AddPayrollAdvice
        public IActionResult AddBankAccountAdvice()
        {
            PopulateUserDropdownList();
            PopulateLedgerDropdownList();
            BankAndBankBranchDropdowns(string.Empty, string.Empty);
            return PartialView("_AddBankAccountAdvice");
        }
        private void BankAndBankBranchDropdowns(string bank,string branch)
        {
            var _data= _context.PayrollBankBranch.ToList();
            ViewBag.banks = new SelectList(_data, "Bank", "BankName",bank);
            ViewBag.branches = new SelectList(_data, "Branch", "BranchName", branch);


        }
        public IActionResult AddDeductionAdvice()
        {
            PopulateUserDropdownList();
            PopulateLedgerDropdownList();
            return PartialView("_AddDeductionAdvice");
        }
        public IActionResult AddEarningAdvice()
        {
            PopulateUserDropdownList();
            PopulateLedgerDropdownList();
            return PartialView("_AddEarningAdvice");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDeductionAdvice(DeductionPayrollAdvice payrollAdvice)
        {
            if (ModelState.IsValid)
            {
                _context.DeductionPayrollAdvices.Add(payrollAdvice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DeductionAdvice));
            }

            return PartialView("_AddDeductionAdvice", payrollAdvice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEarningAdvice(EarningPayrollAdvice payrollAdvice)
        {
            if (ModelState.IsValid)
            {
                _context.EarningPayrollAdvices.Add(payrollAdvice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(EarningAdvice));
            }

            return PartialView("_AddEarningAdvice", payrollAdvice);
        }
        [HttpPost]  
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBankAccountAdvice(BankAccountPayrollAdvice payrollAdvice)
        {
            if (ModelState.IsValid)
            {
                _context.BankAccountAdvices.Add(payrollAdvice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BankAccountAdvice));
            }

            return PartialView("_AddBankAccountAdvice", payrollAdvice);
        }

        // GET: AddPayrollAdvice
        public async Task<IActionResult> EditBankAccountAdvice(int id)
        {
            var payrollAdvice = await _context.BankAccountAdvices
                .FirstOrDefaultAsync(m => m.PayrollAdviceId == id);

            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.PersonnelId == payrollAdvice.PersonnelInformationId);

            var payrollLedger = await _context.PayrollLedger
                .FirstOrDefaultAsync(m => m.PayrollLedgerId == payrollAdvice.PayrollLedgerId);

            PopulateUserDropdownList(personnelInformation);
            PopulateLedgerDropdownList(payrollLedger);
            BankAndBankBranchDropdowns(payrollAdvice?.BankCode,payrollAdvice?.BranchCode);
            return PartialView("_EditBankAccountAdvice", payrollAdvice);
        }
        public async Task<IActionResult> EditDeductionAdvice(int id)
        {
            var payrollAdvice = await _context.DeductionPayrollAdvices
                .FirstOrDefaultAsync(m => m.PayrollAdviceId == id);

            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.PersonnelId == payrollAdvice.PersonnelInformationId);

            var payrollLedger = await _context.PayrollLedger
                .FirstOrDefaultAsync(m => m.PayrollLedgerId == payrollAdvice.PayrollLedgerId);

            PopulateUserDropdownList(personnelInformation);
            PopulateLedgerDropdownList(payrollLedger);
            return PartialView("_EditDeductionAdvice", payrollAdvice);
        }
        public async Task<IActionResult> EditEarningAdvice(int id)
        {
            var payrollAdvice = await _context.EarningPayrollAdvices
                .FirstOrDefaultAsync(m => m.PayrollAdviceId == id);

            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.PersonnelId == payrollAdvice.PersonnelInformationId);

            var payrollLedger = await _context.PayrollLedger
                .FirstOrDefaultAsync(m => m.PayrollLedgerId == payrollAdvice.PayrollLedgerId);

            PopulateUserDropdownList(personnelInformation);
            PopulateLedgerDropdownList(payrollLedger);
            return PartialView("_EditEarningAdvice", payrollAdvice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBankAccountAdvice(BankAccountPayrollAdvice payrollAdvice)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(payrollAdvice).State=EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BankAccountAdvice));
            }

            return PartialView("_AddBankAccountAdvice", payrollAdvice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditDeductionAdvice(DeductionPayrollAdvice payrollAdvice)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(payrollAdvice).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DeductionAdvice));
            }

            return PartialView("_EditDeductionAdvice", payrollAdvice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEarningAdvice(EarningPayrollAdvice payrollAdvice)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(payrollAdvice).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(EarningAdvice));
            }

            return PartialView("_EditEarningAdvice", payrollAdvice);
        }
        public async Task<IActionResult> CancelAdviceReplacement(int id)
        {
            var payrollAdvice = await _context.BankAccountAdvices
                .FirstOrDefaultAsync(m => m.PayrollAdviceId == id);

            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.PersonnelId == payrollAdvice.PersonnelInformationId);

            var payrollLedger = await _context.PayrollLedger
                .FirstOrDefaultAsync(m => m.PayrollLedgerId == payrollAdvice.PayrollLedgerId);

            if (payrollAdvice == null)
            {
                return NotFound();
            }

            payrollAdvice.Status = "C";
            payrollAdvice.StatusDate = DateTime.Now;

            await _context.SaveChangesAsync();

            PopulateUserDropdownList(personnelInformation);
            PopulateLedgerDropdownList(payrollLedger);

            var newPayrollAdvice = new BankAccountPayrollAdvice();

            newPayrollAdvice.PersonnelInformation = payrollAdvice.PersonnelInformation;
            newPayrollAdvice.PersonnelInformationId = payrollAdvice.PersonnelInformationId;
            newPayrollAdvice.AdviceNumber = payrollAdvice.AdviceNumber;
            newPayrollAdvice.ICNumber = payrollAdvice.ICNumber;
            newPayrollAdvice.Remarks = payrollAdvice.Remarks;
            newPayrollAdvice.PayrollLedgerId = payrollAdvice.PayrollLedgerId;
            newPayrollAdvice.Ledger = payrollAdvice.Ledger;
            return PartialView("_AddBankAccountAdvice", newPayrollAdvice);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelAdviceNoReplacement(int id)
        {
            var payrollAdvice = await _context.BankAccountAdvices
                .FirstOrDefaultAsync(m => m.PayrollAdviceId == id);


            if (payrollAdvice == null)
            {
                return NotFound();
            }

            payrollAdvice.Status = "C";
            payrollAdvice.StatusDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BankAccountAdvice));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelDeductionAdviceNoReplacement(int id)
        {
            var payrollAdvice = await _context.DeductionPayrollAdvices
                .FirstOrDefaultAsync(m => m.PayrollAdviceId == id);


            if (payrollAdvice == null)
            {
                return NotFound();
            }

            payrollAdvice.Status = "C";
            payrollAdvice.StatusDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DeductionAdvice));
        }

        public async Task<IActionResult> CancelDeductionAdviceReplacement(int id)
        {
            var payrollAdvice = await _context.DeductionPayrollAdvices
                .FirstOrDefaultAsync(m => m.PayrollAdviceId == id);

            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.PersonnelId == payrollAdvice.PersonnelInformationId);

            var payrollLedger = await _context.PayrollLedger
                .FirstOrDefaultAsync(m => m.PayrollLedgerId == payrollAdvice.PayrollLedgerId);

            if (payrollAdvice == null)
            {
                return NotFound();
            }

            payrollAdvice.Status = "C";
            payrollAdvice.StatusDate = DateTime.Now;

            await _context.SaveChangesAsync();

            PopulateUserDropdownList(personnelInformation);
            PopulateLedgerDropdownList(payrollLedger);

            var newPayrollAdvice = new DeductionPayrollAdvice();

            newPayrollAdvice.PersonnelInformation = payrollAdvice.PersonnelInformation;
            newPayrollAdvice.PersonnelInformationId = payrollAdvice.PersonnelInformationId;
            newPayrollAdvice.AdviceNumber = payrollAdvice.AdviceNumber;
            newPayrollAdvice.ICNumber = payrollAdvice.ICNumber;
            newPayrollAdvice.Remarks = payrollAdvice.Remarks;
            newPayrollAdvice.PayrollLedgerId = payrollAdvice.PayrollLedgerId;
            newPayrollAdvice.Ledger = payrollAdvice.Ledger;
            newPayrollAdvice.Deduction = payrollAdvice.Deduction;
            return PartialView("_AddDeductionAdvice", newPayrollAdvice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelEarningAdviceNoReplacement(int id)
        {
            var payrollAdvice = await _context.EarningPayrollAdvices
                .FirstOrDefaultAsync(m => m.PayrollAdviceId == id);


            if (payrollAdvice == null)
            {
                return NotFound();
            }

            payrollAdvice.Status = "C";
            payrollAdvice.StatusDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(EarningAdvice));
        }

        public async Task<IActionResult> CancelEarningAdviceReplacement(int id)
        {
            var payrollAdvice = await _context.EarningPayrollAdvices
                .FirstOrDefaultAsync(m => m.PayrollAdviceId == id);

            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.PersonnelId == payrollAdvice.PersonnelInformationId);

            var payrollLedger = await _context.PayrollLedger
                .FirstOrDefaultAsync(m => m.PayrollLedgerId == payrollAdvice.PayrollLedgerId);

            if (payrollAdvice == null)
            {
                return NotFound();
            }

            payrollAdvice.Status = "C";
            payrollAdvice.StatusDate = DateTime.Now;

            await _context.SaveChangesAsync();

            PopulateUserDropdownList(personnelInformation);
            PopulateLedgerDropdownList(payrollLedger);

            var newPayrollAdvice = new EarningPayrollAdvice();

            newPayrollAdvice.PersonnelInformation = payrollAdvice.PersonnelInformation;
            newPayrollAdvice.PersonnelInformationId = payrollAdvice.PersonnelInformationId;
            newPayrollAdvice.AdviceNumber = payrollAdvice.AdviceNumber;
            newPayrollAdvice.ICNumber = payrollAdvice.ICNumber;
            newPayrollAdvice.Remarks = payrollAdvice.Remarks;
            newPayrollAdvice.PayrollLedgerId = payrollAdvice.PayrollLedgerId;
            newPayrollAdvice.Ledger = payrollAdvice.Ledger;
            newPayrollAdvice.Earning = payrollAdvice.Earning;
            return PartialView("_AddEarningAdvice", newPayrollAdvice);
        }


        [HttpGet]
        public async Task<JsonResult> GetPayrollAdvice(int id)
        {
            var payrollAdvice = await _context.BankAccountAdvices
                .FirstOrDefaultAsync(m => m.PayrollAdviceId == id);

            return Json(payrollAdvice);
        }

        private bool PayrollAdviceExists(int id)
        {
            return _context.BankAccountAdvices.Any(e => e.PayrollAdviceId == id);
        }

        // GET: PayrollLedger
        public async Task<IActionResult> PayrollLedger(string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var ledgers = from s in _context.PayrollLedger
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                ledgers = ledgers.Where(s => (s.LedgerCode.Contains(searchString)
                || s.Name.Contains(searchString)
                || s.Description.Contains(searchString)
                ));
            }

            int pageSize = 10;
            return View(await PaginatedList<PayrollLedger>.CreateAsync(ledgers.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPayrollLedger([FromForm] PayrollLedger payrollLedger)
        {
            if (ModelState.IsValid)
            {
                _context.PayrollLedger.Add(payrollLedger);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PayrollLedger));
            }

            return RedirectToAction(nameof(PayrollLedger));
        }

        [HttpGet]
        public async Task<JsonResult> GetPayrollLedger(int id)
        {
            var payrollLedger = await _context.PayrollLedger
                .FirstOrDefaultAsync(m => m.PayrollLedgerId == id);

            return Json(payrollLedger);
        }

        private bool PayrollLedgerExists(int id)
        {
            return _context.PayrollLedger.Any(e => e.PayrollLedgerId == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPayrollLedger([FromForm] PayrollLedger payrollLedger)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(payrollLedger);
                    await _context.SaveChangesAsync();
                }

                catch (DbUpdateConcurrencyException)
                {
                    if (!PayrollLedgerExists(payrollLedger.PayrollLedgerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(PayrollLedger));
            }
            return RedirectToAction(nameof(PayrollLedger));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePayrollLedger(int id)
        {
            var payrollLedger = await _context.PayrollLedger.FindAsync(id);
            _context.PayrollLedger.Remove(payrollLedger);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(PayrollLedger));
        }

        // GET: PayrollBankBranch
        public async Task<IActionResult> PayrollBankBranch(string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var bankbranches = from s in _context.PayrollBankBranch
                          select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                bankbranches = bankbranches.Where(s => (s.Bank.Contains(searchString)
                || s.BankName.Contains(searchString)
                || s.Branch.Contains(searchString)
                || s.BranchName.Contains(searchString)
                ));
            }

            int pageSize = 10;
            return View(await PaginatedList<PayrollBankBranch>.CreateAsync(bankbranches.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPayrollBankBranch([FromForm] PayrollBankBranch payrollBankBranch)
        {
            if (ModelState.IsValid)
            {
                _context.PayrollBankBranch.Add(payrollBankBranch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PayrollBankBranch));
            }

            return RedirectToAction(nameof(PayrollBankBranch));
        }

        [HttpGet]
        public async Task<JsonResult> GetPayrollBankBranch(int id)
        {
            var payrollBankBranch = await _context.PayrollBankBranch
                .FirstOrDefaultAsync(m => m.PayrollBankBranchId == id);

            return Json(payrollBankBranch);
        }

        private bool PayrollBankBranchExists(int id)
        {
            return _context.PayrollBankBranch.Any(e => e.PayrollBankBranchId == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPayrollBankBranch([FromForm] PayrollBankBranch payrollBankBranch)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(payrollBankBranch);
                    await _context.SaveChangesAsync();
                }

                catch (DbUpdateConcurrencyException)
                {
                    if (!PayrollBankBranchExists(payrollBankBranch.PayrollBankBranchId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(PayrollBankBranch));
            }
            return RedirectToAction(nameof(PayrollBankBranch));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePayrollBankBranch(int id)
        {
            var payrollBankBranch = await _context.PayrollBankBranch.FindAsync(id);
            _context.PayrollBankBranch.Remove(payrollBankBranch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(PayrollBankBranch));
        }

        public ActionResult SearchPersonnelInformation(string term)
        {
            var results = _context.PersonnelInformation.Where(s => s.Name.StartsWith(term))
                                                       .Where(s => s.IdentityCardNumber.StartsWith(term))
                                                       .Select(x => new {
                                                           id = x.PersonnelId,
                                                           name = x.Name,
                                                           ic = x.IdentityCardNumber,
                                                       }).ToList();
            return Json(results);
        }
    }
}
