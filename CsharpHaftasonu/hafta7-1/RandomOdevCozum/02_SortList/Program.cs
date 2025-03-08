using System.Collections;

namespace _02_SortList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> sozluk = new SortedList<string, string>();
            sozluk.Add("mavi", "blue");
            sozluk.Add("beyaz", "white");
            sozluk.Add("siyah", "black");
            sozluk.Add("turuncu", "orange");
            sozluk.Add("kırmızı", "red");

            while (true)
            {
                Console.WriteLine("01-Arama\n02-Çıkarma\n03-Listeleme\n04-Çıkış\nSeçiminiz:");
                string secim = Console.ReadLine();
                if (secim=="1")
                {
                    Console.WriteLine("Aranacak Kelime");
                    string kelime = Console.ReadLine();
                    if (sozluk.ContainsKey(kelime))
                    {
                        Console.WriteLine(sozluk[kelime]);
                    }
                    else
                    {
                        Console.WriteLine("Kelime bulunamadı Eklemek ister misiniz");
                        string cevap = Console.ReadLine().ToLower();
                        if (cevap=="e")
                        {
                            Console.WriteLine($"{kelime} ingilizcesini giriniz.");
                            sozluk[kelime]=Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Tamam sen bilirsin");
                        }


                    }
                }
                else if (secim=="2")
                {
                    Console.WriteLine("Çıkarılacak Kelime");
                    string kelime = Console.ReadLine();
                    if (sozluk.ContainsKey(kelime))
                    {
                        sozluk.Remove(kelime);
                    }
                    else
                    {
                        Console.WriteLine("Zaen kelime ekli değil!");
                    }
                }
                else if (secim=="3")
                {
                    //key ve value ya göre getirmek için burada KeyValuePair yapısını kullanıyoruz string olarak getirmesini istiyoruz.
                    foreach (KeyValuePair<string, string> item in sozluk)
                    {
                        Console.WriteLine(item.Value+"=>"+item.Key);
                    }
                }
                else if (secim=="4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim");
                }
            }

        }
    }
}
