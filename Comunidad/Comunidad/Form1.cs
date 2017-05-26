using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Comunidad
{
    public partial class Form1 : Form
    {
        List<Gastos> miGasto = new List<Gastos>();
        List<Comunidad_Clase> miComunidad = new List<Comunidad_Clase>();
        List<Gastos_Clase> miGastoClase = new List<Gastos_Clase>();
        List<Propietarios> miPropietario = new List<Propietarios>();
        List<Propiedades_Comercial> miComercial = new List<Propiedades_Comercial>();
        List<Propiedades_Pisos> miPiso = new List<Propiedades_Pisos>();
        List<Propiedades_Garaje> miGaraje = new List<Propiedades_Garaje>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombrearchivo = "Gastos.txt";
            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                int cont= 0;
                Gastos gastoT = new Gastos();
                string palabras = leer.ReadLine();
                string [] dividida = palabras.Split(';');
                foreach (string s in dividida)
                {

                    if (s.Trim() != "")
                    { 
                        if (cont == 0)
                            gastoT.Identificación = s;
                        if (cont == 1)
                            gastoT.Nombre = s;
                        if (cont == 2)
                            gastoT.Tipo_de_reparto = s;
                    }
                    cont++;
                }
                miGasto.Add(gastoT);
            }
            dataGridView1.DataSource = miGasto;
            dataGridView1.Refresh();
            leer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombrearchivo = "Comunidad.txt";
            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                int cont = 0;
                Comunidad_Clase comunidadT = new Comunidad_Clase();
                string palabras = leer.ReadLine();
                string[] dividida = palabras.Split(';');
                foreach (string s in dividida)
                {

                    if (s.Trim() != "")
                    { 
                        if (cont == 0)
                            comunidadT.Identificación = Convert.ToInt32(s);
                        if (cont == 1)
                            comunidadT.Nombre = s;
                        if (cont == 2)
                            comunidadT.Poblacion = s;
                    }
                    cont++;
                }
                miComunidad.Add(comunidadT);
            }
            dataGridView1.DataSource = miComunidad;
            dataGridView1.Refresh();
            leer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombrearchivo = "Gastos_Clase.txt";
            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                int cont = 0;
                Gastos_Clase gastoClaseT = new Gastos_Clase();
                string palabras = leer.ReadLine();
                string[] dividida = palabras.Split(';');
                foreach (string s in dividida)
                {

                    if (s.Trim() != "")
                    {
                        if (cont == 0)
                            gastoClaseT.Id_gasto = s;
                        if (cont == 1)
                            gastoClaseT.Descripción = s;
                        if (cont == 2)
                            gastoClaseT.Importe = Convert.ToInt32(s);
                        if (cont == 3)
                            gastoClaseT.Tipo_zona_reparto=s;
                    }
                    cont++;
                }
                miGastoClase.Add(gastoClaseT);
            }
            dataGridView1.DataSource = miGastoClase;
            dataGridView1.Refresh();
            leer.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombrearchivo = "Propietarios.txt";
            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                int cont = 0;
                Propietarios propietarioT = new Propietarios();
                string palabras = leer.ReadLine();
                string[] dividida = palabras.Split(';');
                foreach (string s in dividida)
                {

                    if (s.Trim() != "")
                    {
                        if (cont == 0)
                            propietarioT.Nombre = s;
                        if (cont == 1)
                            propietarioT.Nit = s;
                        if (cont == 2)
                            propietarioT.Email = s;
                    }
                    cont++;
                }
                miPropietario.Add(propietarioT);
            }
            dataGridView1.DataSource = miPropietario;
            dataGridView1.Refresh();
            leer.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nombrearchivo = "Propiedades.txt";
            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                int cont = 0;
                Propiedades_Comercial comercialT = new Propiedades_Comercial();
                string palabras = leer.ReadLine();
                string[] dividida = palabras.Split(';');
                if(dividida[0]=="L")
                { 
                    foreach (string s in dividida)
                    {
                        if (s.Trim() != "")
                        {
                            if (cont == 0)
                                comercialT.Tipo = s;
                            if (cont == 1)
                                comercialT.Codigo_propiedad = s;
                            if (cont == 2)
                                comercialT.Metros_cuadrados=Convert.ToInt32(s);
                            if (cont == 3)
                                comercialT.Codigo_propietario = s;
                            if (cont == 4)
                                comercialT.Lista_gastos=s;
                            if (cont == 5)
                                comercialT.Nombre_comercial=s;
                            if (cont == 5)
                                comercialT.Actividad=s;
                        }
                        cont++;
                    }
                }
                miComercial.Add(comercialT);
            }
            dataGridView1.DataSource = miComercial;
            dataGridView1.Refresh();
            leer.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string nombrearchivo = "Propiedades.txt";
            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                int cont = 0;
                Propiedades_Pisos pisoT = new Propiedades_Pisos();
                string palabras = leer.ReadLine();
                string[] dividida = palabras.Split(';');
                if (dividida[0] == "P")
                {
                    foreach (string s in dividida)
                    {
                        if (s.Trim() != "")
                        {
                            if (cont == 0)
                                pisoT.Tipo = s;
                            if (cont == 1)
                                pisoT.Codigo_propiedad = s;
                            if (cont == 2)
                                pisoT.Metros_cuadrados = Convert.ToInt32(s);
                            if (cont == 3)
                                pisoT.Codigo_propietario = s;
                            if (cont == 4)
                                pisoT.Lista_gastos = s;
                            if (cont == 5)
                                pisoT.Vivienda = s;
                            if (cont == 6)
                                pisoT.Numero_dormitorios = Convert.ToInt32(s);
                        }
                        cont++;
                    }
                }
                miPiso.Add(pisoT);
            }
            dataGridView1.DataSource = miPiso;
            dataGridView1.Refresh();
            leer.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nombrearchivo = "Propiedades.txt";
            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                int cont = 0;
                Propiedades_Garaje garajeT = new Propiedades_Garaje();
                string palabras = leer.ReadLine();
                string[] dividida = palabras.Split(';');
                if (dividida[0] == "G")
                {
                    foreach (string s in dividida)
                    {
                        if (s.Trim() != "")
                        {
                            if (cont == 0)
                                garajeT.Tipo = s;
                            if (cont == 1)
                                garajeT.Codigo_propiedad = s;
                            if (cont == 2)
                                garajeT.Metros_cuadrados = Convert.ToInt32(s);
                            if (cont == 3)
                                garajeT.Codigo_propietario = s;
                            if (cont == 4)
                                garajeT.Lista_gastos = s;
                            if (cont == 5)
                                garajeT.Estado_garaje = s;
                            if (cont == 6)
                                garajeT.Bodega = s;
                        }
                        cont++;
                    }
                }
                miGaraje.Add(garajeT);
            }
            dataGridView1.DataSource = miGaraje;
            dataGridView1.Refresh();
            leer.Close();
        }
    }
}
