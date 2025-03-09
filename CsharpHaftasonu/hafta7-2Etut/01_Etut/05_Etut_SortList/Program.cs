using System.Collections;

namespace _05_Etut_SortList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList()
            {
                {"Ankara",06 },
                {"istanbul",34 },
                {"Bursa",16 },
                {"Rize",53 },
                {"Sivas","58" },
                {"Eskisehir",26 },
                {"Trabzon",61 },
                {"Ordu",52 },
                {"Erzurum",25 },
                {"izmir",35 },
                {"Adana",01 }
            };
            Console.WriteLine("Şehir gir plaka bul");
            string sehir = Console.ReadLine();//Eğer girilen key yok ise ekler

            Console.WriteLine(list[sehir]);
            Console.WriteLine("değer");//olmayan key değerine girilecek value yu sorar.
            list[sehir]=Console.ReadLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }




        }
    }
}
