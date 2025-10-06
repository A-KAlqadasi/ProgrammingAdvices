using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ScreenResolution
{

    internal class Program
    {
        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(int nIndex);
        static void Main(string[] args)
        {
            int screenWidth = GetSystemMetrics(0);
            int screenHeight = GetSystemMetrics(1);
            Console.WriteLine($"Screen resolution: {screenWidth}X{screenHeight}");
            Console.ReadKey();
        }
    }
}
