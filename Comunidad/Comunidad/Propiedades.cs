using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Propiedades
    {
        protected string tipo;
        protected string codigo_propiedad;
        protected int metros_cuadrados;
        protected string codigo_propietario;
        protected List<string> lista_gastos;

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Codigo_propiedad
        {
            get
            {
                return codigo_propiedad;
            }

            set
            {
                codigo_propiedad = value;
            }
        }

        public int Metros_cuadrados
        {
            get
            {
                return metros_cuadrados;
            }

            set
            {
                metros_cuadrados = value;
            }
        }

        public string Codigo_propietario
        {
            get
            {
                return codigo_propietario;
            }

            set
            {
                codigo_propietario = value;
            }
        }

        public List<string> Lista_gastos
        {
            get
            {
                return lista_gastos;
            }

            set
            {
                lista_gastos=value;
            }
        }
    }
}
