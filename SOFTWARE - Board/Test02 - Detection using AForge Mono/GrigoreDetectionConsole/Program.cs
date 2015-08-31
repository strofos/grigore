using System;
using System.IO;
using System.Threading;

namespace GrigoreDetectionConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            foreach (string arg in args) {
                // enter debug mode
                if (arg.StartsWith("d"))
                {
                    RunDebugMode(arg);
                    return;
                }
            }

            Detection d = new Detection();
            d.Run();

            Camera c = new Camera();
            c.Run();

            Console.ReadKey();
        }


        static int X;
        static int Y;
        static int XDestination;
        static int YDestination;

        static void RunDebugMode(string args) {
            if (args == "d")
                RunRandomDebugMode();
            else
                RunFileDebugMode(args.Substring(2));
        }

        static void RunRandomDebugMode() {
            Random rnd = new Random();
            X = rnd.Next(600);
            Y = rnd.Next(400);
            XDestination = rnd.Next(600);
            YDestination = rnd.Next(400);

            while (true)
            {
                if (Math.Abs(X - XDestination) < 2) 
                {
                    XDestination = rnd.Next();
                }
                
                if (Math.Abs(Y - YDestination) < 2)
                {
                    YDestination = rnd.Next();
                }

                X += (XDestination - X) / 2;
                Y += (YDestination - Y) / 2;

                Console.WriteLine(string.Format("P;{0};{1};", X, Y));
                Console.WriteLine(string.Format("B;{0}x{1};{2}x{1};{2}x{3};{0}x{3};", new object[] { 0, 0, 600, 400 }));
                Thread.Sleep(1000);
            }
        }

        static void RunFileDebugMode(string filepath) {
            if (!File.Exists(filepath))
            {
                RunRandomDebugMode();
            }
            else {
                foreach (string debugLine in File.ReadAllLines(filepath)) {
                    Console.WriteLine(debugLine);
                    Thread.Sleep(1000);
                }

                RunFileDebugMode(filepath);
            }
        }

    }
}
