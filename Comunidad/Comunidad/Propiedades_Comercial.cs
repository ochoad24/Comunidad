using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Propiedades_Comercial:Propiedades
    {
        private string nombre_comercial;
        private string actividad;

        public string Nombre_comercial
        {
            get
            {
                return nombre_comercial;
            }

            set
            {
                nombre_comercial = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}
