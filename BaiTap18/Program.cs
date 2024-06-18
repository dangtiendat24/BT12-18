using System.Text;

namespace BaiTap18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            long x = readLongFromCosole();
            long y = (long)Math.Sqrt(x);
            Console.WriteLine("Căn bậc 2 của số bạn đã nhập là: " + y);
        }
        static long readLongFromCosole()
        {
            long result;
            while (true)
            {
                Console.Write("Nhập vào số thực 8byte: ");
                string input = Console.ReadLine();
                if (long.TryParse(input, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Số bạn nhập không hợp lệ. Nhập lại");
                }
            }
            return result;
        }
    }
}
