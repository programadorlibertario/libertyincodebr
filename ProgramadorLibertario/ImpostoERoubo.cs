using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramadorLibertario
{
    class ImpostoERoubo
    {
        public static string Imposto
        {
            get
            {
                return "Consiste em subtrair a propriedade do seu pertencente " +
                    "por meio de violência ou coerção";
            }
        }

        public static string Roubo
        {
            get
            {
                return "Consiste em subtrair a propriedade do seu pertencente " +
                    "por meio de violência ou coerção";
            }
        }

        static void Main(string[] args)
        {
            bool impostoERoubo = Imposto.Equals(Roubo);

            Console.WriteLine(impostoERoubo);
            Console.ReadKey();
        }
    }
}
