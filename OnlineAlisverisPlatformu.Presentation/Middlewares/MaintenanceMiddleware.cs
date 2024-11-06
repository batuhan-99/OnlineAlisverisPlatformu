using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlineAlisverisPlatformu.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.Presentation.Middlewares
{
    public class MaintenanceMiddleware
    {
        private readonly RequestDelegate _next;

        public MaintenanceMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ApplicationDbContext dbContext)
        {
            var maintenanceMode = await dbContext.MaintenanceModes.FirstOrDefaultAsync();

            if (maintenanceMode != null && maintenanceMode.IsMaintenanceEnabled)
            {
                context.Response.StatusCode = StatusCodes.Status503ServiceUnavailable;
                await context.Response.WriteAsync("Site şu anda bakım modunda. Lütfen daha sonra tekrar deneyin.");
                return;
            }

            await _next(context);
        }
    }
}
