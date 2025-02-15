namespace _05_Swicth_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Swicth case
            /* switch case koşul yapısı bir karak yapısı olarak çalışır fakat if yapısından çalışma yapısı farklıdır aldığı değeri direkt olarak içersindeki case bloklarında olup olmadığını bilir ve duruma göre yok ise default değeri dönderir. true veya false durumuna göre çalışmaz.

            switch(koşul)
            {
                case 1: Console.WriteLine("Yazdır.") Break;

            }
             */

            //Console.WriteLine("Haftanın hangi Günü");
            //string cevap = Console.ReadLine();
            //switch (cevap)
            //{
            //    case "1": Console.WriteLine("Pazartesi"); break;
            //    case "2": Console.WriteLine("Salı"); break;
            //    case "3": Console.WriteLine("Çarşamba"); break;
            //    case "4": Console.WriteLine("Perşembe"); break;
            //    case "5": Console.WriteLine("Cuma"); break;
            //    case "6": Console.WriteLine("Cumartesi"); break;
            //    case "7": Console.WriteLine("Pazar"); break;
            //    default:
            //        Console.WriteLine("Haftada 7 gün var 1 ila 7 arasında değer girin");

            //        break;
            //}
            #endregion

            #region swicth case2
            // kullanıcıdan Hangi tür kitap istediğini soralım ve verdiği cevaba göre reyon bilgisini verelim
            //Console.WriteLine("Aradağınız Tür nedir");
            //string cevap = Console.ReadLine();
            //switch (cevap)
            //{
            //    case"Aksiyon": Console.WriteLine($"{cevap} Türü A reyonundadır"); break;
            //    case "Bilim kurgu": Console.WriteLine($"{cevap} Türü B reyonundadır"); break;
            //    case "Romantik komedi": Console.WriteLine($"{cevap} Türü C reyonundadır"); break;
            //    case "Dünya klasikleri": Console.WriteLine($"{cevap} Türü D reyonundadır"); break;

            //    default:
            //        Console.WriteLine($"{cevap}: Bu türe ait kitap bulunamadı");
            //        break;
            //}
            #endregion
            #region switch case3
            // Kullanıcıdan iki adet sayı alalım ve sonrasında yapmak istediği işlemi soralım 
            //yapmak istediğiniz işlem olarak (+,*,/,-) işlemleri olacak
            //don:
            //    Console.WriteLine("Lütfen 1. sayıyı giriniz");
            //    double sayi = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Lütfen 2. sayıyı giriniz");
            //    double sayi2 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Yapmak istediğiniz işlemi belirtin\n(*)\n(/)\n(-)\n(+)");
            //    string cevap = Console.ReadLine();

            //    switch (cevap)
            //    {
            //        case "+": Console.WriteLine("Sonuç:"+(sayi+sayi2)); break;
            //        case "*": Console.WriteLine("Sonuç:"+(sayi*sayi2)); break;
            //        case "-": Console.WriteLine("Sonuç:"+(sayi-sayi2)); break;
            //        case "/":
            //            if (sayi2!=0)
            //            {
            //                Console.WriteLine("Sonuç:"+(sayi/sayi2));
            //            }
            //            else
            //            {
            //                Console.WriteLine("Sayı Sıfıra Bölünemez");
            //                goto don;
            //            }
            //            break;

            //        default: Console.WriteLine("Yanlış işlem seçimi"); break;


            //    }

            #endregion

            #region swicth Case4
            // ufak bir kasiyer satış işlemi yapalım stok miktarı ürün satıldı ise stok azaltılsın stok eklenmek istediğinde admin tarafı ekleme işlemi yapsın
            //Console.WriteLine("Yapmak istediğiniz işlemi giriniz \n1-Satış yap \n2-Stok Eksilt \n3-Stok artır");
            //string cevap = Console.ReadLine();
            //switch (cevap)
            //{
            //    case "1": Console.WriteLine("Satış yapıldı"); goto case "2";
            //    case "2": Console.WriteLine("Stok eksiltildi"); break;
            //    case "3": Console.WriteLine("Stok Eklendi"); break;

            //    default:
            //        Console.WriteLine("Hatalı işlem");
            //        break;
            //}


            #endregion

            Console.WriteLine("Plaka gir Şehir bul");
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 01: Console.WriteLine("Girdiğiniz plaka Adana"); break;
                case 04: Console.WriteLine("Girdiğiniz plaka Ağrı"); break ;
                case 05: Console.WriteLine("Girdiğiniz plaka Amasya"); break;
                case 06: Console.WriteLine("Girdiğiniz plaka Ankara"); break;
                case 16: Console.WriteLine("Girdiğiniz plaka Bursa"); break;
                case 19: Console.WriteLine("Girdiğiniz plaka Çorum"); break;
                case 25: Console.WriteLine("Girdiğiniz plaka Erzurum");break;
                case 31: Console.WriteLine("Girdiğiniz plaka Hatay"); break;
                case 34: Console.WriteLine("Girdiğiniz plaka İstanbul"); break;
                case 35: Console.WriteLine("Girdiğiniz plaka İzmir"); break;
                case 37: Console.WriteLine("Girdiğiniz plaka Kastamonu"); break;
                case 42: Console.WriteLine("Girdiğiniz plaka Konya");break;
                case 53: Console.WriteLine("Girdiğiniz plaka Rize"); break;
                case 58: Console.WriteLine("Girdiğiniz plaka Sivas"); break;
                case 60: Console.WriteLine("Girdiğiniz plaka Tokat"); break;
                case 61: Console.WriteLine("Girdiğiniz plaka Trabzon");break;
                case 68: Console.WriteLine("Girdiğiniz plaka Aksaray");break;
                default:
                    Console.WriteLine("Sistemde yaşanan teknik aksaklık dolayısıyla Bilgi veremiyoruz Lütfen sonra deneyin.");
                    break;
            }
        }
    }
}
