namespace _08_Random_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            basla://etiket istediğimiz değeri veririz goto keywordu bu alana gelmemizi sağlar üst alan : iki nokta goto ise noktalı virgül ile tanımlanır ;
            int sansliSayi = random.Next(1, 11);
            Console.WriteLine("Şanslı sayınızı giriniz");
            int tahmin=Convert.ToInt32(Console.ReadLine());
            if (sansliSayi == tahmin)
            {
                Console.WriteLine("Tebrikler Şanslısınız");
            }
            else
            {
                Console.WriteLine("Lütfen Tekrar deneyin {0}", sansliSayi);
                goto basla;//bir döngü değildir döngü gibi çalışır kodumuzu tekrar tekrar çalıştırır fakat satıra konuşlandığı için program bu alanda kısılı kalır devam etmez.


            }
            // yararlı kaynak:https://www.w3schools.com/
        }
    }
}
