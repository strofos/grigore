using System;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace GrigoreDetectionConsole
{
    public class Camera
    {
        private string dirPath;
        private Process raspistillProcess;
        private Size imageSize;

        public Camera() {
            // 5MP
            imageSize = new Size(2592, 1944);
        }

        public void Run()
        {
            dirPath = Environment.CurrentDirectory + "/Images/";
            if (!Directory.Exists(dirPath))
                dirPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Images/";

            
            DateTime startTime = DateTime.Now;
            Console.WriteLine(string.Format("Get image from camera: {0}", startTime));

            // find the raspistill process
            foreach (Process p in Process.GetProcessesByName("raspistill"))
                raspistillProcess = p;

            // start the process
            if (raspistillProcess == null)
            { 
                string shellExecCmd = "raspistill";
                string shellExecParams = "-t 0 -s -o camera_pic.jpg";
                //string shellExecParams = "-t 0 -s -o camera_pic.jpg &";
                //string shellExecParams = "-n -t 0 -h " + imageSize.Height 
                //    + " -w " + imageSize.Width + " -q 100 -o " + dirPath + "camera-pic.jpg";

                Console.WriteLine(string.Format("Starting process: {0} {1}", shellExecCmd, shellExecParams));

                raspistillProcess = Process.Start(
                    new ProcessStartInfo(shellExecCmd, shellExecParams) { 
                        RedirectStandardError = false,
                        UseShellExecute = true 
                    }
                );

                raspistillProcess.InitializeLifetimeService();

                // add some thread sleep to allow the process to be created
                System.Threading.Thread.Sleep(300);
            }

            

            // send process command to take the image
            Console.WriteLine(string.Format("Send process command: kill -SIGUSR1 {0}", raspistillProcess.Id));
            Process.Start(
                new ProcessStartInfo("kill", string.Format("{0} {1}", "-SIGUSR1 ", raspistillProcess.Id))
            );

            Console.WriteLine(string.Format("Duration: {0} sec", (DateTime.Now - startTime)));
        }
    }
}
