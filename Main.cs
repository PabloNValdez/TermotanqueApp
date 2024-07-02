using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Termotanque
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public void AbrirFormulario<MIForm>() where MIForm : Form, new()
        {
            Form formulario;
            formulario = pnl_contenedor.Controls.OfType<MIForm>().FirstOrDefault(); // Busca en la coleccion el formulario
            //si el formulario/instancio no existe
            if (formulario == null)
            {
                formulario = new MIForm();
                formulario.TopLevel = false;
                pnl_contenedor.Controls.Add(formulario);
                pnl_contenedor.Tag = formulario;
                formulario.Show();
                formulario.Dock = DockStyle.Fill;
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.WindowState = FormWindowState.Normal; // RESTAURA AL ESTADO NORMAL SI EL FORMULARIO ESTA MINIMIZADO
                formulario.BringToFront(); // TRAE EL FORMULARIO AL FRENTE 
            }
        }

        private void btn_estados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Estados>();
        }

        private void btn_diseño_Click(object sender, EventArgs e)
        {
            AbrirFormulario<DiseñoMaquina>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<DiseñoTransiciones>();
        }
    }
}
