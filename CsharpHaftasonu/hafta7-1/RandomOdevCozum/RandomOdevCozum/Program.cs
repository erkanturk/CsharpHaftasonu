namespace RandomOdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çiftleri ayrı ayrı dizilere atayan metot 
            int[] sayilar = new int[15];

            int tekBoyut = 0;
            int ciftBoyut = 0;
            DiziDoldur(sayilar, ref tekBoyut, ref ciftBoyut);
            int[] tekSayilar = new int[tekBoyut];
            int[] ciftSayilar = new int[ciftBoyut];
            TekCift(sayilar, ref tekSayilar, ref ciftSayilar);
            DiziYazdır(sayilar); Console.WriteLine("##########Sayilar###########");
            DiziYazdır(tekSayilar); Console.WriteLine("**********Tekler***********");
            DiziYazdır(ciftSayilar); Console.WriteLine("xxxxxxxxxÇiftlerxxxxxxxxxxx");

        }
        static void DiziDoldur(int[] array, ref int tekBoyut, ref int ciftBoyut)
        {
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                int sayi = random.Next(1, 100);
                array[i]=sayi;
                if (sayi%2==0) ciftBoyut++;
                else tekBoyut++;
            }
        }
        static void TekCift(int[] array, ref int[] tekSayilar, ref int[] ciftSayilar)
        {
            foreach (int i in array)
            {
                if (i %2==0)
                {
                    int x = Array.IndexOf(ciftSayilar, 0);
                    ciftSayilar[x]=i;
                }
                else
                {
                    int x = Array.IndexOf(tekSayilar, 0);
                    tekSayilar[x]=i;
                }

            }
        }
        static void DiziYazdır(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
