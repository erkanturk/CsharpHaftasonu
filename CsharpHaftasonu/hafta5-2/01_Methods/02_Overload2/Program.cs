namespace _02_Overload2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* Overload Method (Aşırı yüklenmiş)
            Bir methodun aynı isim ile birden fazla kez tanınmış olmasıdır.
            Bir method aynı isimle tanımlandıklarında METHOD İMZALARI farklı olması gerekir
            Method imzası Parametre sayısı Parametre veri tipi 

            
            */
            int[] ints = { 1, 2, 3, 4 };
            string[] strings = { "Melek", "Okan", "Hikmet", "Yavuz", "Umut", "Tuğberk", "Ömer", "Deniz" };
            double[] doubles = { 25.5, 10.5 };
            object[] objects = { true, false };

            DiziAl(ints);
            DiziAl(strings);
            DiziAl(ints, doubles);
            DiziAl(objects);
            DiziAl(20, ints);
            int[] dizis = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            // dışarıda tanımlı olan bir dizinin elemanlarını method ile içeride tanımladık ve her bir elemanını yazdırdık
            Diziler(dizis);

            //Summary Developerların bilgilendirmek amacı ile kullandığı bir araçtır bu araç genellikle hangi methodun ne işe yaradığını belirtmek ve o methodun parametrelerini yada bir kaynak belirtmek amacıyla kullanılır summary kullanımı için üç adet / ifadesi yapmak yeterlidir.





        }
        /// <summary>
        /// Dizi alan int Dizi yazdıran method
        /// </summary>
        /// <param name="dizi"></param>
        ///<retuns>Dizileri al başka diziye aktar ve ekrana yazdır</retuns>
        static void Diziler(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                int[] dizis2 = new int[10];
                dizis2[i] = dizi[i];
            }
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

        }
        /// <summary>
        /// <see href="https://www.google.com.tr/?hl=tr"/>
        /// </summary>
        /// <param name="dizi"></param>
        static void DiziAl(int[] dizi)
        {


            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("ints dizi");
            Thread.Sleep(10000);
        }

        static void DiziAl(string[] dizi)
        {
            Console.Clear();
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("string dizi");
            Thread.Sleep(10000);
        }
        static void DiziAl(int[] dizi, double[] dizi2)
        {
            Console.Clear();
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("int dizi double dizi");
            Thread.Sleep(10000);
        }
        static void DiziAl(int sayi, int[] dizi)
        {
            Console.Clear();
            Console.WriteLine(sayi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("int sayi ints dizi");
            Thread.Sleep(10000);
        }
        static void DiziAl(object[] dizi)
        {
            Console.Clear();
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Object dizi");
            Thread.Sleep(10000);
        }
    }
}
