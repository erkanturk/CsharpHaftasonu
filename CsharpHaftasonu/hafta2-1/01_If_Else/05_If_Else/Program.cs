namespace _05_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kısa İf else Kullanımı
            int sayi = 5;
            if (sayi>10)
            {
                Console.WriteLine("Sayı büyüktür 10 dan");
            }
            else
            {
                Console.WriteLine("Sayı küçüktür 10 dan");
            }
            //? işareti eğer bir karşılaştırma yapıyor isek İf olarak gelir : ise Else olarak koşulu kontrol eder ? true ise bize "metin" bu alandaki değeri yazdırır değil ise else kısmı çalışır.
            string sonuc = sayi>10 ? "Sayı büyüktür 10" : "Sayı küçüktür 10";
            Console.WriteLine(sonuc);
        }
    }
}
