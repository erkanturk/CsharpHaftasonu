using System.Collections;

namespace _01_SortList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortList<Key,Value> ilişkisi ile tutulur Key tarafı string olarak verildiyse devamında başka tip olamaz aynı tip devam etmelidir.using System.Collections; tarafını kullanmalıyız.
            SortedList sozluk = new SortedList()
            {   //key    //value
               
                {"Yarın","Tommorrow" },
                {"Bugun","Today" },
                {"Hava","Wheather"},
                {"Gokyuzu","Sky" },
                {"Karli","Snowy" },
                {"Gunesli","Sunny" },
                {"Bulutlu","Cloudy" },
                {"Acık","Clear" },
                {"Kapali","Close" },
                {"Bir",1 },
                {"Iki",2 }
                //{3,"T" }//Hata verir  key tipleri aynı olmalıdır.

            };

            //Key verip Value alma
            //Console.WriteLine(sozluk["Karli"]);

            //foreach (var item in sozluk)
            //{
            //    Console.WriteLine(item.);// tüm değerleri getirme yöntemi key value 
            //}

            foreach (DictionaryEntry item in sozluk)//DictionaryEntry kütüphanesini dahil edip buradaki değerlerin sadece key veya value sunu al diyebiliriz.
            {
                Console.WriteLine(item.Value);
            }
            foreach (DictionaryEntry item in sozluk)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
