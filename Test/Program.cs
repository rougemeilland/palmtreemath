using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Render(0, 64);
            Console.WriteLine("Ok.");
            Console.ReadLine();
        }

        static void Render(int start, int len)
        {
            if (len < 2)
                throw new ApplicationException();
            Console.WriteLine(string.Format("// [{0}-{1}]", start, start + len - 1));
            if (len == 2)
            {
                Console.WriteLine(string.Format("return (value != {0});", CreateMask(start, len)));
            }
            else
            {
                var low_start = start;
                var low_len = len / 2;
                var low_mask = CreateMask(low_start, low_len);
                var high_start = start + len / 2;
                var high_len = len / 2;
                var high_mask = CreateMask(high_start, high_len);
                Console.WriteLine(string.Format("if (!(value & {0}))", high_mask));
                Console.WriteLine("{");
                Render(low_start, low_len);
                Console.WriteLine("}");
                Console.WriteLine(string.Format("else if (value & {0})", low_mask));
                Console.WriteLine("return (FALSE);");
                Console.WriteLine("else");
                Console.WriteLine("{");
                Render(high_start, high_len);
                Console.WriteLine("}");
            }
        }

        static string CreateMask(int start, int len)
        {
            var mask_value=((1UL << len) - 1) << start;
            if (mask_value <= uint.MaxValue)
                return (string.Format("0x{0:x}U", mask_value));
            else
                return (string.Format("0x{0:x}UL", mask_value));
        }
    }
}
