using Examen_final.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final
{
    public partial class edificiosfrm : Form
    {
        int edificios_id;
        public edificiosfrm()
        {
            InitializeComponent();
        }

        private void edificiosfrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = edificio.obtener();
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns["edificios_id"].Visible = false;
            }

        }
        private void botton1_Click(object sender, EventArgs e)
        {
            string nombre = txtnom_e.Text;
            string direccion = txtdire.Text;
            bool resultado = false;
            if (edificios_id == 0)
            {
                resultado = edificio.Crear(nombre, direccion);
            }
            else
            {
                resultado = edificio.Editar(edificios_id, nombre, direccion);
            }
            if (resultado)
            {
                MessageBox.Show("Operación exitosa");
                dataGridView1.DataSource = edificio.obtener();
                //limpiar();
            }
            else
            {
                MessageBox.Show("Error en la operación");
            }
        }
    } 
}    