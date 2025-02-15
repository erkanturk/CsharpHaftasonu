namespace _01_Math_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Pi Sayısı {Math.PI}");
            Console.WriteLine($"Karekökü alma: {Math.Sqrt(25)}");
            Console.WriteLine($"Kuvvetini alma: {Math.Pow(2,3)}");
            Console.WriteLine($"Mutlak değer alma: {Math.Abs(-30)}");
            Console.WriteLine($"Max değeri bulma: {Math.Max(20,50)}");
            Console.WriteLine($"Min değer bulma: {Math.Min(20,50)}");
            Console.WriteLine($"Tam yuvarlama: {Math.Round(3.49)}");
            Console.WriteLine($"Yukarı yuvarlama: {Math.Ceiling(3.01)}");
            Console.WriteLine($"Aşağı yuvarlama: {Math.Floor(3.99)}");
           
        }
    }
}
