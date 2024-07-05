namespace Termotanque
{
    partial class Estados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_reset = new Button();
            label1 = new Label();
            txb_str = new TextBox();
            pnl_contenedor = new Panel();
            lblTemporizador = new Label();
            panel7 = new Panel();
            btn_espera = new Button();
            panel8 = new Panel();
            btn_espera_1 = new Button();
            btn_espera_0 = new Button();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            btn_quemador = new Button();
            panel6 = new Panel();
            btn_quemador_1 = new Button();
            btn_quemador_0 = new Button();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            btn_carga = new Button();
            panel3 = new Panel();
            btn_carga_1 = new Button();
            btn_carga_0 = new Button();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            btn_preparado = new Button();
            panel1 = new Panel();
            btn_preparado_1 = new Button();
            btn_preparado_0 = new Button();
            pictureBox1 = new PictureBox();
            pnl_contenedor.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(598, 19);
            btn_reset.Margin = new Padding(3, 2, 3, 2);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(161, 46);
            btn_reset.TabIndex = 1;
            btn_reset.Text = "RESET";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(616, 408);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 12;
            label1.Text = "Cadena Generada:";
            // 
            // txb_str
            // 
            txb_str.Location = new Point(598, 425);
            txb_str.Margin = new Padding(3, 2, 3, 2);
            txb_str.Name = "txb_str";
            txb_str.Size = new Size(162, 23);
            txb_str.TabIndex = 13;
            // 
            // pnl_contenedor
            // 
            pnl_contenedor.Controls.Add(lblTemporizador);
            pnl_contenedor.Controls.Add(panel7);
            pnl_contenedor.Controls.Add(txb_str);
            pnl_contenedor.Controls.Add(panel4);
            pnl_contenedor.Controls.Add(label1);
            pnl_contenedor.Controls.Add(btn_reset);
            pnl_contenedor.Controls.Add(panel2);
            pnl_contenedor.Controls.Add(panel5);
            pnl_contenedor.Location = new Point(3, 9);
            pnl_contenedor.Margin = new Padding(3, 2, 3, 2);
            pnl_contenedor.Name = "pnl_contenedor";
            pnl_contenedor.Size = new Size(792, 517);
            pnl_contenedor.TabIndex = 17;
            // 
            // lblTemporizador
            // 
            lblTemporizador.AutoSize = true;
            lblTemporizador.Location = new Point(381, 40);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new Size(92, 15);
            lblTemporizador.TabIndex = 16;
            lblTemporizador.Text = "";
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightBlue;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(btn_espera);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(32, 238);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(161, 260);
            panel7.TabIndex = 15;
            // 
            // btn_espera
            // 
            btn_espera.BackColor = Color.WhiteSmoke;
            btn_espera.Enabled = false;
            btn_espera.Location = new Point(8, 8);
            btn_espera.Margin = new Padding(3, 2, 3, 2);
            btn_espera.Name = "btn_espera";
            btn_espera.Size = new Size(144, 38);
            btn_espera.TabIndex = 3;
            btn_espera.Text = "ESPERA";
            btn_espera.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.WhiteSmoke;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(btn_espera_1);
            panel8.Controls.Add(btn_espera_0);
            panel8.Controls.Add(pictureBox4);
            panel8.Location = new Point(8, 50);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(145, 202);
            panel8.TabIndex = 0;
            // 
            // btn_espera_1
            // 
            btn_espera_1.Enabled = false;
            btn_espera_1.Location = new Point(3, 160);
            btn_espera_1.Margin = new Padding(3, 2, 3, 2);
            btn_espera_1.Name = "btn_espera_1";
            btn_espera_1.Size = new Size(137, 38);
            btn_espera_1.TabIndex = 2;
            btn_espera_1.Text = "1 - TEMP BAJA";
            btn_espera_1.UseVisualStyleBackColor = true;
            btn_espera_1.Click += btn_espera_1_Click;
            // 
            // btn_espera_0
            // 
            btn_espera_0.Enabled = false;
            btn_espera_0.Location = new Point(3, 117);
            btn_espera_0.Margin = new Padding(3, 2, 3, 2);
            btn_espera_0.Name = "btn_espera_0";
            btn_espera_0.Size = new Size(137, 38);
            btn_espera_0.TabIndex = 1;
            btn_espera_0.Text = "0 - NO LLENO";
            btn_espera_0.UseVisualStyleBackColor = true;
            btn_espera_0.Click += btn_espera_0_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = Properties.Resources.tanque;
            pictureBox4.Location = new Point(3, 2);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(138, 101);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btn_quemador);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(214, 19);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(161, 260);
            panel4.TabIndex = 14;
            // 
            // btn_quemador
            // 
            btn_quemador.BackColor = Color.WhiteSmoke;
            btn_quemador.Enabled = false;
            btn_quemador.Location = new Point(8, 8);
            btn_quemador.Margin = new Padding(3, 2, 3, 2);
            btn_quemador.Name = "btn_quemador";
            btn_quemador.Size = new Size(144, 38);
            btn_quemador.TabIndex = 3;
            btn_quemador.Text = "QUEMADOR";
            btn_quemador.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btn_quemador_1);
            panel6.Controls.Add(btn_quemador_0);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(8, 50);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(145, 202);
            panel6.TabIndex = 0;
            // 
            // btn_quemador_1
            // 
            btn_quemador_1.Enabled = false;
            btn_quemador_1.Location = new Point(3, 160);
            btn_quemador_1.Margin = new Padding(3, 2, 3, 2);
            btn_quemador_1.Name = "btn_quemador_1";
            btn_quemador_1.Size = new Size(137, 38);
            btn_quemador_1.TabIndex = 2;
            btn_quemador_1.Text = "1 - TEMP BAJA";
            btn_quemador_1.UseVisualStyleBackColor = true;
            btn_quemador_1.Click += btn_quemador_1_Click;
            // 
            // btn_quemador_0
            // 
            btn_quemador_0.Enabled = false;
            btn_quemador_0.Location = new Point(3, 117);
            btn_quemador_0.Margin = new Padding(3, 2, 3, 2);
            btn_quemador_0.Name = "btn_quemador_0";
            btn_quemador_0.Size = new Size(137, 38);
            btn_quemador_0.TabIndex = 1;
            btn_quemador_0.Text = "0 - TEMP DESEADA";
            btn_quemador_0.UseVisualStyleBackColor = true;
            btn_quemador_0.Click += btn_quemador_0_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = Properties.Resources.quemador1;
            pictureBox3.Location = new Point(3, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(138, 101);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_carga);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(394, 238);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 260);
            panel2.TabIndex = 13;
            // 
            // btn_carga
            // 
            btn_carga.BackColor = Color.WhiteSmoke;
            btn_carga.Enabled = false;
            btn_carga.Location = new Point(8, 8);
            btn_carga.Margin = new Padding(3, 2, 3, 2);
            btn_carga.Name = "btn_carga";
            btn_carga.Size = new Size(144, 38);
            btn_carga.TabIndex = 3;
            btn_carga.Text = "CARGA";
            btn_carga.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btn_carga_1);
            panel3.Controls.Add(btn_carga_0);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(8, 50);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(145, 202);
            panel3.TabIndex = 0;
            // 
            // btn_carga_1
            // 
            btn_carga_1.Enabled = false;
            btn_carga_1.Location = new Point(3, 160);
            btn_carga_1.Margin = new Padding(3, 2, 3, 2);
            btn_carga_1.Name = "btn_carga_1";
            btn_carga_1.Size = new Size(137, 38);
            btn_carga_1.TabIndex = 2;
            btn_carga_1.Text = "1 - LLENO";
            btn_carga_1.UseVisualStyleBackColor = true;
            btn_carga_1.Click += btn_carga_1_Click;
            // 
            // btn_carga_0
            // 
            btn_carga_0.Enabled = false;
            btn_carga_0.Location = new Point(3, 117);
            btn_carga_0.Margin = new Padding(3, 2, 3, 2);
            btn_carga_0.Name = "btn_carga_0";
            btn_carga_0.Size = new Size(137, 38);
            btn_carga_0.TabIndex = 1;
            btn_carga_0.Text = "0 - NO LLENO";
            btn_carga_0.UseVisualStyleBackColor = true;
            btn_carga_0.Click += btn_carga_0_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.cargaAgua;
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btn_preparado);
            panel5.Controls.Add(panel1);
            panel5.Location = new Point(598, 100);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(161, 260);
            panel5.TabIndex = 12;
            // 
            // btn_preparado
            // 
            btn_preparado.BackColor = Color.Transparent;
            btn_preparado.Location = new Point(8, 8);
            btn_preparado.Margin = new Padding(3, 2, 3, 2);
            btn_preparado.Name = "btn_preparado";
            btn_preparado.Size = new Size(144, 38);
            btn_preparado.TabIndex = 3;
            btn_preparado.Text = "INICIO";
            btn_preparado.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_preparado_1);
            panel1.Controls.Add(btn_preparado_0);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(8, 50);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 202);
            panel1.TabIndex = 0;
            // 
            // btn_preparado_1
            // 
            btn_preparado_1.Location = new Point(3, 160);
            btn_preparado_1.Margin = new Padding(3, 2, 3, 2);
            btn_preparado_1.Name = "btn_preparado_1";
            btn_preparado_1.Size = new Size(137, 38);
            btn_preparado_1.TabIndex = 2;
            btn_preparado_1.Text = "1 - ON";
            btn_preparado_1.UseVisualStyleBackColor = true;
            btn_preparado_1.Click += btn_inicio_1_Click;
            // 
            // btn_preparado_0
            // 
            btn_preparado_0.Location = new Point(3, 117);
            btn_preparado_0.Margin = new Padding(3, 2, 3, 2);
            btn_preparado_0.Name = "btn_preparado_0";
            btn_preparado_0.Size = new Size(137, 38);
            btn_preparado_0.TabIndex = 1;
            btn_preparado_0.Text = "0 - OFF";
            btn_preparado_0.UseVisualStyleBackColor = true;
            btn_preparado_0.Click += btn_inicio_0_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.onoff;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Estados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(810, 535);
            Controls.Add(pnl_contenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Estados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Termotanque";
            pnl_contenedor.ResumeLayout(false);
            pnl_contenedor.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_reset;
        private Label label1;
        private TextBox txb_str;
        private Panel pnl_contenedor;
        private Panel panel7;
        private Button btn_espera;
        private Panel panel8;
        private Button btn_espera_1;
        private Button btn_espera_0;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Button btn_quemador;
        private Panel panel6;
        private Button btn_quemador_1;
        private Button btn_quemador_0;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button btn_carga;
        private Panel panel3;
        private Button btn_carga_1;
        private Button btn_carga_0;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Button btn_preparado;
        private Panel panel1;
        private Button btn_preparado_1;
        private Button btn_preparado_0;
        private PictureBox pictureBox1;
        private Label lblTemporizador;
    }
}