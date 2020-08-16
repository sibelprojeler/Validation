using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Validation.Models
{
    public class Class1
    {
        public class EtkinlikModel
        {
            [Required(ErrorMessage = "Lütfen bir ad giriniz")]
            public string Ad { get; set; }

            [DataType(DataType.Date)]
            public DateTime BaslangicTarih { get; set; }

            [DataType(DataType.Time)]
            public string BaslangicSaat { get; set; }

            [Required(ErrorMessage = "Lütfen bir kişi sayısı giriniz")]
            [Range(2, 6, ErrorMessage = "En az 2 en çok 6 karakter giriniz")]
            public int KatilacakKisi { get; set; }

            [Required(ErrorMessage = "Email boş bırakılamaz")]
            [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                                ErrorMessage = "Email adresi geçersiz")]
            public string Email { get; set; }
        }
    }
}