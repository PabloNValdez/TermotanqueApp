namespace Termotanque
{
    public partial class Estados : Form
    {
        public Estados()
        {
            InitializeComponent();
        }

        String str = "";

        // INICIO
        private void btn_inicio_0_Click(object sender, EventArgs e)
        {
            btn_preparado.BackColor = Color.Firebrick;
            btn_carga.Enabled = false;
            btn_carga_0.Enabled = false;
            btn_carga_1.Enabled = false;
            btn_preparado.Text = string.Format("OFF");
            str = str + "0";
            txb_str.Text = string.Format(str);
        }
        private void btn_inicio_1_Click(object sender, EventArgs e)
        {
            btn_preparado.BackColor = Color.ForestGreen;
            btn_carga.Enabled = true;
            btn_carga_0.Enabled = true;
            btn_carga_1.Enabled = true;
            btn_preparado.Text = string.Format("ON");
            btn_preparado.Enabled = false;
            btn_preparado_0.Enabled = false;
            btn_preparado_1.Enabled = false;
            str = str + "1";
            txb_str.Text = string.Format(str);
        }

        // CARGA
        private void btn_carga_0_Click(object sender, EventArgs e)
        {
            btn_carga.BackColor = Color.Firebrick;
            btn_quemador.Enabled = false;
            btn_quemador_0.Enabled = false;
            btn_quemador_1.Enabled = false;
            btn_carga.Text = string.Format("NO LLENO");
            str = str + "0";
            txb_str.Text = string.Format(str);
        }
        private void btn_carga_1_Click(object sender, EventArgs e)
        {
            btn_carga.BackColor = Color.ForestGreen;
            btn_quemador.Enabled = true;
            btn_quemador_0.Enabled = true;
            btn_quemador_1.Enabled = true;
            btn_quemador.BackColor = Color.Transparent;
            btn_carga.Text = string.Format("LLENO");
            btn_carga.Enabled = false;
            btn_carga_0.Enabled = false;
            btn_carga_1.Enabled = false;
            str = str + "1";
            txb_str.Text = string.Format(str);
            btn_quemador.Text = string.Format("QUEMADOR");
        }

        // QUEMADOR
        private void btn_quemador_0_Click(object sender, EventArgs e)
        {
            btn_quemador.BackColor = Color.ForestGreen;
            btn_espera.Enabled = true;
            btn_espera_0.Enabled = true;
            btn_espera_1.Enabled = true;
            btn_quemador.Text = string.Format("TEMP DESEADA");
            btn_quemador.Enabled = false;
            btn_quemador_0.Enabled = false;
            btn_quemador_1.Enabled = false;
            btn_espera.BackColor = Color.ForestGreen;
            str = str + "0";
            txb_str.Text = string.Format(str);
            btn_espera.Text = string.Format("ESPERA");
        }
        private void btn_quemador_1_Click(object sender, EventArgs e)
        {
            btn_quemador.BackColor = Color.Firebrick;
            btn_espera.Enabled = false;
            btn_espera_0.Enabled = false;
            btn_espera_1.Enabled = false;
            btn_quemador.Text = string.Format("TEMP BAJA");
            str = str + "1";
            txb_str.Text = string.Format(str);
        }

        // ESPERA
        private void btn_espera_0_Click(object sender, EventArgs e)
        {
            btn_espera.BackColor = Color.Firebrick;
            btn_carga.Enabled = true;
            btn_carga_0.Enabled = true;
            btn_carga_1.Enabled = true;
            btn_espera.Text = string.Format("NO LLENO");
            btn_carga.Text = string.Format("NO LLENO");
            btn_carga.BackColor = Color.Firebrick;
            btn_espera.Enabled = false;
            btn_espera_0.Enabled = false;
            btn_espera_1.Enabled = false;
            str = str + "0";
            txb_str.Text = string.Format(str);
        }
        private void btn_espera_1_Click(object sender, EventArgs e)
        {
            btn_espera.BackColor = Color.Firebrick;
            btn_quemador.Enabled = true;
            btn_quemador_0.Enabled = true;
            btn_quemador_1.Enabled = true;
            btn_espera.Text = string.Format("TEMP BAJA");
            btn_quemador.Text = string.Format("TEMP BAJA");
            btn_quemador.BackColor = Color.Firebrick;
            btn_espera.Enabled = false;
            btn_espera_0.Enabled = false;
            btn_espera_1.Enabled = false;
            str = str + "1";
            txb_str.Text = string.Format(str);
        }

        // RESET
        private void btn_reset_Click(object sender, EventArgs e)
        {
            str = "";
            txb_str.Clear();
            btn_preparado.BackColor = Color.Transparent;
            btn_preparado.Enabled = true;
            btn_preparado_0.Enabled = true;
            btn_preparado_1.Enabled = true;
            btn_carga.BackColor = Color.Transparent;
            btn_carga.Enabled = false;
            btn_carga_0.Enabled = false;
            btn_carga_1.Enabled = false;
            btn_quemador.BackColor = Color.Transparent;
            btn_quemador.Enabled = false;
            btn_quemador_0.Enabled = false;
            btn_quemador_1.Enabled = false;
            btn_espera.BackColor = Color.Transparent;
            btn_espera.Enabled = false;
            btn_espera_0.Enabled = false;
            btn_espera_1.Enabled = false;

            btn_preparado.Text = string.Format("INICIO");
            btn_carga.Text = string.Format("CARGA");
            btn_quemador.Text = string.Format("QUEMADOR");
            btn_espera.Text = string.Format("ESPERA");
        }
    }
}