namespace _01_OpsionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opsiyonel parametre bir methodda opsiyonel parametre var ise bu alanı belirmeme durumumuz olabilir bu durumda method kendi içerisinde verilen varsayılan yapıyı kullanır o alanı doldurmak zorunlu olmaz bir veri tabanına null veri gönderimini engeller.
            //string ad = "Erkan";
            //string sad = "Merhaba";
            //Console.WriteLine(Yazdir(ad,sad));
            //UrunYazdir("Mouse", 2500);
            //UrunYazdir("Laptop", 55000, "Bilgisayar");
            string ad = "Erkan Türk";
            int yas = 20;
            string tc = "12345678910";
            string meslek = "Yazılım";
            string cinsiyet = "Erkek";
            string ulke = "Kanada";
            //methodun kendi parametrelerini kullandığımız için opsiyonel olanlar arasında kullanmak istemediklerimizi es geçebiliriz.
            Insan(adsoyad:"Erkan Türk",yas:30,tc:"14531453",cinsiyet:"Erkek");
            Insan(ad, yas, tc,  cinsiyet, ulke);
            //Eğer es geçmeyecek isek otomatik olarak ya tüm değerleri vereceğiz yada opsiyonel olanları boş bırakmalıyız.
            Insan("ad",yas,"tc");

        }
        //static string Yazdir(string ad, string soyad = "Türk")
        //{
        //    return ad+" "+soyad;
        //}
        //static void UrunYazdir(string ad, double fiyat, string kategory = "Elektronik")
        //{
        //    Console.WriteLine($"Ürün Adı: {ad}, Ürün Fiyatı: {fiyat}, kategorisi: {kategory}");
        //}
        static void Insan(string adsoyad, int yas, string tc, string meslek = "Serbest meslek", string cinsiyet = "Belirtmek istemiyor", string ulke = "Türkiye")
        {
            Console.WriteLine($"Adsoyad: {adsoyad} yaş: {yas} tc: {tc} meslek: {meslek} cinsiyet: {cinsiyet} ülke: {ulke}");
        }
    }
}
