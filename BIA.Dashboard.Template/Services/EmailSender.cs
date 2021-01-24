using BIA.Dashboard.Template.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIA.Dashboard.Template.Services
{
    public class EmailSender : IEmailSender
    {
        private string FromEmail;
        private string API_KEY;
        public EmailSender(IConfiguration configuration)
        {
            this.FromEmail = configuration.GetValue<string>("EmailSender:FromEmail");
            this.API_KEY = configuration.GetValue<string>("EmailSender:ApiKey");
        }

        public async Task SendEmailAsync(string toEmail, string subject, string htmlMessage)
        {

            var client = new SendGridClient(API_KEY);
            List<EmailAddress> ToEmailAddresses = new List<EmailAddress>();
            EmailAddress FromEmailAddress = new EmailAddress(FromEmail, FromEmail);
            List<string> ToEmails = string.IsNullOrEmpty(toEmail) ? new List<string>() : toEmail.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var ToEmail in ToEmails)
            {
                ToEmailAddresses.Add(new EmailAddress(ToEmail, ToEmail));
            }
            SendGridMessage msg = MailHelper.CreateSingleEmailToMultipleRecipients(FromEmailAddress, ToEmailAddresses, subject, "", htmlMessage);
            await client.SendEmailAsync(msg);

        }
    }
}