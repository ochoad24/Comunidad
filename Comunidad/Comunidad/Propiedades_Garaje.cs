using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Propiedades_Garaje
    {
        private string estado_garaje;
        private string bodega;

        public string Estado_garaje
        {
            get
            {
                return estado_garaje;
            }

            set
            {
                estado_garaje = value;
            }
        }

        public string Bodega
        {
            get
            {
                return bodega;
            }

            set
            {
                bodega = value;
            }
        }
    }
}
