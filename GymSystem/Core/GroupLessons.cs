using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proje1.Core
{
    public class GroupLesson
    {
        public int Id { get; set; }

        // Ders adı (Yoga, Pilates, Zumba...)
        public string Ad { get; set; }

        // Kategori (Kardiyo, Güç & Kondisyon, Esneklik & Zihin)
        public LessonCategory Kategori { get; set; }

        // Eğitmen adı
        public string Egitmen { get; set; }

        // Salon (Stüdyo A gibi)
        public string Salon { get; set; }

        // Haftanın günü
        public DayOfWeek Gun { get; set; }

        // Saat (sadece saat/dakika)
        public TimeSpan Saat { get; set; }

        // Kontenjan bilgisi
        public int KontenjanToplam { get; set; }

        // Şu an kayıtlı kişi sayısı
        public int KontenjanDolu => KayitliUyeler.Count;

        // Bu derse kayıtlı üyeler
        public List<Member> KayitliUyeler { get; private set; } = new List<Member>();

        // Boş yer var mı?
        public bool BosYerVar => KontenjanDolu < KontenjanToplam;

        public GroupLesson(int id, string ad, LessonCategory kategori)
        {
            Id = id;
            Ad = ad;
            Kategori = kategori;
        }

        // Üyeyi derse kaydetmeye çalışır
        public bool UyeKaydet(Member uye)
        {
            // Kontenjan doluysa
            if (!BosYerVar)
                return false;

            // Zaten kayıtlıysa
            if (KayitliUyeler.Contains(uye))
                return false;

            // Derse ekle
            KayitliUyeler.Add(uye);

            // Üyenin listesine de bu dersi ekle
            if (!uye.KayitliDersler.Contains(this))
            {
                uye.KayitliDersler.Add(this);
            }

            return true;
        }
    }
}
