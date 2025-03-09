namespace _02_Etut_Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int sayi = 0;
            int sayi2 = 0;
            int toplam = 0;
            Console.WriteLine("Kaç adet değer girmek istiyorsun ?");
            sayi=Convert.ToInt32(Console.ReadLine());
            Deger(sayi, sayi2);
           
            Deger2(sayi,sayi2);
        }
        static void Deger(int sayi, int sayi2)
        {
            while (sayi>0)
            {
                Console.WriteLine("Deger giriniz");
                sayi2=Convert.ToInt32(Console.ReadLine());

                sayi--;
                
               
            }
            Console.WriteLine(sayi2+" "+sayi);



        }
        static void Deger2(int sayi,int sayi2 )
        {
            
          
          
            if (sayi>0)
            {

                Console.WriteLine("Değer Giriniz");
                sayi2 = Convert.ToInt32(Console.ReadLine());

              

                sayi--;
                Deger2(sayi,sayi2);
            }
           
            Console.WriteLine("sayı 2 tekrar eden "+sayi2+"Koşul adedi"+sayi);
        }
    }
}
