using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SetComment
{
    class Program
    {
        static void Main(string[] args)
        {
            var target_file_type_pattern = new Regex(@"\.(cs|c|cpp|h)$", RegexOptions.Compiled);
            var comment_file_name_pattern = new Regex(@"\$\$filename\$\$", RegexOptions.Compiled);
            var root = new DirectoryInfo(@"Z:\Sources\Lunor");
            var shift_jis_encoding = Encoding.GetEncoding("Shift_JIS", new EncoderExceptionFallback(), new DecoderExceptionFallback());
            var utf8_encoding = new UTF8Encoding(true, true);
            foreach (var file in root.EnumerateFiles("*", SearchOption.AllDirectories)
                                 .Where(file => target_file_type_pattern.IsMatch(file.Name)))
            {
                var data = File.ReadAllBytes(file.FullName);
                string text;
                try
                {
                    text = shift_jis_encoding.GetString(data);
                }
                catch
                {
                    text = null;
                }
                if (text == null)
                {
                    try
                    {
                        text = utf8_encoding.GetString(data);
                    }
                    catch
                    {
                        text = null;
                    }
                }
                if (text == null)
                    throw new ApplicationException();
                var new_text = comment_file_name_pattern.Replace(text, file.Name);
                File.WriteAllBytes(file.FullName, utf8_encoding.GetBytes(new_text));
            }
            Console.WriteLine("Ok.");
            Console.ReadLine();
        }
    }
}
