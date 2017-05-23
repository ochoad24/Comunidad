using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Gastos_Clase
    {
        private string id_gasto;
        private string descripción;
        private int importe;
        private string tipo_zona_reparto;

        public string Id_gasto
        {
            get
            {
                return id_gasto;
            }

            set
            {
                id_gasto = value;
            }
        }

        public string Descripción
        {
            get
            {
                return descripción;
            }

            set
            {
                descripción = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string Tipo_zona_reparto
        {
            get
            {
                return tipo_zona_reparto;
            }

            set
            {
                tipo_zona_reparto = value;
            }
        }
    }
}
