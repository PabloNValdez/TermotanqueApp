using System;
using System.Drawing;
using System.Windows.Forms;

namespace Termotanque
{
    public partial class Estados : Form
    {
        public Estados()
        {
            InitializeComponent();
            EnableAllButtons();
        }

        String str = "";
        bool isEncendido = false;

        private void EnableAllButtons()
        {
            btn_preparado.Enabled = true;
            btn_preparado_0.Enabled = true;
            btn_preparado_1.Enabled = true;
            btn_carga.Enabled = true;
            btn_carga_0.Enabled = true;
            btn_carga_1.Enabled = true;
            btn_quemador.Enabled = true;
            btn_quemador_0.Enabled = true;
            btn_quemador_1.Enabled = true;
            btn_espera.Enabled = true;
            btn_espera_0.Enabled = true;
            btn_espera_1.Enabled = true;
        }

        // INICIO
        private void btn_inicio_0_Click(object sender, EventArgs e)
        {
            btn_preparado.BackColor = Color.Firebrick;
            btn_preparado.Text = "OFF";
            str = str + "0";
            txb_str.Text = str;
            isEncendido = false;
        }

        private void btn_inicio_1_Click(object sender, EventArgs e)
        {
            if (isEncendido)
            {
                MessageBox.Show("El termotanque ya está encendido.", "Información");
                return;
            }

            btn_preparado.BackColor = Color.ForestGreen;
            btn_preparado.Text = "ON";
            str = str + "1";
            txb_str.Text = str;
            isEncendido = true;
        }

        // CARGA
        private void btn_carga_0_Click(object sender, EventArgs e)
        {
            if (!isEncendido)
            {
                MessageBox.Show("Antes de poder verificar el llenado deberías encender el termotanque.", "Error");
                return;
            }
            btn_carga.BackColor = Color.Firebrick;
            btn_carga.Text = "NO LLENO";
            str = str + "0";
            txb_str.Text = str;

            // Reflect state change in the "ESPERA" button
            btn_espera.BackColor = Color.Firebrick;
            btn_espera.Text = "NO LLENO";
        }

        private void btn_carga_1_Click(object sender, EventArgs e)
        {
            if (!isEncendido)
            {
                MessageBox.Show("Antes de poder verificar el llenado deberías encender el termotanque.", "Error");
                return;
            }
            btn_carga.BackColor = Color.ForestGreen;
            btn_carga.Text = "LLENO";
            str = str + "1";
            txb_str.Text = str;

            // Check if ESPERA state should be reset
            if (btn_quemador.Text == "TEMP DESEADA")
            {
                btn_espera.BackColor = Color.ForestGreen;
                btn_espera.Text = "ESPERA";
            }
        }

        // QUEMADOR
        private void btn_quemador_0_Click(object sender, EventArgs e)
        {
            if (!isEncendido)
            {
                MessageBox.Show("Antes de poder usar el quemador, debes encender el termotanque.", "Error");
                return;
            }
            if (btn_carga.Text != "LLENO")
            {
                MessageBox.Show("Antes de poder usar el quemador, debes llenar el termotanque.", "Error");
                return;
            }
            btn_quemador.BackColor = Color.ForestGreen;
            btn_quemador.Text = "TEMP DESEADA";
            str = str + "0";
            txb_str.Text = str;

            // Check if ESPERA state should be reset
            if (btn_carga.Text == "LLENO")
            {
                btn_espera.BackColor = Color.ForestGreen;
                btn_espera.Text = "ESPERA";
            }
        }

        private void btn_quemador_1_Click(object sender, EventArgs e)
        {
            if (!isEncendido)
            {
                MessageBox.Show("Antes de poder usar el quemador, debes encender el termotanque.", "Error");
                return;
            }
            if (btn_carga.Text != "LLENO")
            {
                MessageBox.Show("Antes de poder usar el quemador, debes llenar el termotanque.", "Error");
                return;
            }
            btn_quemador.BackColor = Color.Firebrick;
            btn_quemador.Text = "TEMP BAJA";
            str = str + "1";
            txb_str.Text = str;

            // Reflect state change in the "ESPERA" button
            btn_espera.BackColor = Color.Firebrick;
            btn_espera.Text = "TEMP BAJA";
        }

        // ESPERA
        private void btn_espera_0_Click(object sender, EventArgs e)
        {
            if (!isEncendido)
            {
                MessageBox.Show("Antes de poder usar el modo de espera, debes encender el termotanque.", "Error");
                return;
            }
            if (btn_quemador.Text != "TEMP DESEADA")
            {
                MessageBox.Show("Para pasar a la espera, debes alcanzar la temperatura deseada.", "Error");
                return;
            }
            btn_espera.BackColor = Color.Firebrick;
            btn_espera.Text = "NO LLENO";
            str = str + "0";
            txb_str.Text = str;

            // Reflect state change in the "CARGA" button
            btn_carga.BackColor = Color.Firebrick;
            btn_carga.Text = "NO LLENO";
        }

        private void btn_espera_1_Click(object sender, EventArgs e)
        {
            if (!isEncendido)
            {
                MessageBox.Show("Antes de poder usar el modo de espera, debes encender el termotanque.", "Error");
                return;
            }
            if (btn_quemador.Text != "TEMP DESEADA")
            {
                MessageBox.Show("Para pasar a la espera, debes alcanzar la temperatura deseada.", "Error");
                return;
            }
            btn_espera.BackColor = Color.Firebrick;
            btn_espera.Text = "TEMP BAJA";
            str = str + "1";
            txb_str.Text = str;

            // Reflect state change in the "QUEMADOR" button
            btn_quemador.BackColor = Color.Firebrick;
            btn_quemador.Text = "TEMP BAJA";
        }

        // RESET
        private void btn_reset_Click(object sender, EventArgs e)
        {
            str = "";
            txb_str.Clear();
            isEncendido = false;

            btn_preparado.BackColor = Color.Transparent;
            btn_preparado.Text = "INICIO";
            btn_carga.BackColor = Color.Transparent;
            btn_carga.Text = "CARGA";
            btn_quemador.BackColor = Color.Transparent;
            btn_quemador.Text = "QUEMADOR";
            btn_espera.BackColor = Color.Transparent;
            btn_espera.Text = "ESPERA";
        }
    }
}


