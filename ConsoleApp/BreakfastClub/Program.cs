using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO.Ports;
using System.Threading;

namespace BreakfastClub
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Media.SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "c:\\breakfast.wav";
            player.Load();
            player.Play();

            Console.WriteLine("...what we found out is that each one of us is a brain...");
            Thread.Sleep(3000);
            Console.WriteLine("...and an athlete...");
            Thread.Sleep(2100);
            Console.WriteLine("...and a basket case...");
            Thread.Sleep(2100);
            Console.WriteLine("...a princess...");
            Thread.Sleep(2100);
            Console.WriteLine("...and a criminal...");
            Thread.Sleep(2100);
            Console.WriteLine("Does that answer your question?");
            Thread.Sleep(2100);
            using (SerialPort serialPort1 = new SerialPort())
            {
                serialPort1.PortName = "COM5"; //set the port name you see in arduino IDE
                serialPort1.BaudRate = 9600;   //set the Baud you see in arduino IDE

                serialPort1.Open();

                Thread.Sleep(300);
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine("a");
                    serialPort1.Close();
                }
            }
            Console.WriteLine(" Sincerely yours, the Breakfast Club.");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}