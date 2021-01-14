using Microsoft.AspNetCore.Mvc.Filters;

namespace BIA.Dashboard.Template.Infrastructure.ErrorHandling
{
    public abstract class ModelStateTransfer : ActionFilterAttribute
    {
        protected const string Key = nameof(ModelStateTransfer);
    }
}