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
            if (des == 9)
            {
                titulo.Text = "Propiedades";
                dataGridView1.Visible = false;
                propiedades_2();
            }
            if (des == 10)
            {
                titulo.Text = "Propietarios";
                dataGridView1.Visible = false;
                propietarios_resumen();
            }
            if (des == 11)
            {
                titulo.Text = "Cuota por Propiedades";
                dataGridView1.Visible = false;
                cuotas_propieades();
            }
            if (des == 12)
            {
                titulo.Text = "Cuota por Propietarios";
                dataGridView1.Visible = false;
                cuota_propietarios();
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
                            if (cont == 6)
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
        private void propiedades_2()
        {
            comunidad_2();
            gastos_2();
            gastos_generales_2();
            propietarios_2();
            pisos_2();
            garaje_2();
            comerciales_2();
            for (int i = 0; i < miPropietario.Count; i++)
            {
                for (int j = 0; j < miPiso.Count; j++)
                {
                    if (miPropietario[i].Nit == miPiso[j].Codigo_propietario)
                    {
                        listBox1.Items.Add("Codigo Propiedad: " + miPiso[j].Codigo_propiedad);
                        listBox1.Items.Add("Espacio: " + miPiso[j].Metros_cuadrados);
                        listBox1.Items.Add("Codigo: " + miComunidad[0].Identificación);
                        listBox1.Items.Add("Nombre Propietario: " + miPropietario[i].Nombre);
                        listBox1.Items.Add("Cuota: " + calcular_porcentaje(miPiso[j].Lista_gastos));
                        listBox1.Items.Add("Informacion Adiconal:"+ informacion(miPiso[j].Vivienda,miPiso[j].Numero_dormitorios.ToString()));
                        listBox1.Items.Add("");
                        listBox1.Items.Add("");
                    }
                }
            }
            for (int i = 0; i < miPropietario.Count; i++)
            {
                for (int j = 0; j < miComercial.Count; j++)
                {
                    if (miPropietario[i].Nit == miComercial[j].Codigo_propietario)
                    {
                        listBox1.Items.Add("Codigo Propiedad: " + miComercial[j].Codigo_propiedad);
                        listBox1.Items.Add("Espacio en m^2: " + miComercial[j].Metros_cuadrados);
                        listBox1.Items.Add("Codigo: " + miComunidad[0].Identificación);
                        listBox1.Items.Add("Nombre Propietario: " + miPropietario[i].Nombre);
                        listBox1.Items.Add("Cuota: " + calcular_porcentaje(miComercial[j].Lista_gastos));
                        listBox1.Items.Add("");
                        listBox1.Items.Add("");
                    }
                }
            }
            for (int i = 0; i < miPropietario.Count; i++)
            {
                for (int j = 0; j <miGaraje.Count; j++)
                {
                    if (miPropietario[i].Nit == miGaraje[j].Codigo_propietario)
                    {
                        listBox1.Items.Add("Codigo Propiedad: " + miGaraje[j].Codigo_propiedad);
                        listBox1.Items.Add("Espacio en m^2: " + miGaraje[j].Metros_cuadrados);
                        listBox1.Items.Add("Codigo: " + miComunidad[0].Identificación);
                        listBox1.Items.Add("Nombre Propietario: " + miPropietario[i].Nombre);
                        listBox1.Items.Add("Cuota: " + calcular_porcentaje(miGaraje[j].Lista_gastos));
                        listBox1.Items.Add("Informacion Adiconal:" + informacion(miGaraje[j].Estado_garaje, miGaraje[j].Bodega));
                        listBox1.Items.Add("");
                        listBox1.Items.Add("");
                    }
                }
            }
            listBox1.Items.Add("Total de Propiedades:" + (miComercial.Count+miPiso.Count+miGaraje.Count));
        }
        private string calcular_porcentaje(List<string> Temp)
        {
            string enviar="";
            string letraTemp="";
            string temp1 = "";
            string temp2 = "";
            for (int i = 0; i < Temp.Count;i++)
            {
                temp1 = "";
                temp2 = "";
                int num = Temp[i].IndexOf("-");
                letraTemp = Temp[i];
                for(int j=0;j<num;j++)
                {
                    temp1 += letraTemp[j];
                }
                for (int x = num+1; x < letraTemp.Length; x++)
                {
                    temp2 += letraTemp[x];
                }
                enviar = enviar+temp2+" % "+temp1+" , ";
            }
            return enviar;
        }
        private string informacion(string uno, string dos)
        {
            string enviar = "";
            string enviar2 = "";
            if (uno == "VH")
                enviar = "Vivienda Habitual";
            else if (uno == "VN")
                enviar = "Vivienda No Habitual";
            else if (uno == "A")
                enviar = "Garage Abierto";
            else if (uno == "C")
                enviar = "Garage Cerrado";
            
            if (dos == "S")
                enviar2 = "Con bodega";
            else if (dos == "N")
                enviar2 = "Sin bodega";
            else
                enviar2 = dos + " dormitorios";
            return enviar+" , "+enviar2;
        }
        private void propietarios_resumen()
        {
            comunidad_2();
            gastos_2();
            gastos_generales_2();
            propietarios_2();
            pisos_2();
            garaje_2();
            comerciales_2();
            List<string> propiedadesT = new List<string>();
            string pro_piedades="";
            int cant_propietarios = 0;
            for (int i = 0; i < miPropietario.Count; i++)
            {
                propiedadesT.Clear();
                pro_piedades = "";
                listBox1.Items.Add("Codigo: " + miComunidad[0].Identificación);
                listBox1.Items.Add("Nombre Propietario: " + miPropietario[i].Nombre);
                listBox1.Items.Add("Email: " + miPropietario[i].Email);
                for (int j = 0; j < miPiso.Count; j++)
                    if (miPropietario[i].Nit == miPiso[j].Codigo_propietario)
                        propiedadesT.Add(miPiso[j].Codigo_propiedad);
                for (int j = 0; j < miGaraje.Count; j++)
                    if (miPropietario[i].Nit == miGaraje[j].Codigo_propietario)
                        propiedadesT.Add(miGaraje[j].Codigo_propiedad);
                for (int j = 0; j < miComercial.Count; j++)
                    if (miPropietario[i].Nit == miComercial[j].Codigo_propietario)
                        propiedadesT.Add(miComercial[j].Codigo_propiedad);
                for (int j = 0; j < propiedadesT.Count; j++)
                    pro_piedades += propiedadesT[j] + " , ";
                cant_propietarios++;
                listBox1.Items.Add("Propiedades: " + pro_piedades);
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                
            }
            listBox1.Items.Add("Total de Propietarios: " +cant_propietarios);
        }
        private void cuotas_propieades()
        {
            comunidad_2();
            gastos_2();
            gastos_generales_2();
            propietarios_2();
            pisos_2();
            garaje_2();
            comerciales_2();
            double tot = 0;
            int e = 0, g=0, c=0;
            double e_p = 0, g_p = 0, c_p = 0;
            int clk_c = 0;
            int clk_g = 0;
            for (int i = 0; i < miPiso.Count; i++)
            {
                for (int y = 0; y < miPiso[i].Lista_gastos.Count; y++)
                {
                    if (miPiso[i].Lista_gastos[y].Contains("C") ==true )
                    {
                        clk_c++;
                    }
                    if (miPiso[i].Lista_gastos[y].Contains("G") == true)
                    {
                        clk_g++;
                    }
                }
            }
            for (int i = 0; i < miGaraje.Count; i++)
            {
                for (int y = 0; y < miGaraje[i].Lista_gastos.Count; y++)
                {
                    if (miGaraje[i].Lista_gastos[y].Contains("C") == true)
                    {
                        clk_c++;
                    }
                    if (miGaraje[i].Lista_gastos[y].Contains("G") == true)
                    {
                        clk_g++;
                    }
                }
            }
            for (int i = 0; i < miComercial.Count; i++)
            {
                for (int y = 0; y < miComercial[i].Lista_gastos.Count; y++)
                {
                    if (miComercial[i].Lista_gastos[y].Contains("C") == true)
                    {
                        clk_c++;
                    }
                    if (miComercial[i].Lista_gastos[y].Contains("G") == true)
                    {
                        clk_g++;
                    }
                }
            }
            for (int j = 0; j < miPiso.Count; j++)
            {
                e = 0; g = 0; c = 0;
                for (int i = 0; i < miPropietario.Count; i++)
                {
                    if (miPropietario[i].Nit == miPiso[j].Codigo_propietario)
                    {
                        listBox1.Items.Add("Propiedad: " + miPiso[j].Codigo_propiedad);
                        listBox1.Items.Add("Nombre Propietario: " + miPropietario[i].Nombre);
                        listBox1.Items.Add("Porcentajes: ");
                        for (int x=0;x<miPiso[j].Lista_gastos.Count;x++)
                        {
                            if(miPiso[j].Lista_gastos[x].Contains('E')==true)
                            {
                                e += calcular_importe(1, miPiso[j].Lista_gastos[x]);
                                e_p = porcentaje(miPiso[j].Lista_gastos[x]);
                                listBox1.Items.Add("    %E: "+(e_p*100));
                            }
                            if (miPiso[j].Lista_gastos[x].Contains('C') == true)
                            {
                                c += calcular_importe(2, miPiso[j].Lista_gastos[x]);
                                c_p= (((c / clk_c) * 100) / c);
                                listBox1.Items.Add("    %C: " + ((c / clk_c)*100)/c);
                            }
                            if (miPiso[j].Lista_gastos[x].Contains('G') == true)
                            {
                                g += calcular_importe(3, miPiso[j].Lista_gastos[x]);
                                g_p = (((g / clk_g) * 100) / g);
                                listBox1.Items.Add("    %G: " + ((g / clk_g) * 100) / g);
                            }
                        }
                        listBox1.Items.Add("Importes: ");
                        listBox1.Items.Add("    E: "+ (e * e_p));
                        listBox1.Items.Add("    C: "+ (c * (c_p/100)));
                        listBox1.Items.Add("    G: "+ (g * (g_p/100)));
                        listBox1.Items.Add("Total: "+ ((e * e_p)+ (c * (c_p / 100))+ (g * (g_p / 100))));
                        tot += (e * e_p) + (c * (c_p / 100)) + (g * (g_p / 100));
                    }
                }
            }
            listBox1.Items.Add("");
            for (int j = 0; j < miGaraje.Count; j++)
            {
                e = 0; g = 0; c = 0;
                for (int i = 0; i < miPropietario.Count; i++)
                {
                    if (miPropietario[i].Nit == miGaraje[j].Codigo_propietario)
                    {
                        listBox1.Items.Add("Propiedad: " + miGaraje[j].Codigo_propiedad);
                        listBox1.Items.Add("Nombre Propietario: " + miPropietario[i].Nombre);
                        listBox1.Items.Add("Porcentajes: ");
                        for (int x = 0; x < miGaraje[j].Lista_gastos.Count; x++)
                        {
                            if (miGaraje[j].Lista_gastos[x].Contains('E') == true)
                            {
                                e += calcular_importe(1, miGaraje[j].Lista_gastos[x]);
                                e_p = porcentaje(miGaraje[j].Lista_gastos[x]);
                                listBox1.Items.Add("    %E: " + (e_p * 100));
                            }
                            if (miGaraje[j].Lista_gastos[x].Contains('C') == true)
                            {
                                c += calcular_importe(2, miGaraje[j].Lista_gastos[x]);
                                c_p = (((c / clk_c) * 100) / c);
                                listBox1.Items.Add("    %C: " + ((c / clk_c) * 100) / c);
                            }
                            if (miGaraje[j].Lista_gastos[x].Contains('G') == true)
                            {
                                g += calcular_importe(3, miGaraje[j].Lista_gastos[x]);
                                g_p = (((g / clk_g) * 100) / g);
                                listBox1.Items.Add("    %G: " + ((g / clk_g) * 100) / g);
                            }
                        }
                        listBox1.Items.Add("Importes: ");
                        listBox1.Items.Add("    E: " + (e * e_p));
                        listBox1.Items.Add("    C: " + (c * (c_p / 100)));
                        listBox1.Items.Add("    G: " + (g * (g_p / 100)));
                        listBox1.Items.Add("Total: " + ((e * e_p) + (c * (c_p / 100)) + (g * (g_p / 100))));
                        tot += (e * e_p) + (c * (c_p / 100)) + (g * (g_p / 100));
                    }
                }
            }
            listBox1.Items.Add("");
            for (int j = 0; j < miComercial.Count; j++)
            {
                e = 0; g = 0; c = 0;
                for (int i = 0; i < miComercial.Count; i++)
                {
                    if (miPropietario[i].Nit == miComercial[j].Codigo_propietario)
                    {
                        listBox1.Items.Add("Propiedad: " + miComercial[j].Codigo_propiedad);
                        listBox1.Items.Add("Nombre Propietario: " + miPropietario[i].Nombre);
                        listBox1.Items.Add("Porcentajes: ");
                        for (int x = 0; x < miComercial[j].Lista_gastos.Count; x++)
                        {
                            if (miComercial[j].Lista_gastos[x].Contains('E') == true)
                            {
                                e += calcular_importe(1, miComercial[j].Lista_gastos[x]);
                                e_p = porcentaje(miComercial[j].Lista_gastos[x]);
                                listBox1.Items.Add("    %E: " + (e_p * 100));
                            }
                            if (miComercial[j].Lista_gastos[x].Contains('C') == true)
                            {
                                c += calcular_importe(2, miComercial[j].Lista_gastos[x]);
                                c_p = (((c / clk_c) * 100) / c);
                                listBox1.Items.Add("    %C: " + ((c / clk_c) * 100) / c);
                            }
                            if (miComercial[j].Lista_gastos[x].Contains('G') == true)
                            {
                                g += calcular_importe(3, miComercial[j].Lista_gastos[x]);
                                g_p = (((g / clk_g) * 100) / g);
                                listBox1.Items.Add("    %G: " + ((g / clk_g) * 100) / g);
                            }
                        }
                        listBox1.Items.Add("Importes: ");
                        listBox1.Items.Add("    E: " + (e * e_p));
                        listBox1.Items.Add("    C: " + (c * (c_p / 100)));
                        listBox1.Items.Add("    G: " + (g * (g_p / 100)));
                        listBox1.Items.Add("Total: " + ((e * e_p) + (c * (c_p / 100)) + (g * (g_p / 100))));
                        tot += (e * e_p) + (c * (c_p / 100)) + (g * (g_p / 100));
                    }
                }
            }
            listBox1.Items.Add((miComercial.Count + miGaraje.Count + miPiso.Count) + " Propietarios " + " Total: "+ tot);
        }
        private int calcular_importe(int x, string dato)
        {
            string dato2="";
            int numero;
            int tot = 0;
            for (int i = 2; i < dato.Length; i++)
                dato2 += dato[i];
            numero = Convert.ToInt32(dato2);
            if (x==1)
            {
                for(int i=0;i<miGastoClase.Count;i++)
                {
                    if(miGastoClase[i].Tipo_zona_reparto=="E")
                        tot += miGastoClase[i].Importe;
                }
            }
            if (x == 2)
            {
                for (int i = 0; i < miGastoClase.Count; i++)
                {
                    if (miGastoClase[i].Tipo_zona_reparto == "C")
                        tot += miGastoClase[i].Importe;
                }
            }
            if (x == 3)
            {
                for (int i = 0; i < miGastoClase.Count; i++)
                {
                    if (miGastoClase[i].Tipo_zona_reparto == "G")
                        tot += miGastoClase[i].Importe;
                }
            }

            return tot;
        }
        private double porcentaje(string dato)
        {
            string dato2 = "";
            double numero;
            for (int i = 2; i < dato.Length; i++)
                dato2 += dato[i];
            numero = Convert.ToDouble(dato2);
            numero = numero / 100;
            return numero;
        }
        private void cuota_propietarios()
        {
            comunidad_2();
            gastos_2();
            gastos_generales_2();
            propietarios_2();
            pisos_2();
            garaje_2();
            comerciales_2();
            int e = 0, g = 0, c = 0;
            double tot=0;
            double e_p = 0, g_p = 0, c_p = 0;
            double e_t_p = 0, g_t_p = 0, c_t_p = 0;
            int clk_c = 0;
            int clk_g = 0;
            for (int i = 0; i < miPiso.Count; i++)
            {
                for (int y = 0; y < miPiso[i].Lista_gastos.Count; y++)
                {
                    if (miPiso[i].Lista_gastos[y].Contains("C") == true)
                    {
                        clk_c++;
                    }
                    if (miPiso[i].Lista_gastos[y].Contains("G") == true)
                    {
                        clk_g++;
                    }
                }
            }
            for (int i = 0; i < miGaraje.Count; i++)
            {
                for (int y = 0; y < miGaraje[i].Lista_gastos.Count; y++)
                {
                    if (miGaraje[i].Lista_gastos[y].Contains("C") == true)
                    {
                        clk_c++;
                    }
                    if (miGaraje[i].Lista_gastos[y].Contains("G") == true)
                    {
                        clk_g++;
                    }
                }
            }
            for (int i = 0; i < miComercial.Count; i++)
            {
                for (int y = 0; y < miComercial[i].Lista_gastos.Count; y++)
                {
                    if (miComercial[i].Lista_gastos[y].Contains("C") == true)
                    {
                        clk_c++;
                    }
                    if (miPiso[i].Lista_gastos[y].Contains("G") == true)
                    {
                        clk_g++;
                    }
                }
            }
            for (int j = 0; j < miPropietario.Count; j++)
            {
                e = 0; g = 0; c = 0;
                e_t_p = 0; g_t_p = 0; c_t_p = 0;
                listBox1.Items.Add("CP: " + miComunidad[0].Identificación);
                listBox1.Items.Add("Nombre Propietario: " + miPropietario[j].Nombre);
                listBox1.Items.Add("Porcentajes: ");
                for (int i = 0; i < miPiso.Count; i++)
                {
                    if (miPropietario[j].Nit == miPiso[i].Codigo_propietario)
                    {
                        for (int x = 0; x < miPiso[i].Lista_gastos.Count; x++)
                        {
                            if (miPiso[i].Lista_gastos[x].Contains('E') == true)
                            {
                                e = calcular_importe(1, miPiso[i].Lista_gastos[x]);
                                e_p = porcentaje(miPiso[i].Lista_gastos[x]);
                                e_t_p += (e_p*100);
                            }
                            if (miPiso[i].Lista_gastos[x].Contains('C') == true)
                            {
                                c += calcular_importe(2, miPiso[i].Lista_gastos[x]);
                                c_p = (((c / clk_c) * 100) / c);
                                c_t_p += c_p;
                            }
                            if (miPiso[i].Lista_gastos[x].Contains('G') == true)
                            {
                                g= calcular_importe(3, miPiso[i].Lista_gastos[x]);
                                g_p = (((g / clk_g) * 100) / g);
                                g_t_p += g_p;
                            }
                        }
                    }
                }
                for (int i = 0; i < miGaraje.Count; i++)
                {
                    if (miPropietario[j].Nit == miGaraje[i].Codigo_propietario)
                    {
                        for (int x = 0; x < miGaraje[i].Lista_gastos.Count; x++)
                        {
                            if (miGaraje[i].Lista_gastos[x].Contains('E') == true)
                            {
                                e = calcular_importe(1, miGaraje[i].Lista_gastos[x]);
                                e_p = porcentaje(miGaraje[i].Lista_gastos[x]);
                                e_t_p += (e_p * 100);
                            }
                            if (miGaraje[i].Lista_gastos[x].Contains('C') == true)
                            {
                                c = calcular_importe(2, miGaraje[i].Lista_gastos[x]);
                                c_p = (((c / clk_c) * 100) / c);
                                c_t_p += c_p;
                            }
                            if (miGaraje[i].Lista_gastos[x].Contains('G') == true)
                            {
                                g = calcular_importe(3, miGaraje[i].Lista_gastos[x]);
                                g_p = (((g / clk_g) * 100) / g);
                                g_t_p += g_p;
                            }
                        }
                    }
                }
                for (int i = 0; i < miComercial.Count; i++)
                {
                    if (miPropietario[j].Nit == miComercial[i].Codigo_propietario)
                    {
                        for (int x = 0; x < miPiso[j].Lista_gastos.Count; x++)
                        {
                            if (miComercial[i].Lista_gastos[x].Contains('E') == true)
                            {
                                e = calcular_importe(1, miComercial[i].Lista_gastos[x]);
                                e_p = porcentaje(miComercial[i].Lista_gastos[x]);
                                e_t_p += (e_p * 100);
                            }
                            if (miComercial[i].Lista_gastos[x].Contains('C') == true)
                            {
                                c = calcular_importe(2, miComercial[i].Lista_gastos[x]);
                                c_p = (((c / clk_c) * 100) / c);
                                c_t_p += c_p;
                            }
                            if (miComercial[i].Lista_gastos[x].Contains('G') == true)
                            {
                                g = calcular_importe(3, miComercial[i].Lista_gastos[x]);
                                g_p = (((g / clk_g) * 100) / g);
                                g_t_p += g_p;
                            }
                        }
                    }
                }
                listBox1.Items.Add("    %E: " + e_t_p);
                listBox1.Items.Add("    %C: " + c_t_p);
                listBox1.Items.Add("    %G: " + g_t_p);
                listBox1.Items.Add("Importes: ");
                listBox1.Items.Add("    %E: " + (e  * Convert.ToDouble(e_t_p/100)));
                listBox1.Items.Add("    %C: " + (c  * Convert.ToDouble(c_t_p/100)));
                listBox1.Items.Add("    %G: " + (g  * Convert.ToDouble(g_t_p/100)));
                listBox1.Items.Add("Total: " + ((g * Convert.ToDouble(g_t_p / 100))+ (c * Convert.ToDouble(c_t_p / 100))+ (e * Convert.ToDouble(e_t_p / 100))));
                listBox1.Items.Add("");
                tot += (g * Convert.ToDouble(g_t_p / 100)) + (c * Convert.ToDouble(c_t_p / 100)) + (e * Convert.ToDouble(e_t_p / 100));
            }
            listBox1.Items.Add(miPropietario.Count+" Propietarios "+ " Total: "+tot); 
        }
    }
}
