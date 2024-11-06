using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.Presentation.Filters
{
    public class TimeRestrictedAccessFilter : Attribute, IActionFilter
    {
        private readonly int _startHour;
        private readonly int _endHour;

        public TimeRestrictedAccessFilter(int startHour, int endHour)
        {
            _startHour = startHour;
            _endHour = endHour;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var currentHour = DateTime.Now.Hour;

            if (currentHour < _startHour || currentHour >= _endHour)
            {
                context.Result = new ContentResult
                {
                    StatusCode = 403, 
                    Content = $"Bu API'ye erişim yalnızca {_startHour}:00 - {_endHour}:00 saatleri arasında mümkündür."
                };
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }
    }
}
