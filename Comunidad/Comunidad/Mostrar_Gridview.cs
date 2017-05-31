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
    public partial class Mostrar_Gridview : Form
    {
        List<Gastos> miGasto = new List<Gastos>();
        List<Comunidad_Clase> miComunidad = new List<Comunidad_Clase>();
        List<Gastos_Clase> miGastoClase = new List<Gastos_Clase>();
        List<Propietarios> miPropietario = new List<Propietarios>();
        List<Propiedades_Comercial> miComercial = new List<Propiedades_Comercial>();
        List<Propiedades_Pisos> miPiso = new List<Propiedades_Pisos>();
        List<Propiedades_Garaje> miGaraje = new List<Propiedades_Garaje>();
        int des = 0;
        public Mostrar_Gridview(int num)
        {
            InitializeComponent();
            des = num;
        }

        private void Mostrar_Gridview_Load(object sender, EventArgs e)
        {
            if (des == 1)
            {
                titulo.Text = "Comunidad";
                listBox1.Visible = false;
                comunidad_2();
            }
            if (des == 2)
            {
                titulo.Text = "Gastos";
                listBox1.Visible = false;
                gastos_2();
            }
            if (des == 3)
            {
                titulo.Text = "Gastos Generales";
                listBox1.Visible = false;
                gastos_generales_2();
            }
            if (des == 4)
            {
                titulo.Text = "Propietarios";
                listBox1.Visible = false;
                propietarios_2();
            }
            if (des == 5)
            {
                titulo.Text = "Pisos";
                listBox1.Visible = false;
                pisos_2();
            }
            if (des == 6)
            {
                titulo.Text = "Garaje";
                listBox1.Visible = false;
                garaje_2();
            }
            if (des == 7)
            {
                titulo.Text = "Comerciales";
                listBox1.Visible = false;
                comerciales_2();
            }
            if (des == 8)
            {
                titulo.Text = "Resumen";
                dataGridView1.Visible = false;
                resumen_2();
            }
        }
        private void comunidad_2()
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
        private void gastos_2()
        {
            string nombrearchivo = "Gastos.txt";
            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                int cont = 0;
                Gastos gastoT = new Gastos();
                string palabras = leer.ReadLine();
                string[] dividida = palabras.Split(';');
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
        private void gastos_generales_2()
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
                            gastoClaseT.Tipo_zona_reparto = s;
                    }
                    cont++;
                }
                miGastoClase.Add(gastoClaseT);
            }
            dataGridView1.DataSource = miGastoClase;
            dataGridView1.Refresh();
            leer.Close();
        }
        private void propietarios_2()
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
        private void pisos_2()
        {
            Propiedades_Pisos pisoT = new Propiedades_Pisos();
            List<string> miLista = new List<string>();
            string nombrearchivo = "Propiedades.txt";
            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                int cont = 0;
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
                            {
                                string palabras2 = s;
                                string[] dividida2 = palabras2.Split(',');
                                foreach (string s2 in dividida2)
                                {
                                    if (s2.Trim() != "")
                                    {
                                        miLista.Add(s2);
                                    }
                                }
                                pisoT.Lista_gastos = miLista;
                            }
                            if (cont == 5)
                                pisoT.Vivienda = s;
                            if (cont == 6)
                                pisoT.Numero_dormitorios = Convert.ToInt32(s);
                        }
                        cont++;
                    }
                    miPiso.Add(pisoT);
                }
            }
            dataGridView1.DataSource = miPiso;
            dataGridView1.Refresh();
            leer.Close();
        }
        private void garaje_2()
        {
            string nombrearchivo = "Propiedades.txt";
            List<string> miLista = new List<string>();
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
                            {
                                string palabras2 = s;
                                string[] dividida2 = palabras2.Split(',');
                                foreach (string s2 in dividida2)
                                {
                                    if (s2.Trim() != "")
                                    {
                                        miLista.Add(s2);
                                    }
                                }
                                garajeT.Lista_gastos = miLista;
                            }
                            if (cont == 5)
                                garajeT.Estado_garaje = s;
                            if (cont == 6)
                                garajeT.Bodega = s;
                        }
                        cont++;
                    }
                    miGaraje.Add(garajeT);
                }
            }
            dataGridView1.DataSource = miGaraje;
            dataGridView1.Refresh();
            leer.Close();
        }
        private void comerciales_2()
        {
            string nombrearchivo = "Propiedades.txt";
            List<string> miLista = new List<string>();
            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                int cont = 0;
                Propiedades_Comercial comercialT = new Propiedades_Comercial();
                string palabras = leer.ReadLine();
                string[] dividida = palabras.Split(';');
                if (dividida[0] == "L")
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
                                comercialT.Metros_cuadrados = Convert.ToInt32(s);
                            if (cont == 3)
                                comercialT.Codigo_propietario = s;
                            if (cont == 4)
                            {
                                string palabras2 = s;
                                string[] dividida2 = palabras2.Split(',');
                                foreach (string s2 in dividida2)
                                {
                                    if (s2.Trim() != "")
                                    {
                                        miLista.Add(s2);
                                    }
                                }
                                comercialT.Lista_gastos = miLista;
                            }
                            if (cont == 5)
                                comercialT.Nombre_comercial = s;
                            if (cont == 5)
                                comercialT.Actividad = s;
                        }
                        cont++;
                    }
                    miComercial.Add(comercialT);
                }
            }
            dataGridView1.DataSource = miComercial;
            dataGridView1.Refresh();
            leer.Close();
        }
        private void resumen_2()
        {
            comunidad_2();
            gastos_2();
            gastos_generales_2();
            propietarios_2();
            pisos_2();
            garaje_2();
            comerciales_2();
            int totzonas = 0;
            int totpropiedades = 0;
            int totpropietarios = 0;
            int gastos = 0;
            for (int i = 0; i < miComunidad.Count; i++)
            {
                listBox1.Items.Add("Comunidad: " + miComunidad[i].Nombre);
                listBox1.Items.Add("Numero de Zonas: " + (totzonas = miGasto.Count));
                listBox1.Items.Add("Numero de Propiedades: " + (totpropiedades = miGaraje.Count + miPiso.Count + miComercial.Count));
                listBox1.Items.Add("Numero de Propietarios: " + (totpropietarios = miPropietario.Count));
                for (int j = 0; j < miGastoClase.Count; j++)
                {
                    gastos += miGastoClase[j].Importe;
                }
                listBox1.Items.Add("Total de Gastos: " + (gastos));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
