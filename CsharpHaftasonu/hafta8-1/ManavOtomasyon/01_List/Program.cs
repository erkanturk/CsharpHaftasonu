namespace _01_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Listler kolleksiyon yapısıdır en sık kullanılan yapıdır arraylistden farklı olarak bir tip güvenliği olmasıdır.
            //List yapısının sınırı yoktur 2 nin katı olarak eklediğimiz elemanın sınırı daima artar.
            //Listler FİFO mantığı ile çalışır.
            List<string> list = new List<string>(); //<T> generic yapı olarak geçiyor bu alanda bir değer belirtmeliyiz.Bu yapı string bir liste barındıracağını belirtir.
            list.Add("Erkan");//Tekli ekleme
            list.Add("Hikmet");
            list.Add("Yavuz");
            list.Add("Ömer");
            list.Add("Melek");
            list.Add("Umut");
            list.AddRange(new List<string> { "Deniz", "Tuğberk" });//Çoklu ekleme
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            List<int> notlar = new List<int>();
            notlar.Add(1);
            notlar.Add(2);
            notlar.Add(3);
            foreach (var item in notlar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Capacity: {notlar.Capacity}");
            Console.WriteLine($"count: {notlar.Count}");
            Console.WriteLine("*****************");
            list.ForEach(x => Console.WriteLine(x));//x=>x lamda 
        }
    }
}
