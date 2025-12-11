using OOP_Proje1.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GymSystem.Core
{
    // Spor salonu sisteminin beyni
    public class GymSystem
    {
        // Sistemdeki tüm üyeler
        public List<Member> Members { get; } = new List<Member>();

        // Sistemdeki tüm grup dersleri
        public List<GroupLesson> Lessons { get; } = new List<GroupLesson>();

        private readonly string _projectBasePath;

        // Paketleri isimden tekrar kullanmak için sözlük
        private readonly Dictionary<string, MembershipPackage> _packagesByName
            = new Dictionary<string, MembershipPackage>();

        // Kurucu: varsayılan dosyalardan veriyi yükler
        public GymSystem()
        {
            _projectBasePath = GetProjectBasePath();

            LoadMembersFromFile(Path.Combine(_projectBasePath, "members.txt"));
            LoadLessonsFromFile(Path.Combine(_projectBasePath, "lessons.txt"));
            LoadRegistrationsFromFile(Path.Combine(_projectBasePath, "registrations.txt"));
        }

        // ------------------ LOGIN ------------------
        public Member? Login(string tcKimlikNo, string sifre)
        {
            return Members.FirstOrDefault(m =>
                m.TcKimlikNo == tcKimlikNo &&
                m.Sifre == sifre);
        }

        // ------------------ DERSLERİ KATEGORİYE GÖRE GETİR ------------------
        public IEnumerable<GroupLesson> GetLessonsByCategory(LessonCategory category)
        {
            return Lessons.Where(l => l.Kategori == category);
        }

        // ------------------ ÜYELERİ DOSYADAN OKU ------------------
        public void LoadMembersFromFile(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            foreach (var line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split(';');
                if (parts.Length < 6)
                    continue; // bozuk satır varsa atla

                string tc = parts[0];
                string sifre = parts[1];
                string ad = parts[2];
                string soyad = parts[3];
                string paketAdi = parts[4];
                string bitisStr = parts[5];

                var paket = GetOrCreatePackage(paketAdi);

                DateTime bitisTarihi;
                if (!DateTime.TryParse(bitisStr, out bitisTarihi))
                {
                    bitisTarihi = DateTime.Now;
                }

                var member = new Member(tc, sifre, ad, soyad)
                {
                    UyelikPaketi = paket,
                    UyelikBitisTarihi = bitisTarihi
                };

                Members.Add(member);
            }
        }

        // ------------------ DERSLERİ DOSYADAN OKU ------------------
        public void LoadLessonsFromFile(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            foreach (var line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split(';');
                if (parts.Length < 8)
                    continue;

                int id = int.Parse(parts[0]);
                string ad = parts[1];
                string kategoriStr = parts[2];
                string egitmen = parts[3];
                string salon = parts[4];
                string gunStr = parts[5];
                string saatStr = parts[6];
                int kontenjanToplam = int.Parse(parts[7]);

                if (!Enum.TryParse<LessonCategory>(kategoriStr, out var kategori))
                    continue;

                if (!Enum.TryParse<DayOfWeek>(gunStr, out var gun))
                    continue;

                TimeSpan saat;
                if (!TimeSpan.TryParse(saatStr, out saat))
                    saat = new TimeSpan(0, 0, 0);

                var lesson = new GroupLesson(id, ad, kategori)
                {
                    Egitmen = egitmen,
                    Salon = salon,
                    Gun = gun,
                    Saat = saat,
                    KontenjanToplam = kontenjanToplam
                };

                Lessons.Add(lesson);
            }
        }

        // ------------------ KAYITLARI DOSYADAN OKU ------------------
        public void LoadRegistrationsFromFile(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            foreach (var line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split(';');
                if (parts.Length < 2)
                    continue;

                if (!int.TryParse(parts[0], out int dersId))
                    continue;

                string tc = parts[1];

                var lesson = Lessons.FirstOrDefault(l => l.Id == dersId);
                var member = Members.FirstOrDefault(m => m.TcKimlikNo == tc);

                if (lesson != null && member != null)
                {
                    lesson.UyeKaydet(member);
                }
            }
        }

        // ------------------ YARDIMCI: PAKET OLUŞTUR / BUL ------------------
        private MembershipPackage GetOrCreatePackage(string paketAdi)
        {
            if (string.IsNullOrWhiteSpace(paketAdi))
                paketAdi = "Bilinmeyen Paket";

            if (!_packagesByName.TryGetValue(paketAdi, out var paket))
            {
                paket = new MembershipPackage(paketAdi, "");
                _packagesByName[paketAdi] = paket;
            }

            return paket;
        }

        // ------------------ YENİ ÜYE KAYDI ------------------
        public bool RegisterNewMember(
            string tc,
            string sifre,
            string ad,
            string soyad,
            string paketAdi,
            DateTime bitisTarihi,
            string fileName = "members.txt")
        {
            if (Members.Any(m => m.TcKimlikNo == tc))
            {
                return false;
            }

            var paket = GetOrCreatePackage(paketAdi);

            var member = new Member(tc, sifre, ad, soyad)
            {
                UyelikPaketi = paket,
                UyelikBitisTarihi = bitisTarihi
            };

            Members.Add(member);

            string line =
                $"{tc};{sifre};{ad};{soyad};{paketAdi};{bitisTarihi:yyyy-MM-dd}";

            string fullPath = Path.Combine(_projectBasePath, fileName);

            File.AppendAllLines(fullPath, new[] { line });

            return true;
        }

        // ------------------ ÜYEYİ DERSE KAYDET ------------------
        public bool RegisterMemberToLesson(
            string tcKimlikNo,
            int dersId,
            string fileName = "registrations.txt")
        {
            // 1) Üye ve dersi bul
            var member = Members.FirstOrDefault(m => m.TcKimlikNo == tcKimlikNo);
            var lesson = Lessons.FirstOrDefault(l => l.Id == dersId);

            if (member == null || lesson == null)
            {
                // Üye veya ders bulunamadı
                return false;
            }

            // 2) Zaten kayıtlı mı, kontenjan dolu mu vs. => GroupLesson tarafındaki iş mantığına bırak
            bool kayitBasarili = lesson.UyeKaydet(member);

            if (!kayitBasarili)
            {
                // Boş yer yoksa veya zaten kayıtlıysa burada false döner
                return false;
            }

            // 3) Kayıt başarılıysa registrations.txt dosyasına satır ekle
            string line = $"{dersId};{tcKimlikNo}";

            // Eğer sen base path olayı yaptıysan:
            // string fullPath = Path.Combine(_projectBasePath, fileName);
            // File.AppendAllLines(fullPath, new[] { line });

            // Basit versiyon (çalışma klasöründeki registrations.txt'ye yazar):
            File.AppendAllLines(fileName, new[] { line });

            return true;
        }

        // ------------------ ÜYEYİ DERSTEN SİL (KAYDI İPTAL ET) ------------------
        public bool CancelMemberFromLesson(
            string tcKimlikNo,
            int dersId,
            string fileName = "registrations.txt")
        {
            var member = Members.FirstOrDefault(m => m.TcKimlikNo == tcKimlikNo);
            var lesson = Lessons.FirstOrDefault(l => l.Id == dersId);

            if (member == null || lesson == null)
                return false;

            // Üye gerçekten bu derse kayıtlı mı kontrol edelim
            if (!lesson.KayitliUyeler.Any(m => m.TcKimlikNo == tcKimlikNo))
                return false;

            // 1) Bellekten sil (dersteki listeden ve üyenin listesinden)
            lesson.KayitliUyeler.RemoveAll(m => m.TcKimlikNo == tcKimlikNo);
            member.KayitliDersler.RemoveAll(d => d.Id == dersId);

            // 2) registrations.txt'den de silelim
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName).ToList();

                lines = lines
                    .Where(line =>
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            return false == false; // satırı bozmamak için, daha okunaklı yazalım:

                        var parts = line.Split(';');
                        if (parts.Length < 2)
                            return true; // bozuk satır, dokunma

                        // DersId ve Tc uyuyorsa bu kaydı at (false döndür)
                        if (int.TryParse(parts[0], out int id) && id == dersId && parts[1] == tcKimlikNo)
                            return false;

                        return true;
                    })
                    .ToList();

                File.WriteAllLines(fileName, lines);
            }

            return true;
        }

        // ------------------ YÖNETİCİ: YENİ DERS EKLE ------------------
        public bool AddLesson(
            int id,
            string ad,
            LessonCategory kategori,
            string egitmen,
            string salon,
            DayOfWeek gun,
            TimeSpan saat,
            int kontenjanToplam,
            string fileName = "lessons.txt")
        {
            // Aynı Id ile ders zaten var mı?
            if (Lessons.Any(l => l.Id == id))
                return false;

            var lesson = new GroupLesson(id, ad, kategori)
            {
                Egitmen = egitmen,
                Salon = salon,
                Gun = gun,
                Saat = saat,
                KontenjanToplam = kontenjanToplam
            };

            Lessons.Add(lesson);

            // Dosyaya da ekleyelim
            string line =
                $"{id};{ad};{kategori};{egitmen};{salon};{gun};{saat:hh\\:mm};{kontenjanToplam}";

            File.AppendAllLines(fileName, new[] { line });

            return true;
        }

        // ------------------ YÖNETİCİ: DERS SİL ------------------
        public bool RemoveLesson(
            int dersId,
            string lessonsFile = "lessons.txt",
            string registrationsFile = "registrations.txt")
        {
            var lesson = Lessons.FirstOrDefault(l => l.Id == dersId);
            if (lesson == null)
                return false;

            // 1) Üyelerin kayıtlı derslerinden de çıkar
            foreach (var member in Members)
            {
                member.KayitliDersler.RemoveAll(d => d.Id == dersId);
            }

            // 2) Sistem ders listesinden çıkar
            Lessons.RemoveAll(l => l.Id == dersId);

            // 3) lessons.txt içinden bu Id'ye sahip satırı sil
            if (File.Exists(lessonsFile))
            {
                var lines = File.ReadAllLines(lessonsFile).ToList();
                lines = lines.Where(line =>
                {
                    if (string.IsNullOrWhiteSpace(line))
                        return false == false; // satır boşsa bırak

                    var parts = line.Split(';');
                    if (parts.Length < 1)
                        return true;

                    if (int.TryParse(parts[0], out int id) && id == dersId)
                        return false; // bu dersi at

                    return true;
                }).ToList();

                File.WriteAllLines(lessonsFile, lines);
            }

            // 4) registrations.txt içinden bu derse ait kayıtları sil
            if (File.Exists(registrationsFile))
            {
                var lines = File.ReadAllLines(registrationsFile).ToList();
                lines = lines.Where(line =>
                {
                    if (string.IsNullOrWhiteSpace(line))
                        return false == false;

                    var parts = line.Split(';');
                    if (parts.Length < 2)
                        return true;

                    if (int.TryParse(parts[0], out int id) && id == dersId)
                        return false; // bu derse ait kayıtları at

                    return true;
                }).ToList();

                File.WriteAllLines(registrationsFile, lines);
            }

            return true;
        }

        // ------------------ YÖNETİCİ: ÜYE SİL ------------------
        public bool RemoveMember(
            string tcKimlikNo,
            string membersFile = "members.txt",
            string registrationsFile = "registrations.txt")
        {
            var member = Members.FirstOrDefault(m => m.TcKimlikNo == tcKimlikNo);
            if (member == null)
                return false;

            // 1) Üyenin kayıtlı olduğu derslerden çıkar
            foreach (var ders in Lessons)
            {
                ders.KayitliUyeler.RemoveAll(m => m.TcKimlikNo == tcKimlikNo);
            }

            // 2) Members listesinden çıkar
            Members.RemoveAll(m => m.TcKimlikNo == tcKimlikNo);

            // 3) members.txt içinden bu üyeyi sil
            if (File.Exists(membersFile))
            {
                var lines = File.ReadAllLines(membersFile).ToList();
                lines = lines.Where(line =>
                {
                    if (string.IsNullOrWhiteSpace(line))
                        return false == false;

                    var parts = line.Split(';');
                    if (parts.Length < 1)
                        return true;

                    if (parts[0] == tcKimlikNo)
                        return false; // bu üyeyi at

                    return true;
                }).ToList();

                File.WriteAllLines(membersFile, lines);
            }

            // 4) registrations.txt içinden bu üyenin tüm kayıtlarını sil
            if (File.Exists(registrationsFile))
            {
                var lines = File.ReadAllLines(registrationsFile).ToList();
                lines = lines.Where(line =>
                {
                    if (string.IsNullOrWhiteSpace(line))
                        return false == false;

                    var parts = line.Split(';');
                    if (parts.Length < 2)
                        return true;

                    if (parts[1] == tcKimlikNo)
                        return false; // bu üyenin kayıtlarını at

                    return true;
                }).ToList();

                File.WriteAllLines(registrationsFile, lines);
            }

            return true;
        }


        // Çalışan EXE klasöründen projeye geri çıkıp kök dizini bulur
        private string GetProjectBasePath()
        {
            // örn: ...\OOP Proje1\bin\Debug\net8.0
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;

            // 3 kez ".." diyerek OOP Proje1 klasörüne geri dönüyoruz
            var projectDir = Path.GetFullPath(Path.Combine(baseDir, @"..\..\.."));

            return projectDir;
        }

    }
}
