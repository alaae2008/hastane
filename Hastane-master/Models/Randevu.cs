using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Randevu
    {      
        [Key]
        [Display(Name = "kimlik numarınız")]
        [Range(10000000000, 999999999999, ErrorMessage = "Kimlik numarınızı doğru bir şekide girdirmelisiniz.")]
        public int CustomerID { get; set; }


        [Display(Name = "AD")]
        [Required(ErrorMessage = "Adınızı girdirmelisiniz .")]
        public string FirstName { get; set; }

        [Display(Name = "Soyadınız")]
        [Required(ErrorMessage = "Soyadınızı girdirmelisiniz .")]
        public string LastName { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Mail Adresinizi girdirmelisiniz .")]
        public string Mail { get; set; }

  
        public System.DateTime Date { get; set; }

        [Display(Name = "telefon")]
        [Required(ErrorMessage = "Telefon numaranızı girdirmelisiniz.")]
        public string Telefon { get; set; }

        public string Text { get; set; }
    }
}