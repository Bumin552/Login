using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class AnasayfaModel // Bir sayfada birden fazla model kullanmak için gereken yapı.
    {
        public Kullanici Kullanicinesnesi { get; set; }
        public Adres Adresnesnesi { get; set; }
    }
}