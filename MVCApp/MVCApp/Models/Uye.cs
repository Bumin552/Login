using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;//Gereklilik ve zorunluluk konrolü için kullanılan class.
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Uye //Modellerin dogrulugunu kontrol etmek icin validation islemleri yapilir.
    {
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        [EmailAddress()]
        public string Email { get; set; }
        public string Telefon { get; set; }
        [Required, DisplayName("TC Kimlik Numarası")]//Ekranda Yazılacak şey.
        [MinLength(11, ErrorMessage = "TC minimum 11 Hane olmalı")]
        [MaxLength(11, ErrorMessage = "TC maksimum 11 Hane olmalı")]
        public string Tc { get; set; }
        public string KullaniciAdi { get; set; }
        [Required]
        [DisplayName("Sifre"), DataType(DataType.Password)]
        [StringLength(10 , MinimumLength =5)]
        public string Sifre { get; set; }
        public string SifreTekrar { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd.MM.yyyy}"), DisplayName("Doğum Tarihi") ,DataType(dataType:DataType.Date)]
        public DateTime DogumTarihi { get; set; }
    }
}