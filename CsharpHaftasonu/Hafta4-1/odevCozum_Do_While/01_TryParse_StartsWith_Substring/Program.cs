namespace _01_TryParse_StartsWith_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Lütfen Bir sayı giriniz ");
            //string sayi = Console.ReadLine();
            //Console.WriteLine("Lütfen İkinci sayıyı giriniz");
            //string sayi2 = Console.ReadLine();



            //Console.WriteLine(sayi2+sayi);

            //int.TryParse(sayi2, out int result);
            //if (int.TryParse(sayi, out int s))
            //{
            //    Console.WriteLine(s+result);
            //}
            //else
            //{
            //    Console.WriteLine(sayi+sayi2);
            //}
            //Console.WriteLine("1-EFT\n2-Havale\nSeçiminiz:");
            //string secim = Console.ReadLine();
            //if (secim=="1")
            //{
            //    Console.WriteLine("Iban bilgisi başında TR olacak şekilde giriniz");
            //    string Iban = Console.ReadLine().ToUpper();
            //    long iban;
            //    if (Iban.StartsWith("TR")&&Iban.Length==14&&long.TryParse(Iban.Substring(2), out iban))
            //    {//İlk değerine bak Bu TR ifadesi geçiyor mu Eğer geçiyor ise  ve Iban değerinin uzunluğu 14 karaktere eşit ise Bu alandaki metinsel ifadeyi rakamsal olarak çevirme işlemine tabi tut ve bu alanda TR ile birlikte aldığım Iban değişkeninin Substring methodu ile ilk 2 karakterini kes Yani değer TR123456789101 kesilmiş hali 123456789101 bu kısım rakamsal değer ise bu yapının türünü dönüştür ve long iban değişkenine aktar.
            //        Console.WriteLine("Eft Miktar Girişi:");
            //        int miktar = Convert.ToInt32(Console.ReadLine());
            //        Console.Clear();

            //        Console.WriteLine(miktar+2000);
            //        Console.WriteLine(iban);
            //        Console.WriteLine(Iban);


            //    }
            //    else
            //    {
            //        Console.WriteLine("İban bilgisi hatalı");
            //    }
            //}

            #region string Fonksiyonlar(Methodlar)
            //string metin = "    Erkan TürkE     ";
            //Console.WriteLine(metin);
            //Console.WriteLine(metin.Trim(' ','E'));//Sağdan soldan tüm boşlukları temizler
            //Console.WriteLine(metin.TrimEnd(' '));//Sonda verdiğim ifadeleri temizler
            //Console.WriteLine(metin.TrimStart(' '));
            //Console.WriteLine(metin.TrimStart(' ', 'E'));//Başta belirtiğim ifadeleri temizler
            //string[] array = new string[] {"Merhaba","Dünya","Hello","World" };
            string metin = "Bu İstanbul Yaşanmaz Oldu";
            Console.WriteLine(metin.Substring(3));//Verdiğim index değerine göre siler.
            Console.WriteLine(metin.Substring(3, 8));//Başlangıç değeri ve Kalmasını istediğim karakterleri veriyorum sonrasınıda sil diyoruz.
            Console.WriteLine(metin.IndexOf('a'));
            Console.WriteLine(metin.LastIndexOf('a'));
            Console.WriteLine(metin.IndexOf('a', 7));//aranacak değer ve bakmaya başlayacağı index değerini belirtmemiz gerekiyor.
            Console.WriteLine(metin.Replace("Bu", "Aslında"));//Bu değerini aslında olarak güncelle dedik.
            Console.WriteLine(metin.Remove(3));//girdiğim index kalsın geri kalanını sil
            //Array.Sort(array);
            //Console.WriteLine(array);
            #endregion

        }
    }
}
