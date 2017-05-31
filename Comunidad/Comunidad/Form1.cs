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
            Mostrar_Gridview Vista = new Mostrar_Gridview(2);
            Vista.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mostrar_Gridview Vista = new Mostrar_Gridview(1);
            Vista.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mostrar_Gridview Vista = new Mostrar_Gridview(3);
            Vista.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mostrar_Gridview Vista = new Mostrar_Gridview(4);
            Vista.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mostrar_Gridview Vista = new Mostrar_Gridview(7);
            Vista.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Mostrar_Gridview Vista = new Mostrar_Gridview(5);
            Vista.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mostrar_Gridview Vista = new Mostrar_Gridview(6);
            Vista.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Mostrar_Gridview Vista = new Mostrar_Gridview(8);
            Vista.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
