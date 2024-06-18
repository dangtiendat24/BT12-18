using System.Text;

namespace BaiTap17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào một xâu ký tự: ");
            string st = Console.ReadLine();

            if (st == null)
            {
                Console.Beep();
            }else
            {
                int wordCount = countWord(st);
                Console.WriteLine($"Số từ trong chuỗi {st} là: {wordCount}");
            }
        }
        static int countWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return 0;
            }
            char[] delimiters = new char[] { ' ', '\r', '\n', '\t', '.', ',', ';', ':', '!', '?', '-', '_' };
            string[] words = word.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }
    }
}
