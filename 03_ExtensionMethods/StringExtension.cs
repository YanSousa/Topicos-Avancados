using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExtensionMethods
{
    public static class StringExtension
    {
        public static string FirsToUpper(this String str )
        {
           string Primeira = str.Substring(0, 1);

            string Segunda = str.Substring(1);

            return Primeira.ToUpper() + Segunda;

        }

    }
}
