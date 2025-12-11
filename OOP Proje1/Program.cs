using GymSystem.Core;
using OOP_Proje1.Core;
using System;
using System.Linq;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Backend sistemi oluştur (TXT dosyalarını okur)
var system = new GymSystem.Core.GymSystem();

// ******** ANA MENÜ DÖNGÜSÜ ********
while (true)
{
    Console.WriteLine("\n=== Spor Salonu Sistemi ===");
    Console.WriteLine("1 - Üye girişi");
    Console.WriteLine("2 - Yönetici girişi");
    Console.WriteLine("0 - Programı kapat");
    Console.Write("Seçimin: ");

    string? secim = Console.ReadLine();

    if (secim == "0")
    {
        Console.WriteLine("Program kapatılıyor...");
        break;
    }
    else if (secim == "1")
    {
        MemberFlow(system);      // Üye menüsüne gir
    }
    else if (secim == "2")
    {
        AdminFlow(system);       // Yönetici menüsüne gir
    }
    else
    {
        Console.WriteLine("Geçersiz seçim! Tekrar dene.\n");
    }

    Console.WriteLine("\nAna menüye dönülüyor...\n");
}

// ========= ÜYE TARAFI =========

static void MemberFlow(GymSystem.Core.GymSystem system)
{
    Member? currentMember = null;

    // Giriş ekranı
    while (currentMember == null)
    {
        Console.Write("\nT.C. Kimlik No: ");
        string? tc = Console.ReadLine();

        Console.Write("Şifre: ");
        string? sifre = Console.ReadLine();

        currentMember = system.Login(tc ?? "", sifre ?? "");

        if (currentMember == null)
        {
            Console.WriteLine("\nHatalı T.C. veya şifre. Tekrar deneyin.\n");
        }
    }

    Console.WriteLine($"\nHoş geldin {currentMember.AdSoyad}");
    Console.WriteLine($"Paketin: {currentMember.UyelikPaketi?.Ad}");
    Console.WriteLine($"Üyelik bitiş tarihi: {currentMember.UyelikBitisTarihi:d}");

    // Üye menüsü
    while (true)
    {
        Console.WriteLine("\n--- Üye Menüsü ---");
        Console.WriteLine("1 - Kayıtlı grup derslerimi göster");
        Console.WriteLine("2 - Ders kataloğundan derse kaydol");
        Console.WriteLine("3 - Bir dersten kaydımı sil");
        Console.WriteLine("0 - Üye menüsünden çık");
        Console.Write("Seçimin: ");

        string? secim = Console.ReadLine();
        Console.WriteLine();

        if (secim == "0")
            break;

        switch (secim)
        {
            case "1":
                GosterKayitliDersler(currentMember);
                break;

            case "2":
                DerseKaydol(system, currentMember);
                break;

            case "3":
                DerstenCik(system, currentMember);
                break;

            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }
    }
}

static void GosterKayitliDersler(Member member)
{
    if (member.KayitliDersler.Count == 0)
    {
        Console.WriteLine("Henüz kayıtlı olduğun grup dersi yok.");
        return;
    }

    Console.WriteLine("Kayıtlı olduğun grup dersleri:");
    foreach (var ders in member.KayitliDersler)
    {
        Console.WriteLine($"- {ders.Id}: {ders.Ad} ({ders.Gun} {ders.Saat}) - Salon: {ders.Salon}");
    }
}

static void DerseKaydol(GymSystem.Core.GymSystem system, Member member)
{
    Console.WriteLine("Ders kategorisini seç:");
    Console.WriteLine("1 - Kardiyo");
    Console.WriteLine("2 - Güç & Kondisyon");
    Console.WriteLine("3 - Esneklik & Zihin");
    Console.Write("Seçim: ");

    string? katSecim = Console.ReadLine();
    LessonCategory kategori;

    switch (katSecim)
    {
        case "1":
            kategori = LessonCategory.Kardiyo;
            break;
        case "2":
            kategori = LessonCategory.GucKondisyon;
            break;
        case "3":
            kategori = LessonCategory.EsneklikZihin;
            break;
        default:
            Console.WriteLine("Geçersiz kategori seçimi.");
            return;
    }

    var dersler = system.GetLessonsByCategory(kategori).ToList();

    if (dersler.Count == 0)
    {
        Console.WriteLine("Bu kategoride tanımlı ders yok.");
        return;
    }

    Console.WriteLine("\nBu kategorideki dersler:");
    foreach (var d in dersler)
    {
        Console.WriteLine($"{d.Id} - {d.Ad} ({d.Gun} {d.Saat}) " +
                          $"- Salon: {d.Salon} (Kontenjan: {d.KontenjanDolu}/{d.KontenjanToplam})");
    }

    Console.Write("\nKaydolmak istediğin dersin Id değerini gir: ");
    string? idStr = Console.ReadLine();

    if (!int.TryParse(idStr, out int dersId))
    {
        Console.WriteLine("Geçersiz Id.");
        return;
    }

    bool sonuc = system.RegisterMemberToLesson(member.TcKimlikNo, dersId);

    if (!sonuc)
    {
        Console.WriteLine("Kayıt yapılamadı. (Ders dolu olabilir veya zaten kayıtlısın.)");
    }
    else
    {
        Console.WriteLine("Derse kaydın başarıyla yapıldı!");
        Console.WriteLine("\nGüncel kayıtlı derslerin:");
        GosterKayitliDersler(member);
    }
}

