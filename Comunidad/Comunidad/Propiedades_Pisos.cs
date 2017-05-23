using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Propiedades_Pisos
    {
        private string vivienda;
        private int numero_dormitorios;

        public string Vivienda
        {
            get
            {
                return vivienda;
            }

            set
            {
                vivienda = value;
            }
        }

        public int Numero_dormitorios
        {
            get
            {
                return numero_dormitorios;
            }

            set
            {
                numero_dormitorios = value;
            }
        }
    }
}
