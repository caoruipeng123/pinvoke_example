using System.Runtime.InteropServices;

namespace PInvoke
{
    internal class Program
    {
        [DllImport("PInvokeDLL.dll")]
        public static extern int Add(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
