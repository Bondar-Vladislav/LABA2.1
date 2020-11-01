using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class Program
    {
        [DllImport(@"C:\Users\3000v\OneDrive\Рабочий стол\Lab2.1\Lib2-1.dll", 
            CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern double TheFunc(string name, double x);

        static void Main(string[] args)
        {
            new Form1().ShowDialog();
        }
    }
}
