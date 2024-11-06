using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineAlisverisPlatformu.DataAccess.Contexts;
using OnlineAlisverisPlatformu.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MaintenanceController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("enable")]
        public async Task<IActionResult> EnableMaintenance()
        {
            var maintenanceMode = await _context.MaintenanceModes.FirstOrDefaultAsync();
            if (maintenanceMode == null)
            {
                maintenanceMode = new MaintenanceMode { IsMaintenanceEnabled = true };
                await _context.MaintenanceModes.AddAsync(maintenanceMode);
            }
            else
            {
                maintenanceMode.IsMaintenanceEnabled = true;
            }

            await _context.SaveChangesAsync();
            return Ok("Bakım modu etkinleştirildi.");
        }

        [HttpPost("disable")]
        public async Task<IActionResult> DisableMaintenance()
        {
            var maintenanceMode = await _context.MaintenanceModes.FirstOrDefaultAsync();
            if (maintenanceMode != null)
            {
                maintenanceMode.IsMaintenanceEnabled = false;
                await _context.SaveChangesAsync();
            }

            return Ok("Bakım modu devre dışı bırakıldı.");
        }
    }
}
