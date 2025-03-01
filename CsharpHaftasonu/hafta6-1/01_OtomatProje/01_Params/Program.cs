namespace _01_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            //Params keywordü bir methodda sınırlı bir yapıyı kaldırmaya yarar örneğin bir method 2 parametre alıyor ise 3. sü params ise buradaki yapı sınırsız değer almasını sağlar.
            int[] dizi = { 1, 2, 3 };   
            int[] dizi2 = { 10, 20, 30 };
            //DiziYazdir([20,30,40,50,60]);
            //DiziYazdir(dizi);
            DiziYazdir2(dizi, dizi2, 20, "Merhaba", "Params", true, DateTime.Now, 'A', 22.5, 10, 20, 30, 40, 50, 60, 70, 80, 90);
            //DiziYazdir3(dizi, dizi2);//Bu şekilde dizi içinde dizi yapmaya çalışırız ve hata verir.
            DiziYazdir3(10, 20, 30, 40, 50, 60, 70, 80, 90, 100);
        }
        static void DiziYazdir(int[] sayilar)
        {
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
        }
        static void DiziYazdir2(int[] dizi, int[] dizi2, int sayi, params object[] objects)
        {
            foreach (int i in dizi2)
            {
                Console.WriteLine(i);
            }
            foreach (int i in dizi)
            {
                Console.WriteLine(i);
            }
            foreach (var i in objects)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(sayi);
        }
        static void DiziYazdir3( params int[] dizi)
        {
            foreach (int i in dizi)
            {
                Console.WriteLine(i);
            }
        }
    }
}
