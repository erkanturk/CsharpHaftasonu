namespace _01_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Arrays-Diziler
            *Değişkenlerin aksine diziler Index adı verilen bir numaralandırma yöntemi ile birden fazla değer tutabilen koleksiyon tipidir.
                Index numaraları 0 dan başlar ve 1 er 1 er artar.
                Arrays kendilerine ait methodlara sahiplerdir
                Array[] ile tamımlanır.
                Tek bir veri tipinde verilen uzunluk kadar eleman tutar.

            veriTipi[] degiskenAdi= new veriTipi[uzunluk];
            
            */
            //string[] sehirler = { "Adana", "Ankara", "Yozgat", "Zonguldak", "Amasya", "Sivas" };
            //for (int i = 0; i < sehirler.Length; i++)//for ile yazımı
            //{
            //    Console.WriteLine(sehirler[i]);
            //}
            //Console.WriteLine("********");
            //Console.WriteLine(sehirler[0]);
            //Console.WriteLine(sehirler[1]);
            //Console.WriteLine(sehirler[2]);//Dögüler olmasaydı bu şekilde yazdırırdık.

            //do while ile yazımı

            //int i = 0;
            //do 
            //{
            //    Console.WriteLine(sehirler[i]);
            //    i++;
            //}
            //while (i<sehirler.Length);
            //while (i<sehirler.Length)
            //{
            //    Console.WriteLine(sehirler[i]);
            //    i++;
            //}
            string[] sehirler = { "Adana", "Ankara", "Yozgat", "Zonguldak", "Amasya", "Sivas" };//dolu array
            //foreach (string sehir in sehirler)//foreach yazım biçimi
            //{
            //    Console.WriteLine(sehir);
            //}

            //int[] sayi = new int[5];//Index değeri değil eleman sayınını kaç eleman alacağını belirtiriz.
            //sayi[0]=11;
            //sayi[1]=12;
            //sayi[3]=13;
            //sayi[2]=14;          
            //sayi[4]=16;
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    Console.WriteLine(sayi[i]);
            //}

            //Console.WriteLine("Array kaç elemanlı olsun");
            //int sayi = Convert.ToInt32(Console.ReadLine());


            //int[] sayilar = new int[sayi];
            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine("Girmek istediğiniz sayı");
            //    sayilar[i]=Convert.ToInt32(Console.ReadLine());

            //}
            Console.WriteLine();
            //Array.Sort(sehirler);//Sıralama işlemi
            //Array.Reverse(sehirler);//tersine çevir
            string[] metin = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ" };
            Array.Sort(metin);
            foreach (string sayi1 in metin)
            {
                Console.WriteLine(sayi1);
            }

        }
    }
}
