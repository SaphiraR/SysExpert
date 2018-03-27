using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysExpTriangle
{
    public interface IFact
    {
        String Nom();
        Object Valeur();
        int Niveaux();
        String Question();

        void SetNiveaux(int p);
    }
}
