namespace UmutProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] halMeyve = { "Elma", "Armut", "Portakal", "Muz", "Kavun" };
            string[] halSebze = { "Domates", "Salatalık", "Patates", "Biber", "Soğan" };

            string[] manavUrunler = new string[100]; //başlangıç boyutu olarak bu ama istersek çoğaltırız
            double[] manavMiktarlar = new double[100];
            int urunSayisi = 0;

            Console.WriteLine("***** Manav-Hal Uygulamasına Hoş Geldiniz ******");

            while (true)
            {
                Console.WriteLine("\n1. hal işlemleri");
                Console.WriteLine("2. manav islemleri");
                Console.WriteLine("3. cıkıs");

                Console.Write("Lütfen yapmak istediğiniz işlemi seçin: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Clear();
                        HalIslemleri(halMeyve, halSebze, manavUrunler, manavMiktarlar, ref urunSayisi);
                        break;
                    case "2":
                        Console.Clear();
                        ManavIslemleri(manavUrunler, manavMiktarlar, urunSayisi);
                        break;
                    case "3":
                        Console.WriteLine("iyi günler dileriz!");
                        return;
                    default:
                        Console.WriteLine("geçersiz seçim lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void HalIslemleri(string[] halMeyve, string[] halSebze, string[] manavUrunler, double[] manavMiktarlar, ref int urunSayisi)
        {
            while (true)
            {
                Console.WriteLine("\n***Hal İşlemleri /**");
                Console.WriteLine("Güncel Ürün Listesi:");

                Console.WriteLine("Meyveler:");
                foreach (var meyve in halMeyve)
                {
                    Console.WriteLine($"- {meyve}");
                }

                Console.WriteLine("\nSebzeler:");
                foreach (var sebze in halSebze)
                {
                    Console.WriteLine($"- {sebze}");
                }

                Console.Write("\nHangi ürünü almak istersiniz? (Ürün adı yazınız): ");
                string secilenUrun = Console.ReadLine().ToLower();

                string[] tumUrunler = new string[halMeyve.Length + halSebze.Length];
                Array.Copy(halMeyve, tumUrunler, halMeyve.Length);
                Array.Copy(halSebze, 0, tumUrunler, halMeyve.Length, halSebze.Length);

                bool urunVarMi = false;
                for (int i = 0; i < tumUrunler.Length; i++)
                {
                    if (tumUrunler[i].ToLower() == secilenUrun)
                    {
                        urunVarMi = true;
                        break;
                    }
                }

                if (!urunVarMi)
                {
                    Console.WriteLine("geçersiz ürün lütfen listeden bir ürün adı yazın.");
                    continue;
                }

                Console.Write($"{secilenUrun} için kaç kilo almak istersiniz? Kilo: ");
                double kilo = 0;
                bool kiloValid = double.TryParse(Console.ReadLine(), out kilo);
                if (!kiloValid || kilo <= 0)
                {
                    Console.WriteLine("Geçerli bir kilo değeri girin!");
                    continue;
                }

                int urunIndex = Array.IndexOf(manavUrunler, secilenUrun, 0, urunSayisi);
                if (urunIndex != -1)
                {
                    manavMiktarlar[urunIndex] += kilo;
                }
                else
                {
                    manavUrunler[urunSayisi] = secilenUrun;
                    manavMiktarlar[urunSayisi] = kilo;
                    urunSayisi++;
                }

                Console.WriteLine($"{kilo} kg {secilenUrun} eklendi.");

                Console.Write("Başka bir ürün almak ister misiniz? (E/H): ");
                string devam = Console.ReadLine().ToUpper();
                if (devam == "H")
                {
                    break;
                }
            }
        }

        static void ManavIslemleri(string[] manavUrunler, double[] manavMiktarlar, int urunSayisi)
        {
            while (true)
            {
                Console.WriteLine("\n*****Manav İşlemleri****");

                bool urunVarMi = false;
                for (int i = 0; i < urunSayisi; i++)
                {
                    if (manavMiktarlar[i] > 0)
                    {
                        urunVarMi = true;
                        break;
                    }
                }

                if (!urunVarMi)
                {
                    Console.WriteLine("Manav tezgahında ürün bulunmuyor.");
                    Console.Write("Hale gitmek ister misiniz? [menü] (E/H): ");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap == "E")
                    {
                        return; // hale yönlendiriyor bu kısım
                    }
                    else
                    {
                        break; // manav islemlerinden cıkmaya yarıyor bu
                    }
                }

                Console.WriteLine("manavda olan Ürünler:");

                for (int i = 0; i < urunSayisi; i++)
                {
                    if (manavMiktarlar[i] > 0)
                    {
                        Console.WriteLine($"{manavUrunler[i]}: {manavMiktarlar[i]} kg");
                    }
                }

                Console.Write("\nhangi ürünü satacaksin (Ürün adı yazınız): ");
                string secilenUrun = Console.ReadLine().ToLower();

                int urunIndex = Array.IndexOf(manavUrunler, secilenUrun, 0, urunSayisi);
                if (urunIndex == -1 || manavMiktarlar[urunIndex] <= 0)
                {
                    Console.WriteLine("manavda bu üründen bulunmuyo ki");
                    continue;
                }

                Console.Write($"{secilenUrun} için kaç kilo satmak istersiniz? Kilo: ");
                double kilo = 0;
                bool kilodeger = double.TryParse(Console.ReadLine(), out kilo);
                if (!kilodeger || kilo <= 0)
                {
                    Console.WriteLine("geçerli bir kilo değeri girin");
                    continue;
                }

                if (manavMiktarlar[urunIndex] >= kilo)
                {
                    manavMiktarlar[urunIndex] -= kilo;
                    Console.WriteLine($"{kilo} kg {secilenUrun} satıldı.");
                }
                else
                {
                    Console.WriteLine($"Stokta sadece {manavMiktarlar[urunIndex]} kg var. Satış yapılamadı.");
                }

                Console.Write("Başka bir satış yapmak ister misiniz? (E/H): ");
                string devam = Console.ReadLine().ToUpper();
                if (devam == "H")
                {
                    break;
                }
            }

            Console.WriteLine("\n=== İşlem Sonunda Kalan Ürünler ===");
            for (int i = 0; i < urunSayisi; i++)
            {
                if (manavMiktarlar[i] > 0)
                {
                    Console.WriteLine($"{manavUrunler[i]}: {manavMiktarlar[i]} kg");
                }
            }
        }
    }
}

