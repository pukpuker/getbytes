using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        private static bool item;

        static void Main(string[] args)
        {


            byte[] bb = File.ReadAllBytes(@"C:\Users\swordily\Desktop\neverlose\server\Debug\servv.exe");
            string ss = get(bb);
            File.WriteAllText("ss.txt", ss);


        }
        public static string get(byte[] vv)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in vv)
            {
                sb.Append(item);
                sb.Append(",");
            }
            return sb.ToString().Remove(sb.Length - 1);
        }
    }
}
