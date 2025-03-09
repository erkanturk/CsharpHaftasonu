using System.Collections;

namespace _03_Etut_Dongu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            int sayi2 = 0;
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            ArrayList arrayList = new ArrayList();
            //for (int i = 0; i < sayi; i++)
            //{
            //    arrayList.Add(i);
            //}
            int index = 0;
            while (sayi>0)
            {
                arrayList.Add(index);
                index++;
                sayi--;
            }
            foreach (int sayilar in arrayList)
            {
                if (sayilar%2==0)
                {
                    sayi1+=sayilar;
                }
                else
                {
                    sayi2+=sayilar;
                }

            }
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine("Tekler: Toplamı: "+sayi2);
            Console.WriteLine("Çiftler: Toplamı: "+sayi1);

        }
    }
}
