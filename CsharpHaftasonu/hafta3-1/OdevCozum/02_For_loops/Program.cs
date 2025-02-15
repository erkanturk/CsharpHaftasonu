namespace _02_For_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Yapı
             for(başlangıç değeri ;koşul;artış azalış)

            */
            //for (; ; )// sonsuz döngü
            //{
            //     Console.WriteLine("i");
            //}
            /*
            1-sayaç tanımlıyor
            2-Koşul kontrolü
            3-Yapılacak işlem kontrolü
            4-sayacı manipule et (artır veya azalt)

            5- koşul kontrolü
            6- yapılacak işlem kontrolü
            7-sayacı manipule et (artır veya azalt)
            */
            // 20 den 0 a doğru sayıları azaltarak git
            //for (int i = 20; i >0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 20; i >0; i-=2)
            //{
            //    Console.WriteLine(i);
            //}

            //200 den başlayarak 3 e tam bölünen sayıları ekrana yazdıran for döngüsünü yazınız.
            //for (int i = 200; i >0;i-- )
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("-----");
            //    Console.WriteLine("{0}'ler çarpımı", i);
            //    Console.WriteLine("-----");
            //    for (int j = 1; j<=10; j++)
            //    {
            //        Console.WriteLine("{0}x{1}={2}", i, j, i*j);
            //    }
            //}
            //for (char karakter = 'a'; karakter <= 'z'; karakter++)
            //{
            //    Console.WriteLine(karakter);//
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    if(i==5|| i==6) 
            //        continue;
            //    if(i==18) break;
            //    Console.WriteLine(i);
            //}

            //paskal üçgeni
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    if (i==1||i==9)
            //    {
            //        Console.WriteLine("********");
            //    }
            //    else
            //    {
            //        Console.WriteLine("*      *");
            //    }
            //}

            //int sayac = 1;
            //int bosluk = 10;
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j < bosluk; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    bosluk--;
            //    for (int k = 0; k <sayac; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    sayac+=2;
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 10; )// sonsuz döngü
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            string alfabe = "!*.-abcdefghijklmnoprstuvzwxyqABCDEFGIJKLMNOPRSTUVYZWQX1234567890";
            Random random = new Random();
            for (int i = 1; i < 15; i++)//Length uzunluk bildirir bir array yada bir değerin uzunluğunu almak istediğimizde length i kullanırız.
            {
                Console.Write(alfabe[random.Next(0,alfabe.Length)]);
            }

        }
    }
}
