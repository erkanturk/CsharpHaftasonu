namespace _04_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tek çift kontrol
            //Kullanıcının girdiği sayı tek mi çift mi olduğunu bulunuz.
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());


            //if (sayi%2==0)
            //{
            //    Console.WriteLine("Sayı çiftir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion
            //Kullanıcıdan 5 adet sayı girmesini isteyin ve girilen sayıların çift olanlarını Çift toplam 
            //tek olanlarını tek toplam olarak ayırın ve Sonucu yazdırın.

            int tekToplam = 0;
            int ciftToplam = 0;

            int sayi, sayi2, sayi3, sayi4, sayi5;//çoklu değişken oluşturma
            Console.WriteLine("1.sayı");
            sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sayı");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4.sayı");
            sayi4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5.sayı");
            sayi5 = Convert.ToInt32(Console.ReadLine());

            if (sayi %2==0)
            {
                ciftToplam+=sayi;
            }
            else
            {
                tekToplam+=sayi;
            }
            if (sayi2% 2==0)
            {
                ciftToplam+=sayi2;
            }
            else
            {
                tekToplam+=sayi2;
            }
            if (sayi3% 2==0)
            {
                ciftToplam+=sayi3;
            }
            else
            {
                tekToplam+=sayi3;
            }
            if (sayi4% 2==0)
            {
                ciftToplam+=sayi4;
            }
            else
            {
                tekToplam+=sayi4;
            }
            if (sayi5%2==0)
            {
                ciftToplam+=sayi5;
            }
            else
            {
                tekToplam+=sayi5;
            }
            Console.WriteLine("Tek sayıların Toplamı: "+ tekToplam);
            Console.WriteLine("Çift sayıların Toplamı: {0}",ciftToplam);



        }
    }
}
