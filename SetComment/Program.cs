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
            //var root = new DirectoryInfo(@"Z:\Sources\Lunor\Repos\palmtreemath\SetComment\Sample");
            foreach (var file in root.EnumerateFiles("*", SearchOption.AllDirectories)
                                 .Where(file => target_file_type_pattern.IsMatch(file.Name)))
            {
                var text = File.ReadAllText(file.FullName);
                var new_text = comment_file_name_pattern.Replace(text, file.Name);
                File.WriteAllText(file.FullName, new_text);
            }
        }
    }
}
