using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proje1.Core
{
    // Spor salonu üyesi
    public class Member
    {
        // Login için T.C. kimlik numarası
        public string TcKimlikNo { get; set; }

        // Şifre (bu projede basit string olarak tutacağız)
        public string Sifre { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Üyenin paket bilgisi
        public MembershipPackage UyelikPaketi { get; set; }

        // Üyeliğin bittiği tarih
        public DateTime UyelikBitisTarihi { get; set; }

        // Üyenin kayıt olduğu dersler (GroupLesson'i birazdan ekleyeceğiz)
        public List<GroupLesson> KayitliDersler { get; private set; } = new List<GroupLesson>();

        // Kolaylık için
        public string AdSoyad => $"{Ad} {Soyad}";

        public Member(string tcKimlikNo, string sifre, string ad, string soyad)
        {
            TcKimlikNo = tcKimlikNo;
            Sifre = sifre;
            Ad = ad;
            Soyad = soyad;
        }

        // Üyelik aktif mi?
        public bool UyelikAktifMi()
        {
            return DateTime.Now <= UyelikBitisTarihi;
        }

        // Üyenin belirli bir derse kayıtlı olup olmadığını kontrol
        public bool DerseKayitliMi(GroupLesson ders)
        {
            return KayitliDersler.Contains(ders);
        }
    }
}