static void DerstenCik(GymSystem.Core.GymSystem system, Member member)
{
    if (member.KayitliDersler.Count == 0)
    {
        Console.WriteLine("Hiçbir derse kayıtlı değilsin.");
        return;
    }

    Console.WriteLine("Kayıtlı olduğun dersler:");
    foreach (var ders in member.KayitliDersler)
    {
        Console.WriteLine($"{ders.Id} - {ders.Ad} ({ders.Gun} {ders.Saat})");
    }

    Console.Write("\nKayıt silmek istediğin dersin Id'sini gir: ");
    string? idStr = Console.ReadLine();

    if (!int.TryParse(idStr, out int dersId))
    {
        Console.WriteLine("Geçersiz Id.");
        return;
    }

    bool sonuc = system.CancelMemberFromLesson(member.TcKimlikNo, dersId);

    if (!sonuc)
    {
        Console.WriteLine("Kayıt silinemedi. (Derse kayıtlı olmayabilirsin.)");
    }
    else
    {
        Console.WriteLine("Ders kaydın silindi.");
        Console.WriteLine("\nGüncel kayıtlı derslerin:");
        GosterKayitliDersler(member);
    }
}


// ========= YÖNETİCİ TARAFI =========

static void AdminFlow(GymSystem.Core.GymSystem system)
{
    Console.Write("\nYönetici şifresi: ");
    string? sifre = Console.ReadLine();

    // Basit sabit admin şifresi
    if (sifre != "admin123")
    {
        Console.WriteLine("Yanlış şifre. Yönetici girişi reddedildi.");
        return;
    }

    Console.WriteLine("\nHoş geldiniz, yönetici.");

    while (true)
    {
        Console.WriteLine("\n--- Yönetici Menüsü ---");
        Console.WriteLine("1 - Tüm üyeleri listele");
        Console.WriteLine("2 - Yeni üye ekle");
        Console.WriteLine("3 - Üye sil");
        Console.WriteLine("4 - Tüm dersleri listele");
        Console.WriteLine("5 - Yeni ders ekle");
        Console.WriteLine("6 - Ders sil");
        Console.WriteLine("0 - Yönetici menüsünden çık");
        Console.Write("Seçimin: ");

        string? secim = Console.ReadLine();
        Console.WriteLine();

        if (secim == "0")
            break;

        switch (secim)
        {
            case "1":
                AdminListMembers(system);
                break;
            case "2":
                AdminAddMember(system);
                break;
            case "3":
                AdminRemoveMember(system);
                break;
            case "4":
                AdminListLessons(system);
                break;
            case "5":
                AdminAddLesson(system);
                break;
            case "6":
                AdminRemoveLesson(system);
                break;
            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }
    }
}

static void AdminListMembers(GymSystem.Core.GymSystem system)
{
    if (system.Members.Count == 0)
    {
        Console.WriteLine("Sistemde hiç üye yok.");
        return;
    }

    Console.WriteLine("Üyeler:");
    foreach (var m in system.Members)
    {
        Console.WriteLine($"- {m.TcKimlikNo} : {m.AdSoyad} (Paket: {m.UyelikPaketi?.Ad})");
    }
}

static void AdminAddMember(GymSystem.Core.GymSystem system)
{
    Console.WriteLine("=== Yeni Üye Ekle ===");

    Console.Write("T.C. Kimlik No: ");
    string tc = Console.ReadLine() ?? "";

    Console.Write("Şifre: ");
    string sifre = Console.ReadLine() ?? "";

    Console.Write("Ad: ");
    string ad = Console.ReadLine() ?? "";

    Console.Write("Soyad: ");
    string soyad = Console.ReadLine() ?? "";

    Console.Write("Üyelik paketi adı (ör: Gold Yıllık): ");
    string paketAdi = Console.ReadLine() ?? "";

    Console.Write("Üyelik bitiş tarihi (YYYY-AA-GG): ");
    string bitisStr = Console.ReadLine() ?? "";

    if (!DateTime.TryParse(bitisStr, out DateTime bitisTarihi))
    {
        bitisTarihi = DateTime.Now.AddYears(1);
    }

    bool sonuc = system.RegisterNewMember(tc, sifre, ad, soyad, paketAdi, bitisTarihi);

    Console.WriteLine(sonuc
        ? "Yeni üye başarıyla eklendi."
        : "Bu T.C. ile zaten bir üye var. Kayıt yapılmadı.");
}

