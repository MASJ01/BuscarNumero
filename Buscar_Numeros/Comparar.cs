using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscar_Numeros
{
    class Comparar
    {
        public int comparar_num(int Numero_Usuario, int Numero_PC) //Este es un metodo despues hay un parametro
        {
            if (Numero_Usuario == Numero_PC)
            {
                return 0;
            }
            else
            {
                if (Numero_Usuario < Numero_PC)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
