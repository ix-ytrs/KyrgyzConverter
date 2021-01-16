using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrgyz_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = null;
            if (!args.Any())
            {
                Console.WriteLine("ファイルパスを入力");
                Console.Write(">");
                fileName = Console.ReadLine();
            }
            else
            {
                fileName = args[0];
            }
            StreamReader sr = new StreamReader(fileName);

            string str = sr.ReadToEnd();

            sr.Close();

            StringBuilder sb = new StringBuilder(str);

            sb.Replace("يۋ", "ю");
            sb.Replace("يا", "я");
            sb.Replace("ۅ", "ө");
            sb.Replace("ۉ", "ү");
            sb.Replace("ا", "а");
            sb.Replace("ب", "б");
            sb.Replace("ۋ", "в");
            sb.Replace("گ", "г");
            sb.Replace("ع", "г");
            sb.Replace("د", "д");
            sb.Replace("ە", "е");
            sb.Replace("يو", "ё");
            sb.Replace("ج", "ж");
            sb.Replace("ز", "з");
            sb.Replace("ى", "ы");
            sb.Replace("ئ", "и");
            sb.Replace("ي", "й");
            sb.Replace("ك", "к");
            sb.Replace("ق", "к");
            sb.Replace("ل", "л");
            sb.Replace("م", "м");
            sb.Replace("ڭ", "ң");
            sb.Replace("ن", "н");
            sb.Replace("و", "о");
            sb.Replace("پ", "п");
            sb.Replace("ر", "р");
            sb.Replace("س", "с");
            sb.Replace("ت", "т");
            sb.Replace("ۇ", "у");
            sb.Replace("ف", "ф");
            sb.Replace("ح", "х");
            sb.Replace("تس", "ц");
            sb.Replace("چ", "ч");
            sb.Replace("ش", "ш");
            sb.Replace("ە", "э");

            string str2 = sb.ToString();

            Console.WriteLine(str2);

            File.WriteAllText(@".\result.txt", str2);

            Console.ReadKey();
        }
    }
}
