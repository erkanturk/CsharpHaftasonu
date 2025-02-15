namespace _01_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Condition yapısı (Koşul yapısı)
            
            if (eğer) bu alanda yapı true ise içindeki kod bloğu çalışır değilse eğer (Else if) bir sonraki koşul kontrol edili burasıda istediğimiz koşulu sağlamıyor ise else yapısı geriye kalan tüm koşulları kapsar.
            if else yapılarının içerisine koşul yazılır bu koşullar bize true veya false değerler dönderir ve programın akışı buna göre şekillenir.

            */
            #region Else if Örnek
            int sayi = 0;
            if (sayi>0)
            {
                Console.WriteLine("Sayı 0 dan büyüktür");
            }
            else if (sayi<0)
            {
                Console.WriteLine("Sayı 0 dan Küçüktür");
            }
            else//else kısmı geriye kalan tüm koşulları barındırdığı için bir karşılaştırma yapılamaz.
            {
                Console.WriteLine("Sayı 0 a eşittir.");
            }
            #endregion

        }
    }
}
