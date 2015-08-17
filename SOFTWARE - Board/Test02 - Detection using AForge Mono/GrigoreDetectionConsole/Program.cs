using System;

namespace GrigoreDetectionConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Detection d = new Detection();
            d.Run();

            Camera c = new Camera();
            c.Run();



            Console.ReadKey();
        }


    }
}
