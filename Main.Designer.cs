namespace Termotanque
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_contenedor = new Panel();
            btn_estados = new Button();
            btn_diseño = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // pnl_contenedor
            // 
            pnl_contenedor.BackColor = Color.LightSkyBlue;
            pnl_contenedor.Location = new Point(12, 12);
            pnl_contenedor.Name = "pnl_contenedor";
            pnl_contenedor.Size = new Size(897, 709);
            pnl_contenedor.TabIndex = 0;
            // 
            // btn_estados
            // 
            btn_estados.Location = new Point(930, 130);
            btn_estados.Name = "btn_estados";
            btn_estados.Size = new Size(219, 64);
            btn_estados.TabIndex = 1;
            btn_estados.Text = "System";
            btn_estados.UseVisualStyleBackColor = true;
            btn_estados.Click += btn_estados_Click;
            // 
            // btn_diseño
            // 
            btn_diseño.Location = new Point(930, 222);
            btn_diseño.Name = "btn_diseño";
            btn_diseño.Size = new Size(219, 64);
            btn_diseño.TabIndex = 2;
            btn_diseño.Text = "Transiciones";
            btn_diseño.UseVisualStyleBackColor = true;
            btn_diseño.Click += btn_diseño_Click;
            // 
            // button1
            // 
            button1.Location = new Point(930, 311);
            button1.Name = "button1";
            button1.Size = new Size(219, 64);
            button1.TabIndex = 3;
            button1.Text = "Entrada/Salida";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1176, 746);
            Controls.Add(button1);
            Controls.Add(btn_diseño);
            Controls.Add(btn_estados);
            Controls.Add(pnl_contenedor);
            Name = "Main";
            Text = "Sistema Termotanque";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_contenedor;
        private Button btn_estados;
        private Button btn_diseño;
        private Button button1;
    }
}