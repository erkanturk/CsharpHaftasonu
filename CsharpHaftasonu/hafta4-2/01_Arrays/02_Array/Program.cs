namespace _02_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Kullanıcının girdiği değeri alt alta yazdıran döngü yü yapınız
            //Console.WriteLine("Kelime:\nGiriniz");
            //string kelime = Console.ReadLine();
            //char[] metin = new char[kelime.Length];
            ////foreach (char item in kelime)
            ////{
            ////    Console.WriteLine(item);
            ////}


            //for (int i = 0; i < kelime.Length; i++)
            //{
            //    Console.WriteLine(kelime[i]);
            //    metin[i]=kelime[i];

            //}

            //foreach (var item in metin)
            //{
            //    Console.WriteLine(item);
            //}
            #region Array Methods
            #region clear
            //string[] metin = { "Hikmet", "Okan", "Tuğberk", "Ömer", "Yavuz", "Umut", "Melek", "Deniz" };
            //Array.Clear(metin);//clear methodu arrayin içindeki değerleri temizler ve boş bir şekilde getirir bizlere.
            //foreach (var item in metin)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region copy
            //string[] adlar = { "Hikmet", "Okan", "Tuğberk", "Ömer", "Yavuz", "Umut", "Melek", "Deniz" };
            //string[] adlar2 = new string[10];
            ////Array.Copy(adlar, adlar2, 3);//sadece 3 elemanını kopyala
            ////Array.Copy(adlar, adlar2, adlar.Length);//adlar dizisinin uzunluğu kadar kopyala.
            ////Array.Copy(adlar,1, adlar2, 2, 3);//1. elemanı alma 2.elemandan başla 3 index uzunluğunda al

            //foreach (var item in adlar2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region IndexOf
            //string[] adlar = { "Hikmet", "Okan", "Tuğberk", "Ömer", "Yavuz", "Umut", "Melek", "Deniz","Hikmet" };

            //int index = Array.IndexOf(adlar, "Hikmet");
            //int index2 = Array.LastIndexOf(adlar, "Hikmet");
            ////Console.WriteLine(adlar[3]);

            //Console.WriteLine(index);
            //Console.WriteLine(index2);

            #endregion
            #region sort
            //string[] adlar = { "Hikmet", "Okan", "Tuğberk", "Ömer", "Yavuz", "Umut", "Melek", "Deniz", "Hikmet" };
            //int[] sayilar = { 10, 22, 30, 4, 5, 60, 7, 8, 9, 100, 21, 12, 13, 14, 15, 1, };
            //Array.Sort(adlar);
            //Array.Sort(sayilar);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region reverse
            //string[] adlar = { "Hikmet", "Okan", "Tuğberk", "Ömer", "Yavuz", "Umut", "Melek", "Deniz", "Hikmet" };
            //int[] sayilar = { 10, 22, 30, 4, 5, 60, 7, 8, 9, 100, 21, 12, 13, 14, 15, 1 };
            //Array.Reverse(adlar);//tersine çevirme işlemi yapar.
            //Array.Reverse(sayilar);//tersine çevirme işlemi yapar.
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region resize
            int[] sayilar = new int[5];
            sayilar[0]= 1;
            sayilar[1]= 2;
            sayilar[2]= 3;
            sayilar[3]= 4;
            sayilar[4]= 5;

            Array.Resize(ref sayilar, 8);
            sayilar[5]=6;
            sayilar[6]=7;
            sayilar[7]=8;
            Array.Resize(ref sayilar,sayilar.Length-3);
            Array.Resize(ref sayilar,sayilar.Length+3);

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            
            #endregion
            #endregion
        }
    }
}
