using System.Text;

namespace BaiTap12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ushort n = ReadUShortFromConsole();
            Console.WriteLine($"Bạn đã nhập số: {n}");

            long sumOfSquares = CalculateSumOfSquares(n);
            Console.WriteLine($"Tổng bình phương các số từ 1 đến {n} là: {sumOfSquares}");

            // Thực hiện yêu cầu của người dùng bằng switch-case
            while (true)
            {
                Console.WriteLine("LỰA CHỌN");
                Console.WriteLine("a. Nhập lại số nguyên không dấu 2 byte và tính tổng bình phương các số từ 1 đến số đó.");
                Console.WriteLine("b. Thoát chương trình.");
                Console.Write("Nhập lựa chọn của bạn: ");
                char choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 'a':
                        n = ReadUShortFromConsole();
                        Console.WriteLine($"Bạn đã nhập số: {n}");
                        sumOfSquares = CalculateSumOfSquares(n);
                        Console.WriteLine($"Tổng bình phương các số từ 1 đến {n} là: {sumOfSquares}");
                        break;
                    case 'b':
                        Console.WriteLine("Thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }
        public static ushort ReadUShortFromConsole()
        {
            ushort result;
            while (true)
            {
                Console.Write("Nhập một số nguyên không dấu (ushort): ");
                string input = Console.ReadLine();

                if (ushort.TryParse(input, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Định dạng số không hợp lệ hoặc số vượt quá phạm vi cho phép. Vui lòng nhập lại.");
                }
            }
            return result;
        }

        public static long CalculateSumOfSquares(ushort n)
        {
            long sum = 0;
            for (ushort i = 1; i <= n; i++)
            {
                sum += (long)i * i;
            }
            return sum;
        }
    }
}
