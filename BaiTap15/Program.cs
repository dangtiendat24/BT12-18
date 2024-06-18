using System.Text;

namespace BaiTap15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            byte x = ReadByteFromCosole();
            Console.WriteLine("Số bạn nhập là: " + x);

            float[] a = new float[x];
            readFloatArrayFromCosole(a);

            Console.WriteLine("Các phần tử của mảng là: ");
            foreach (var item  in a)
            {
                Console.WriteLine(item);
            } 
        }
        static byte ReadByteFromCosole()
        {
            byte result;
            while (true)
            {
                Console.Write("Nhập vào số nguyên 1 byte không dấu từ 2 đến 10: ");
                string input = Console.ReadLine();
                if(byte.TryParse(input, out result) && result >= 2 && result <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhập sai. Nhập lại");
                }
            }
            return result;
        }
        static float readFloatFromConsole()
        {
            float result;
            while (true)
            {
                Console.Write("Nhập số thực 4 byte: ");
                string input = Console.ReadLine();
                if (float.TryParse(input, out result))
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
        static void readFloatArrayFromCosole(float[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = readFloatFromConsole();
            }
        }
    }
}
