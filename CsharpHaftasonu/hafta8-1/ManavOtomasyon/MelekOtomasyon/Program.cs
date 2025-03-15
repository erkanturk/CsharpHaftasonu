namespace MelekOtomasyon
{
    internal class Program
    {
      
            static void Main(string[] args)
            {
                bool halDevam = true;
                bool manavDevam = true;
                double sepet = 0;

                string[] meyveler = { "çilek", "muz", "yabanmersini", "böğürtlen", "ahududu" };
                string[] sebzeler = { "domates", "salatalık", "patates", "havuç", "patlıcan" };

                string[] alinanUrunler = new string[10];
                double[] alinanKilolar = new double[10];
                int urunSayisi = 0;


                while (halDevam)
                {
                    Console.WriteLine("\n************************* HAL BÖLÜMÜ *************************");
                    Console.WriteLine("Meyve mi Sebze mi? (m: Meyve, s: Sebze)");
                    string secim = Console.ReadLine().ToLower();

                    string[] secilenListe = null;
                    if (secim == "m")
                    {
                        Console.WriteLine("Meyveler:");
                        secilenListe = meyveler;
                    }
                    else if (secim == "s")
                    {
                        Console.WriteLine("Sebzeler:");
                        secilenListe = sebzeler;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim! Lütfen 'm' veya 's' giriniz.");
                        continue;
                    }

                    for (int i = 0; i < secilenListe.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {secilenListe[i]}");
                    }

                    Console.Write("Lütfen almak istediğiniz ürünün numarasını giriniz: ");
                    if (!int.TryParse(Console.ReadLine(), out int urunNum) || urunNum < 1 || urunNum > secilenListe.Length)
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir ürün numarası giriniz.");
                        continue;
                    }

                    string secilenUrun = secilenListe[urunNum - 1];

                    Console.Write("Kaç kilo almak istiyorsunuz? ");
                    if (!double.TryParse(Console.ReadLine(), out double kilo) || kilo <= 0)
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir kilo değeri giriniz.");
                        continue;
                    }

                    bool urunVar = false;
                    for (int i = 0; i < urunSayisi; i++)
                    {
                        if (alinanUrunler[i] == secilenUrun)
                        {
                            alinanKilolar[i] += kilo;
                            urunVar = true;
                            break;
                        }
                    }

                    if (!urunVar && urunSayisi < alinanUrunler.Length)
                    {
                        alinanUrunler[urunSayisi] = secilenUrun;
                        alinanKilolar[urunSayisi] = kilo;
                        urunSayisi++;
                    }

                    Console.Write("Başka bir arzunuz var mı? (E/H): ");
                    string devamMi = Console.ReadLine().ToUpper();
                    if (devamMi == "H")
                    {
                        halDevam = false;
                    }
                }


                Console.WriteLine("\n********** HALDEN ALINAN ÜRÜNLER **********");
                for (int i = 0; i < urunSayisi; i++)
                {
                    Console.WriteLine($"{alinanUrunler[i]}: {alinanKilolar[i]} kg");
                }


                while (manavDevam)
                {
                    Console.WriteLine("\n************************* MANAV BÖLÜMÜ *************************");
                    Console.WriteLine("Müşteri Meyve mi Sebze mi istiyor? (m: Meyve, s: Sebze)");
                    string secim = Console.ReadLine().ToLower();

                    Console.WriteLine("Mevcut ürünler:");
                    for (int i = 0; i < urunSayisi; i++)
                    {
                        Console.WriteLine($"{i + 1}. {alinanUrunler[i]} - {alinanKilolar[i]} kg mevcut");
                    }

                    Console.Write("Lütfen almak istediğiniz ürünün numarasını giriniz: ");
                    if (!int.TryParse(Console.ReadLine(), out int urunNum) || urunNum < 1 || urunNum > urunSayisi)
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir ürün numarası giriniz.");
                        continue;
                    }

                    string secilenUrun = alinanUrunler[urunNum - 1];

                    Console.Write("Kaç kilo almak istiyorsunuz? ");
                    if (!double.TryParse(Console.ReadLine(), out double kilo) || kilo <= 0)
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir kilo değeri giriniz.");
                        continue;
                    }

                    bool urunBulundu = false;
                    for (int i = 0; i < urunSayisi; i++)
                    {
                        if (alinanUrunler[i] == secilenUrun && alinanKilolar[i] >= kilo)
                        {
                            alinanKilolar[i] -= kilo;
                            Console.WriteLine($"{kilo} kg {secilenUrun} satıldı.");
                            urunBulundu = true;
                            break;
                        }
                    }

                    if (!urunBulundu)
                    {
                        Console.WriteLine("Yetersiz stok!");
                    }

                    Console.Write("Başka bir arzunuz var mı? (E/H): ");
                    string devamMi = Console.ReadLine().ToUpper();
                    if (devamMi == "H")
                    {
                        manavDevam = false;
                    }
                }


                Console.WriteLine("\n********** MÜŞTERİNİN ALDIĞI ÜRÜNLER **********");
                for (int i = 0; i < urunSayisi; i++)
                {
                    if (alinanKilolar[i] > 0)
                    {
                        Console.WriteLine($"{alinanUrunler[i]}: {alinanKilolar[i]} kg");
                    }
                }

                Console.WriteLine("Teşekkür ederiz, iyi günler!");
            }
        
    }
}
