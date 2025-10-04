using controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace presentacion
{
    public partial class TipoVehi : Form
    {
        public TipoVehi()
        {
            InitializeComponent();
            dataGridView1.DataSource = AccesoLogica.ObtenerTiposVehiculos();
            // limpiarCampos();
        }
        //Return limpiarCampos(); 

     

        void limpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccesoLogica.ObtenerTiposVehiculos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocision = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1[0, pocision].Value.ToString();
            textBox2.Text = dataGridView1[1, pocision].Value.ToString();
        }

        private void btn_registar_click_Click(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int IdTipo = Int32.Parse(textBox1.Text);
            string NombreTipo = textBox2.Text;
            int resultado = negocio.Insert(IdTipo, NombreTipo);

            if (resultado > 0)
                label1.Text = "Nuevo Registro Agregado Satisfactoriamente";
            else
                label1.Text = "Id ya existe, agregue otro o no se inserto el dato";

            negocio = null;
            limpiarCampos();
        }

        private void btn_Mod_Click_Click(object sender, EventArgs e)
        {
            AccesoLogica negocioactualizar = new AccesoLogica();
            int idtipo = Int32.Parse(textBox1.Text);
            string nombretipo = textBox2.Text;

            int resultadoActualizar = negocioactualizar.Update(idtipo, nombretipo);

            if (resultadoActualizar > 0)
            {
                label1.Text = "Registro Actualizado";
            }
            else
            {
                label1.Text = "Registro no Actualizado";
                negocioactualizar = null;
            }
        }

        private void btn_elimi_Click_Click(object sender, EventArgs e)
        {
            AccesoLogica negocioeliminar = new AccesoLogica();
            int idtipo = Int32.Parse(textBox1.Text);

            int resultadoeliminar = negocioeliminar.delete(idtipo);
            if (resultadoeliminar > 0)
            {
                label1.Text = "Registro Eliminado";
            }
            else
            {
                label1.Text = "Registro no Eliminado";
                negocioeliminar = null;
            }
        }
    }
}
