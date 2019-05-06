using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramadorLibertario
{
    class MamaeFalei
    {
        public bool VamosQuestionarTudo(PersonType person)
        {
            if (person == PersonType.Ancap)
                return false;

            return true;
        }
    }

    public enum PersonType
    {
        EsquerdistaSafado,
        Ancap
    }
}
