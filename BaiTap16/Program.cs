using System.Text;

namespace BaiTap16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập và kiểm tra giá trị cho m và n
            byte m = ReadByteInRange("Nhập giá trị cho m (2 đến 10): ", 2, 10);
            byte n = ReadByteInRange("Nhập giá trị cho n (2 đến 10): ", 2, 10);

            Console.WriteLine($"Giá trị m bạn đã nhập là: {m}");
            Console.WriteLine($"Giá trị n bạn đã nhập là: {n}");

            // Khai báo và cấp phát mảng 2 chiều a
            int[,] a = new int[m, n];

            // Nhập giá trị cho mảng a
            ReadIntArray2DFromConsole(a);

            // In ra màn hình giá trị của mảng a
            Console.WriteLine("Các phần tử của mảng a:");
            PrintIntArray2D(a);

            // Tính tổng các phần tử chia hết cho 2024
            int sumDivisibleBy2024 = SumDivisibleBy(a, 2024);
            Console.WriteLine($"Tổng các phần tử của mảng a chia hết cho 2024 là: {sumDivisibleBy2024}");
        }
        static byte ReadByteInRange(string message, byte min, byte max)
        {
            byte result;
            bool isValidInput = false;

            do
            {
                Console.Write(message);
                isValidInput = byte.TryParse(Console.ReadLine(), out result);
                if (isValidInput && (result < min || result > max))
                {
                    isValidInput = false;
                    Console.WriteLine($"Giá trị nhập vào phải nằm trong khoảng từ {min} đến {max}. Nhập lại!");
                }
                else if (!isValidInput)
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Nhập lại!");
                }
            } while (!isValidInput);

            return result;
        }

        // Hàm đọc số nguyên 4 byte từ bàn phím
        static int ReadInt32FromConsole(string message)
        {
            int result;
            bool isValidInput = false;

            do
            {
                Console.Write(message);
                isValidInput = int.TryParse(Console.ReadLine(), out result);
                if (!isValidInput)
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Nhập lại!");
                }
            } while (!isValidInput);

            return result;
        }

        // Hàm nhập mảng 2 chiều số nguyên từ bàn phím
        static void ReadIntArray2DFromConsole(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = ReadInt32FromConsole($"Nhập giá trị cho phần tử [{i}, {j}]: ");
                }
            }
        }

        // Hàm tính tổng các phần tử của mảng 2 chiều chia hết cho p
        static int SumDivisibleBy(int[,] array, int p)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % p == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }

            return sum;
        }

        // Hàm in mảng 2 chiều số nguyên ra màn hình
        static void PrintIntArray2D(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
