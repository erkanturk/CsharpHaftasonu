namespace _01_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            METHODS - FONKSİYONLAR
           
            Metotlar: Yazılımcılar tarafından geliştirilen ve diğer yazılımcıların kullanımına sunulan hazır kod yapılarıdır. Metoda bir isim verilir ve o isim altında bir iş yapar kod bloğu yazılır ve yazılımcı o işi yapmak için kod bloğunu yazmak yerine metodu ismini yazarak çağırır.Çağrılan metot kendi içindeki kod bloğunu çalıştırır. Bu sayede yazılımcı tanımlı işin kodunu defalarca yazmaktan kurtulur.

            Metotlar ve Fonksiyonlar () ile tanımlanır.
            Metotlar iç içe TANIMLANAMAZLAR.
            Metotlar çağrılmadığı sürece bir işlem yapmazlar.
            Metotlar UNIQUE(benzersiz) olmalıdır. Aynı isme sahip metotların, metot imzaları farklı olmalıdır.(parametre sayısı,parametre veri tipi)

            Fonksiyonlar ise yazılımcının kendisinin oluşturduğu metotlardır.

            Metotlar 2'ye ayrılır.

            *Değer Döndüren(parametreli/parametresiz)
            *Değer Döndürmeyen(parametreli/parametresiz)


            Parametre: metot parantezleri içerisine yazılan ve metodu kullanırken gönderilecek verilerdir. 
            
                
             */

            Yaz();//iş yapan method çağırma işlemi.
            //YazIsim();//Hata vermesinin sebebi bir parametre verilmediği sürecede bu method kullanılamaz gereksinim karşılanmıyor demektir.
            string ad = "Tahsin";
            YazIsim("Erkan Türk");
            YazIsim(ad);
            Topla("Toplam", 20, 20.5);//İlk girilen parametre ne ise ona göre değer vermemiz gerekir int ise int ile başlamalıyız karışık bir şekilde değerleri aktaramayız sıralı bir şekilde aktarma işlemi yapmamız gerekiyor.


            //4 işlem yapan method yazın biri çıkarma biri toplama biri çarpma biri bölme işlemi yapacak.
        }
        static void Yaz()// Geri değer döndermeyen iş yapan parametsiz method void keywordü iş yapan method olduğunu belirtir.
        {
            Console.WriteLine("Merhaba");
        }
        static void YazIsim(string ad)//Parametreli iş yapan method
        {
            Console.WriteLine(ad);
        }
        static void Topla(string metin, int s1, double s2)
        {
            Console.WriteLine($"{metin}:{s1+s2}");
        }

       
    }
}
