using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proje1.Core
{
    public class MembershipPackage
    {
        // Örnek: "Gold Yıllık"
        public string Ad { get; set; }

        // Örnek: "Tüm derslere sınırsız giriş, sauna, havuz"
        public string Aciklama { get; set; }

        // İstersen fiyat da tutabiliriz
        public decimal? Fiyat { get; set; }

        public MembershipPackage(string ad, string aciklama, decimal? fiyat = null)
        {
            Ad = ad;
            Aciklama = aciklama;
            Fiyat = fiyat;
        }

        public override string ToString()
        {
            return Fiyat.HasValue
                ? $"{Ad} ({Fiyat.Value} TL)"
                : Ad;
        }
    }
}
