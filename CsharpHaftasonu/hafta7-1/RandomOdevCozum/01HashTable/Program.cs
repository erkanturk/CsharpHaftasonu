using System.Collections;

namespace _01HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtable:Key sırasının önemli olmadığı ve hızlı erişim gerektiğinde ideal olarak kullanılan bir yapıdır.
            //Hashtable'ın görevi çok sayıda elemanı key değerleri kullanılarak en hızlı şekilde erişmesidir.
            //Bir key sadece bir defa kullanılır. SortedListeki gibi keylerin aynı olma zorululuğu yoktur.

            Hashtable ht = new Hashtable();
            ht.Add(6, "Ankara");
            ht.Add("Ankara", 6);
            ht.Add("Test", "Deneme");
            ht.Add(10.2, "Sayi");
            ht.Add('A', 'B');
            ht.Add(true, true);
            
            //foreach (var item in ht)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(ht.ContainsValue("Ankara"));
            Console.WriteLine(ht.ContainsKey(6));
            ht.Remove(6);
            ht.Remove("Ankara");
            
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"=>"+item.Value);
            }
        }
    }
}
