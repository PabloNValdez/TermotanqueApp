using System;
using System.Drawing;
using System.Windows.Forms;

namespace Termotanque
{
    public partial class Estados : Form
    {
        private System.Windows.Forms.Timer timer;
        private int tiempoRestante = 60;
        private bool aguaCalentandose = false;
        private System.Windows.Forms.Timer temporizadorTermostato;
        private int tiempoRestanteTermostato = 120; // 2 minutos
        private bool termostatoActivo = false;


        public Estados()
        {
            InitializeComponent();
            EnableAllButtons();
            InicializarTemporizador();
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
            btn_reset.Enabled = true;
        }

        private void InicializarTemporizador()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;

            temporizadorTermostato = new System.Windows.Forms.Timer();
            temporizadorTermostato.Interval = 1000; // 1 segundo
            temporizadorTermostato.Tick += TemporizadorTermostato_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            lblTemporizador.Text = $"Tiempo restante: {tiempoRestante} segundos";

            if (tiempoRestante <= 0)
            {
                timer.Stop();
                lblTemporizador.Text = "Agua caliente lista";

                // Actualizar el estado del quemador
                btn_quemador.BackColor = Color.ForestGreen;
                btn_quemador.Text = "TEMP DESEADA";

                // Cambiar al estado de espera
                btn_espera.BackColor = Color.ForestGreen;
                btn_espera.Text = "ESPERA";

                // Actualizar el texto de los botones de quemador y espera
                str = str + "0"; // Agregar a la secuencia de estados
                txb_str.Text = str;

                // Iniciar el temporizador del termostato
                tiempoRestanteTermostato = 120; // 2 minutos
                temporizadorTermostato.Start();
                termostatoActivo = true;
            }
        }

        private void TemporizadorTermostato_Tick(object sender, EventArgs e)
        {
            tiempoRestanteTermostato--;
            lblTemporizadorTermostato.Text = $"Tiempo restante termostato: {tiempoRestanteTermostato} segundos"; // Opcional, si quieres mostrar el tiempo restante del termostato

            if (tiempoRestanteTermostato <= 0)
            {
                temporizadorTermostato.Stop();
                termostatoActivo = false;

                // Reiniciar el calentamiento automáticamente
                btn_quemador.BackColor = Color.Firebrick;
                btn_quemador.Text = "TEMP BAJA";
                btn_espera.BackColor = Color.Firebrick;
                btn_espera.Text = "TEMP BAJA";
                str = str + "1"; // Agregar a la secuencia de estados
                txb_str.Text = str;

                tiempoRestante = 60;
                lblTemporizador.Text = $"Tiempo restante: {tiempoRestante} segundos";
                timer.Start();
                aguaCalentandose = true;
            }
        }



        // INICIO
        private void btn_inicio_0_Click(object sender, EventArgs e)
        {
            btn_preparado.BackColor = Color.Firebrick;
            btn_preparado.Text = "OFF";
            str = str + "0";
            txb_str.Text = str;
            isEncendido = false;

            // Detener ambos temporizadores
            timer.Stop();
            temporizadorTermostato.Stop();

            // Reiniciar los temporizadores y las variables relacionadas
            tiempoRestante = 60;
            tiempoRestanteTermostato = 120;
            lblTemporizador.Text = "";
            aguaCalentandose = false;
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

            // Iniciar el temporizador cuando el tanque esté lleno y el agua no se está calentando
            if (btn_carga.Text == "LLENO" && isEncendido && !aguaCalentandose)
            {
                tiempoRestante = 60;
                lblTemporizador.Text = $"Tiempo restante: {tiempoRestante} segundos";
                timer.Start();
                aguaCalentandose = true;
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
            if (tiempoRestante > 0)
            {
                MessageBox.Show($"El agua aún no está caliente. Tiempo restante: {tiempoRestante} segundos", "Error");
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
            if (aguaCalentandose)
            {
                MessageBox.Show("Por favor, espere a que el temporizador termine antes de informar que la temperatura sigue baja.", "Información");
                return;
            }

            // Detener el temporizador del termostato
            if (termostatoActivo)
            {
                temporizadorTermostato.Stop();
                termostatoActivo = false;
            }

            btn_quemador.BackColor = Color.Firebrick;
            btn_quemador.Text = "TEMP BAJA";
            str = str + "1";
            txb_str.Text = str;

            // Reflect state change in the "ESPERA" button
            btn_espera.BackColor = Color.Firebrick;
            btn_espera.Text = "TEMP BAJA";

            // Reiniciar el temporizador
            tiempoRestante = 60;
            lblTemporizador.Text = $"Tiempo restante: {tiempoRestante} segundos";
            timer.Start();
            aguaCalentandose = true;
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
            if (aguaCalentandose)
            {
                MessageBox.Show("Por favor, espere a que el temporizador termine antes de informar que la temperatura sigue baja.", "Información");
                return;
            }

            // Detener el temporizador del termostato
            if (termostatoActivo)
            {
                temporizadorTermostato.Stop();
                termostatoActivo = false;
            }

            btn_espera.BackColor = Color.Firebrick;
            btn_espera.Text = "TEMP BAJA";
            str = str + "1";
            txb_str.Text = str;

            // Reflect state change in the "QUEMADOR" button
            btn_quemador.BackColor = Color.Firebrick;
            btn_quemador.Text = "TEMP BAJA";

            // Reiniciar el temporizador
            tiempoRestante = 60;
            lblTemporizador.Text = $"Tiempo restante: {tiempoRestante} segundos";
            timer.Start();
            aguaCalentandose = true;
        }

        // RESET
        private void btn_reset_Click(object sender, EventArgs e)
        {
            str = "";
            txb_str.Clear();
            isEncendido = false;
            tiempoRestante = 60;
            timer.Stop();
            aguaCalentandose = false;

            btn_preparado.BackColor = Color.Transparent;
            btn_preparado.Text = "INICIO";
            btn_carga.BackColor = Color.Transparent;
            btn_carga.Text = "CARGA";
            btn_quemador.BackColor = Color.Transparent;
            btn_quemador.Text = "QUEMADOR";
            btn_espera.BackColor = Color.Transparent;
            btn_espera.Text = "ESPERA";

            lblTemporizador.Text = "";
        }
    }
}
