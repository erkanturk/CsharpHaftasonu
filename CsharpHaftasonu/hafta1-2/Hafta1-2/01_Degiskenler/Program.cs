namespace _01_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Değiskenler (Variable) veri tipleri
            //C# veri korumalı bir dildir  (Data protected)
            //Metinsel ifade tanımı
            //string adSoyad = "Erkan Türk";//string metinsel ifadeleri barındıran veri yapısıdır.
            //char tekHarf = 'A';// Sadece tek bir karakter taşıyan yapıdır 
            ////rakamsal veri yapıları
            //int sayi = 10; // int tam sayı tipinde 10 haneye kadar tam sayı barındıran veri yapısı
            //long buyukSayi = 20; //long tam sayı tipinde  16 haneye kadar veri tutabilir.
            //double ondalikli = 25.5;//ondalikli sayı taşıyabilen veri yapısı
            //float ondalikli2 = 20.5f;//ondalıklı sayı taşıyan veri yapısı sonuna f işareti ile bildirmemiz gerekiyor
            //decimal ondalikli3 = 20.5m;//ondalıklı sayı taşıyan veri yapısı sonuna m işareti ile bildirmemiz gerekir.

            //bool dogruMu = true; // doğru veya yanlış değer taşıyan veri yapısı bool (true , false)

           
           
            //Console.WriteLine(adSoyad);

            ///* Değişken tanımlama kuralları
            //1.Değişkenler sayı ile başlayamaz örneğin 1sayi olamaz ama sayi1 olarak kullanabiliriz
            //2.Değişken isimlerinde özel karakterler kullanılamaz(!,@,?,.ve türkçe karakterler ş İ ı ğ ç ö ü vb.)
            //3.Değişken Tanımlarken boşluk kullanılamaz
            //4.Aynı ada ait iki değişken yapısı olamaz.
            //5.C# a özgü sınıf method adları değişken ismi olarak kullanılamaz.
            //6.Özellikle  c# ta belli bir yazış biçimi vardır. değişken isimleri camelCase ile yazılır. 
            //// snakeCase =ad_soyad;
            //// kebabcase=ad-soyad;
            ////uppercase=ADSOYAD;
            ////lowercase=adsoyad
            ////camelCase=adSoyad;
            //7.Değişken veya içerisinde veri girdiğimizde Bu değerler büyük küçük duyarlılıgı vardır Erkan ile erkan farklı yapılardır.
                               
            
            //*/
            //object nesne; //object içerisinde her veriyi tutabilen bir yapıdır
            //var deger = 20.5; // var ile işaretlenmesi içerisinde atadığımız veriye göre tip alır.
            //// her işlemimiz bittiminde ; işareti ile belirtmeliyiz.
            //const double PI = 3.14;// sabit değeri bildirmek için const kullanırız bu değer hiçbir türlü değiştirilemez.
            //adSoyad="Tahsin Canpolat";// aynı isme sahip değişkene farklı bir string veya aynı veri tipinde değer verirsek güncelleme işlemi yaparız Örneğin yukarıda Erkan türk olarak tanımlı adSoyad değeri Artık Tahsin Canpolat olarak güncellendi.
            //Console.WriteLine(PI);
            ////PI=3.15; const ile tanımlanan değer değiştirilemez.
            //Console.WriteLine(adSoyad);

            Console.WriteLine("Value-Typelar-Ram(Sol bölgesi) stack");
            Console.WriteLine($"en küçük değer byte {byte.MinValue} en büyük değer byte {byte.MaxValue}");//$ string interpolation yazım biçimi.
            Console.WriteLine("int En küçük deger: "+int.MinValue+"| int max value: "+ int.MaxValue);//string yazım biçimi
            Console.WriteLine("uint En küçük deger: "+uint.MinValue+"| uint max value: "+uint.MaxValue);//string yazım biçimi
            Console.WriteLine("uLong En küçük değer: {0} ulong en büyük değer:{1} ", ulong.MinValue, ulong.MaxValue);//index yazım biçimi
            Console.WriteLine("Long En küçük değer: {0} long en büyük değer:{1} ", long.MinValue, long.MaxValue);//index yazım biçimi
            Console.WriteLine($"Double en küçük değer: {double.MinValue} Double en büyük değer: {double.MaxValue}");
            Console.WriteLine($"Decimal en küçük değer: {decimal.MinValue} decimal en büyük değer {decimal.MaxValue}");
            Console.WriteLine($"float en küçük değer: {float.MinValue} float en büyük değer {float.MaxValue}");


            Console.WriteLine("Referance Typelar ram(Sağ bölgesi)Heap");
            Console.WriteLine("string");
            Console.WriteLine("Object");
        }
    }
}
