using Microsoft.AspNetCore.Mvc;

namespace BIA.Dashboard.Template.Infrastructure
{
    [Route("[controller]/[action]", Name = "[controller]_[action]")]
    public abstract class BaseController : Controller
    {
    }
}
