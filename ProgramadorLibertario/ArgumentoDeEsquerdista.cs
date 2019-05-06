using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramadorLibertario
{
    class ArgumentoDeEsquerdista
    {
        public static string Argumento { get; set; }

        public static EsquerdistaType OEsquerdista { get; set; }

        //static void Main(string[] args)
        //{
        //    switch (OEsquerdista)
        //    {
        //        case EsquerdistaType.Marxista:
        //            Argumento = "O Empresário rouba o teu trabalho";
        //            break;
        //        case EsquerdistaType.Estatista:
        //            Argumento = "Regulação é para proteger a sociedade";
        //            break;
        //        case EsquerdistaType.EstudanteDaFederal:
        //            Argumento = "Facista, vai estudar!";
        //            break;
        //        case EsquerdistaType.TabacudoDoYouTube:
        //            Argumento = "Saiu na carta capital";
        //            break;
        //        case EsquerdistaType.FuncionarioPublico:
        //            Argumento = "O PSOL falou que é assim";
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }

    public enum EsquerdistaType
    {
        Marxista,
        Estatista,
        EstudanteDaFederal,
        TabacudoDoYouTube,
        FuncionarioPublico
    }
}
