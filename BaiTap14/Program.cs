using System.Text;

namespace BaiTap14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float x = readFloatFromConsole();
            Console.WriteLine("Số bạn đã nhập là: " + x);
        }
        static float readFloatFromConsole()
        {
            float result;
            while (true)
            {
                Console.Write("Nhập số thực 4 byte: ");
                string input = Console.ReadLine();
                if(float.TryParse(input, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Số nhập sai. Vui lòng nhập lại");
                }
            }
            return result;
        }
    }
}
