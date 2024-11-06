using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore;

namespace OnlineAlisverisPlatformu.Business.Services
{
    public class DataProtectionService
    {
        private readonly IDataProtector _protector;

        public DataProtectionService(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("UserPasswordProtector");
        }

        public string ProtectPassword(string password)
        {
            return _protector.Protect(password); 
        }

        public string UnprotectPassword(string protectedPassword)
        {
            return _protector.Unprotect(protectedPassword); 
        }
    }
}
