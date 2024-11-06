using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.Business.Services
{
    public class AccountService
    {
        private readonly DataProtectionService _dataProtectionService;

        public AccountService(DataProtectionService dataProtectionService)
        {
            _dataProtectionService = dataProtectionService;
        }

        public void RegisterUser(string username, string password)
        {
            var protectedPassword = _dataProtectionService.ProtectPassword(password);
           
        }

        public bool ValidatePassword(string protectedPassword, string password)
        {
            var unprotectedPassword = _dataProtectionService.UnprotectPassword(protectedPassword);
            return unprotectedPassword == password;
        }
    }
}
