using Casinoo;

internal class Program
{
    private static void Main(string[] args)
    {
        //Standart.Print("Hello", 15, 6);
        // Standart.HLine("-", 3, 3, 15);
        //Standart.VLine("-", 3, 3, 15);
        //Standart.Rectange(2, 2, 10, 7);
        UserIntface.Screen();
        UserIntface.Game();
        Console.ReadKey(); //чтобы не завершал прогу, покка мы не нажмем клавишу
    }
}