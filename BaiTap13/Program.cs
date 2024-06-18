using System.Text;

namespace BaiTap13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            byte n = readByteFromCosole();
            Console.WriteLine($"Bạn đã nhập số : {n}");

        }
        static byte readByteFromCosole()
        {
            byte result;
            while(true)
            {
                Console.Write("Nhập số nguyên không dấu 1 byte nằm trong khoảng từ 2 đến 10: ");
                string input = Console.ReadLine();
                if(byte.TryParse(input, out result) && result >= 2 && result <= 10)
                {
                    break;
                }else
                {
                    Console.WriteLine("Số nhập sai. Nhập lại");
                }
            }
            return result;
        }
    }
}
