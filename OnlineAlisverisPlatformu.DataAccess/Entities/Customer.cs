using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineAlisverisPlatformu.DataAccess.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim alanı zorunludur.")]
        [StringLength(50, ErrorMessage = "İsim en fazla 50 karakter olabilir.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyisim alanı zorunludur.")]
        [StringLength(50, ErrorMessage = "Soyisim en fazla 50 karakter olabilir.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; }
    }
}