static void AdminRemoveMember(GymSystem.Core.GymSystem system)
{
    Console.Write("Silmek istediğiniz üyenin T.C. Kimlik No'su: ");
    string tc = Console.ReadLine() ?? "";

    bool sonuc = system.RemoveMember(tc);

    Console.WriteLine(sonuc
        ? "Üye ve ders kayıtları sistemden silindi."
        : "Bu T.C. ile kayıtlı üye bulunamadı.");
}

static void AdminListLessons(GymSystem.Core.GymSystem system)
{
    if (system.Lessons.Count == 0)
    {
        Console.WriteLine("Sistemde hiç ders yok.");
        return;
    }

    Console.WriteLine("Dersler:");
    foreach (var d in system.Lessons)
    {
        Console.WriteLine($"- {d.Id}: {d.Ad} [{d.Kategori}] - {d.Gun} {d.Saat} " +
                          $"- Salon: {d.Salon} (Kontenjan: {d.KontenjanDolu}/{d.KontenjanToplam})");
    }
}

static void AdminAddLesson(GymSystem.Core.GymSystem system)
{
    Console.WriteLine("=== Yeni Ders Ekle ===");

    Console.Write("Ders Id: ");
    string? idStr = Console.ReadLine();
    if (!int.TryParse(idStr, out int id))
    {
        Console.WriteLine("Geçersiz Id.");
        return;
    }

    Console.Write("Ders adı: ");
    string ad = Console.ReadLine() ?? "";

    Console.WriteLine("Kategori seç:");
    Console.WriteLine("1 - Kardiyo");
    Console.WriteLine("2 - Güç & Kondisyon");
    Console.WriteLine("3 - Esneklik & Zihin");
    Console.Write("Seçim: ");
    string? katStr = Console.ReadLine();

    LessonCategory kategori;
    switch (katStr)
    {
        case "1":
            kategori = LessonCategory.Kardiyo;
            break;
        case "2":
            kategori = LessonCategory.GucKondisyon;
            break;
        case "3":
            kategori = LessonCategory.EsneklikZihin;
            break;
        default:
            Console.WriteLine("Geçersiz kategori.");
            return;
    }

    Console.Write("Eğitmen: ");
    string egitmen = Console.ReadLine() ?? "";

    Console.Write("Salon: ");
    string salon = Console.ReadLine() ?? "";

    Console.Write("Gün (1=Monday, 2=Tuesday, ... 7=Sunday): ");
    string? gunStr = Console.ReadLine();
    if (!int.TryParse(gunStr, out int gunNo) || gunNo < 1 || gunNo > 7)
    {
        Console.WriteLine("Geçersiz gün.");
        return;
    }
    DayOfWeek gun = (DayOfWeek)(gunNo - 1);

    Console.Write("Saat (HH:MM): ");
    string saatText = Console.ReadLine() ?? "";
    if (!TimeSpan.TryParse(saatText, out TimeSpan saat))
    {
        Console.WriteLine("Geçersiz saat, 00:00 kabul edildi.");
        saat = new TimeSpan(0, 0, 0);
    }

    Console.Write("Kontenjan: ");
    string? kontStr = Console.ReadLine();
    if (!int.TryParse(kontStr, out int kont))
    {
        Console.WriteLine("Geçersiz kontenjan.");
        return;
    }

    bool sonuc = system.AddLesson(id, ad, kategori, egitmen, salon, gun, saat, kont);

    Console.WriteLine(sonuc
        ? "Ders başarıyla eklendi."
        : "Bu Id ile zaten bir ders var. Kayıt yapılmadı.");
}

static void AdminRemoveLesson(GymSystem.Core.GymSystem system)
{
    Console.Write("Silmek istediğiniz dersin Id'si: ");
    string? idStr = Console.ReadLine();

    if (!int.TryParse(idStr, out int dersId))
    {
        Console.WriteLine("Geçersiz Id.");
        return;
    }

    bool sonuc = system.RemoveLesson(dersId);

    Console.WriteLine(sonuc
        ? "Ders ve tüm kayıtları sistemden silindi."
        : "Bu Id ile kayıtlı ders bulunamadı.");
}
