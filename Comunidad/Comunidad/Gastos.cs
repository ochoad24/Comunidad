using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Gastos
    {
        private string identificación;
        private string nombre;
        private string tipo_de_reparto;

        public string Identificación
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

        public string Tipo_de_reparto
        {
            get
            {
                return tipo_de_reparto;
            }

            set
            {
                tipo_de_reparto = value;
            }
        }
    }
}
