namespace MySQLConexion
{
    partial class Form1
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
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnConectar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtHost = new TextBox();
            txtBasededatos = new TextBox();
            txtPuerto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(116, 64);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(240, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(116, 108);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(240, 23);
            txtContrasena.TabIndex = 1;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(175, 281);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 67);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 108);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(116, 150);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(240, 23);
            txtHost.TabIndex = 5;
            // 
            // txtBasededatos
            // 
            txtBasededatos.Location = new Point(116, 192);
            txtBasededatos.Name = "txtBasededatos";
            txtBasededatos.Size = new Size(240, 23);
            txtBasededatos.TabIndex = 6;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(116, 231);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(240, 23);
            txtPuerto.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 153);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 8;
            label3.Text = "Host";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 195);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 9;
            label4.Text = "Base de datos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 234);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 10;
            label5.Text = "Puerto";
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(395, 64);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(608, 320);
            dgvDatos.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 429);
            Controls.Add(dgvDatos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPuerto);
            Controls.Add(txtBasededatos);
            Controls.Add(txtHost);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConectar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnConectar;
        private Label label1;
        private Label label2;
        private TextBox txtHost;
        private TextBox txtBasededatos;
        private TextBox txtPuerto;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvDatos;
    }
}