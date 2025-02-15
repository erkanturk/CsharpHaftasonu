namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Operators
            = => Eşittir sağdaki değeri soldaki değişkene aktarma işlemi yapar
            += => Artırma operatörü
            -= => Azaltma operatörü
            *= => çarpma operatörü
            /= =Bölme operatörü
            ++ => 1 artırma
            -- => 1 azaltma
            % => mod alma bir sayının bölümünden kalan yani 10 %3 kalan 1 dir.
            // Karşılaştırma operatörleri
            Bu karşılaştırma operatörleri sonuç olarak bize true veya false olarak döner
            == => eşit mi ? eşit ise true değil ise false 
            != => eşit değil mi ? Eşit değil ise true eşit ise false
            < => küçüktür
            > => büyüktür
            <= => küçük eşittir
            >= büyük eşittir

            //Mantıksal operatörler 
            && =>(ve) and bu operatörü çarpma işlemine benzetebiliriz. true 1 false 0 
            || => (veya) or bu operatörü toplama işlemine benzetebiliriz.



                    &&
            Değer Başlangıç Sonuc
              1      0        0
              0      1        0
              0      0        0
              1      1        1


                     ||
            Değer Başlangıç Sonuc
             1       0        1
             0       1        1
             0       0        0
             1       1        1


            */

            //int sayi = 10;// atama
            //sayi+=1;//artırma işlemi
            //sayi-=1;
            //sayi*=2;
            //sayi/=2;
            //sayi++;//1 artırma
            //sayi--;//1 azaltma



            //Console.WriteLine(sayi);

            //string metin = "Erkan";
            //string m = "erkan";
            //bool karsilastir = m==metin;//eşitlik durumunda true döner değil ise false
            //bool karsilastir2 = m!=metin;//eşit olmama durumunda true döner olma durumunda ise false
            //Console.WriteLine(karsilastir+" "+karsilastir2);//string yazdırma biçimi

            //int sayi = 10;

            //bool k = sayi>20 && sayi<30;//false
            //bool k1 = sayi>=10 && sayi<30;//true
            //bool k2 = sayi<30 && sayi>9;//true
            //bool k3 = sayi<=9 && sayi<=10;//false


            //bool k = sayi>20 || sayi<30;//true
            //bool k1 = sayi>=10 || sayi<30;//true
            //bool k2 = sayi<30 || sayi>9;//true
            //bool k3 = sayi<=9 || sayi<=10;//true
            //bool k4 = sayi<=9 || sayi>=50;//false // sadece 2 koşulda false ise false döner.
            //Console.WriteLine(k);
            //Console.WriteLine(k1);
            //Console.WriteLine(k2);
            //Console.WriteLine(k3);
            //Console.WriteLine(k4);

            double sayi = 10;
            double sayi2 = 3;
            double karsilastir = sayi%sayi2;// mod alma işlemi bir sayının bölümünden kalan değerdir.
            Console.WriteLine(karsilastir);
            double bolme = sayi/sayi2;
            Console.WriteLine(bolme);



        }
    }
}
