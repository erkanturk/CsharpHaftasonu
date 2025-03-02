using System.Collections;

namespace _01_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList 
            Dizilerde veritipi ve eleman sayısı belirtme zorululuğu vardır.
            int[] dizi=new int[boyut]
            ArrayListde ise veritipi zorunluluğu yoktur bir tip belirtmemiz gerekmez her türü  içerisinde barındırır object olarak tutar ve boyut  belirtmemiz gerekmez 2nin katları olarak dizinin boyutu artar daima. 
            Tanımlarken using. System.Collections kütüphanesi gereklidir.

            
            */
            #region Boş Arraylist Tanımlama
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add("3");
            //list.Add('4');
            //list.Add(DateTime.Now);
            //list.Add(25.50);
            //list.Add(true);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Dolu array
            //ArrayList arrayList = new ArrayList() { 20, 50, 30, 40, "test", 'A', true, false };
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);

            //}


            #endregion
            #region Count ve Capasity
            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8,9,10,11,12,13,14,15,16,17 };
            //Console.WriteLine("Toplam kapasitesi:"+arrayList.Capacity);
            //Console.WriteLine("Eleman toplamı:"+arrayList.Count);

            #endregion
           
            #region ArrayList Methods
            ArrayList array = new ArrayList() { 1, 2, 3 };
            ArrayList array2 = new ArrayList() { 15, 25, 35 };
           
            int[] ints = new int[array2.Count];
            array.Add(10);// Tekli ekleme
            array.AddRange(new ArrayList() { 20, 30, 30, 40, 50, 60 });
            array.Insert(10, 20);
            array.InsertRange(5, array2);
            //array.Remove(30);//içinde olan değeri siler.(value ya göre silme)
            //array.RemoveAt(10);//indexe göre silme işlemi yapar
            //array.RemoveRange(3, 5);//index sayısı ve toplam silinecek eleman adeti belirtilir.
            array.Reverse();
            array.Contains(10);//arrayin içinde eleman var mı yok mu kontrol eder ve buna göre true veya false değer dönderir.
          /*  array.Clear();*///tüm elemanları temizler
            array.Sort();//sıralama işlemleri için 
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            ArrayList array3 = (ArrayList)array.Clone();// var olan bir arraylisti başka bir yapıya kopyalama
            foreach (var item in array3)
            {
                Console.WriteLine(item);
            }
            #endregion
            /*
            https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/ 
            https://www.hackerrank.com/skills-verification/c_sharp_basic
            https://roadmap.sh/backend
            //medium araştırmalar için
            
            */
        }
    }
}
