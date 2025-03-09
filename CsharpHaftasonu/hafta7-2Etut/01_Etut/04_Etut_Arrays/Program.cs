namespace _04_Etut_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir değer Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Başlangıç değerini giriniz");
            int basla = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[sayi];

            for (int i = 0; i < basla; i++)
            {
                Console.WriteLine("Değer giriniz");
                sayilar[i]=Convert.ToInt32(Console.ReadLine());

            }
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

        }
    }
}
