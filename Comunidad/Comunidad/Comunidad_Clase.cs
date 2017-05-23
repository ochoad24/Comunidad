using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Comunidad_Clase
    {
        private int identificación;
        private string nombre;
        private string poblacion;

        public int Identificación
        {
            get
            {
                return identificación;
            }

            set
            {
                identificación = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Poblacion
        {
            get
            {
                return poblacion;
            }

            set
            {
                poblacion = value;
            }
        }
    }
}
