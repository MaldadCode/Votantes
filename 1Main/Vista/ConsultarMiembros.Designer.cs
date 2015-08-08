namespace _1Main.Vista
{
    partial class ConsultarMiembros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarMiembros));
            this.gbFiltrarPor = new System.Windows.Forms.GroupBox();
            this.rbNombresYApellidos = new System.Windows.Forms.RadioButton();
            this.rbApellidos = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.panelCedula = new System.Windows.Forms.Panel();
            this.panelCedulabBuscar = new System.Windows.Forms.Button();
            this.panelCedulamTbCedula = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelApellidos = new System.Windows.Forms.Panel();
            this.panelApellidosbBuscar = new System.Windows.Forms.Button();
            this.panelApellidostbPrimerApellido = new System.Windows.Forms.TextBox();
            this.panelApellidostbSegundoApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelNombresYApellidos = new System.Windows.Forms.Panel();
            this.panelNombreYApellidosbBuscar = new System.Windows.Forms.Button();
            this.panelNombreYApellidostbSegundoApellido = new System.Windows.Forms.TextBox();
            this.panelNombreYApellidostbSegundoNombre = new System.Windows.Forms.TextBox();
            this.panelNombreYApellidostbApellido = new System.Windows.Forms.TextBox();
            this.panelNombresYApellidostbPrimerNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbInfomTbCedula = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbFiltrarPor.SuspendLayout();
            this.panelCedula.SuspendLayout();
            this.panelApellidos.SuspendLayout();
            this.panelNombresYApellidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltrarPor
            // 
            this.gbFiltrarPor.Controls.Add(this.rbNombresYApellidos);
            this.gbFiltrarPor.Controls.Add(this.rbApellidos);
            this.gbFiltrarPor.Controls.Add(this.rbCedula);
            this.gbFiltrarPor.Location = new System.Drawing.Point(10, 10);
            this.gbFiltrarPor.Name = "gbFiltrarPor";
            this.gbFiltrarPor.Size = new System.Drawing.Size(144, 90);
            this.gbFiltrarPor.TabIndex = 0;
            this.gbFiltrarPor.TabStop = false;
            this.gbFiltrarPor.Text = "Filtrar Por:";
            // 
            // rbNombresYApellidos
            // 
            this.rbNombresYApellidos.AutoSize = true;
            this.rbNombresYApellidos.Location = new System.Drawing.Point(6, 65);
            this.rbNombresYApellidos.Name = "rbNombresYApellidos";
            this.rbNombresYApellidos.Size = new System.Drawing.Size(132, 17);
            this.rbNombresYApellidos.TabIndex = 2;
            this.rbNombresYApellidos.TabStop = true;
            this.rbNombresYApellidos.Text = "Nombre(s) y Apellido(s)";
            this.rbNombresYApellidos.UseVisualStyleBackColor = true;
            this.rbNombresYApellidos.CheckedChanged += new System.EventHandler(this.rbNombresYApellidos_CheckedChanged);
            // 
            // rbApellidos
            // 
            this.rbApellidos.AutoSize = true;
            this.rbApellidos.Location = new System.Drawing.Point(6, 42);
            this.rbApellidos.Name = "rbApellidos";
            this.rbApellidos.Size = new System.Drawing.Size(67, 17);
            this.rbApellidos.TabIndex = 1;
            this.rbApellidos.TabStop = true;
            this.rbApellidos.Text = "Apellidos";
            this.rbApellidos.UseVisualStyleBackColor = true;
            this.rbApellidos.CheckedChanged += new System.EventHandler(this.rbApellidos_CheckedChanged);
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Location = new System.Drawing.Point(6, 19);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(58, 17);
            this.rbCedula.TabIndex = 0;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Cedula";
            this.rbCedula.UseVisualStyleBackColor = true;
            this.rbCedula.CheckedChanged += new System.EventHandler(this.rbCedula_CheckedChanged);
            // 
            // panelCedula
            // 
            this.panelCedula.Controls.Add(this.panelCedulabBuscar);
            this.panelCedula.Controls.Add(this.panelCedulamTbCedula);
            this.panelCedula.Controls.Add(this.label1);
            this.panelCedula.Location = new System.Drawing.Point(164, 16);
            this.panelCedula.Name = "panelCedula";
            this.panelCedula.Size = new System.Drawing.Size(635, 84);
            this.panelCedula.TabIndex = 1;
            this.panelCedula.Visible = false;
            // 
            // panelCedulabBuscar
            // 
            this.panelCedulabBuscar.Location = new System.Drawing.Point(190, 10);
            this.panelCedulabBuscar.Name = "panelCedulabBuscar";
            this.panelCedulabBuscar.Size = new System.Drawing.Size(75, 23);
            this.panelCedulabBuscar.TabIndex = 2;
            this.panelCedulabBuscar.Text = "Buscar";
            this.panelCedulabBuscar.UseVisualStyleBackColor = true;
            this.panelCedulabBuscar.Click += new System.EventHandler(this.panelCedulabBuscar_Click);
            // 
            // panelCedulamTbCedula
            // 
            this.panelCedulamTbCedula.Location = new System.Drawing.Point(104, 12);
            this.panelCedulamTbCedula.Mask = "000-0000000-0";
            this.panelCedulamTbCedula.Name = "panelCedulamTbCedula";
            this.panelCedulamTbCedula.ResetOnSpace = false;
            this.panelCedulamTbCedula.Size = new System.Drawing.Size(80, 20);
            this.panelCedulamTbCedula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula*";
            // 
            // panelApellidos
            // 
            this.panelApellidos.Controls.Add(this.panelApellidosbBuscar);
            this.panelApellidos.Controls.Add(this.panelApellidostbPrimerApellido);
            this.panelApellidos.Controls.Add(this.panelApellidostbSegundoApellido);
            this.panelApellidos.Controls.Add(this.label7);
            this.panelApellidos.Controls.Add(this.label6);
            this.panelApellidos.Location = new System.Drawing.Point(164, 16);
            this.panelApellidos.Name = "panelApellidos";
            this.panelApellidos.Size = new System.Drawing.Size(635, 84);
            this.panelApellidos.TabIndex = 2;
            this.panelApellidos.Visible = false;
            // 
            // panelApellidosbBuscar
            // 
            this.panelApellidosbBuscar.Location = new System.Drawing.Point(280, 10);
            this.panelApellidosbBuscar.Name = "panelApellidosbBuscar";
            this.panelApellidosbBuscar.Size = new System.Drawing.Size(75, 23);
            this.panelApellidosbBuscar.TabIndex = 4;
            this.panelApellidosbBuscar.Text = "Buscar";
            this.panelApellidosbBuscar.UseVisualStyleBackColor = true;
            this.panelApellidosbBuscar.Click += new System.EventHandler(this.panelApellidosbBuscar_Click);
            // 
            // panelApellidostbPrimerApellido
            // 
            this.panelApellidostbPrimerApellido.Location = new System.Drawing.Point(104, 12);
            this.panelApellidostbPrimerApellido.Name = "panelApellidostbPrimerApellido";
            this.panelApellidostbPrimerApellido.Size = new System.Drawing.Size(170, 20);
            this.panelApellidostbPrimerApellido.TabIndex = 3;
            // 
            // panelApellidostbSegundoApellido
            // 
            this.panelApellidostbSegundoApellido.Location = new System.Drawing.Point(104, 38);
            this.panelApellidostbSegundoApellido.Name = "panelApellidostbSegundoApellido";
            this.panelApellidostbSegundoApellido.Size = new System.Drawing.Size(170, 20);
            this.panelApellidostbSegundoApellido.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Segundo Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Primer Apellido*";
            // 
            // panelNombresYApellidos
            // 
            this.panelNombresYApellidos.Controls.Add(this.panelNombreYApellidosbBuscar);
            this.panelNombresYApellidos.Controls.Add(this.panelNombreYApellidostbSegundoApellido);
            this.panelNombresYApellidos.Controls.Add(this.panelNombreYApellidostbSegundoNombre);
            this.panelNombresYApellidos.Controls.Add(this.panelNombreYApellidostbApellido);
            this.panelNombresYApellidos.Controls.Add(this.panelNombresYApellidostbPrimerNombre);
            this.panelNombresYApellidos.Controls.Add(this.label5);
            this.panelNombresYApellidos.Controls.Add(this.label4);
            this.panelNombresYApellidos.Controls.Add(this.label3);
            this.panelNombresYApellidos.Controls.Add(this.label2);
            this.panelNombresYApellidos.Location = new System.Drawing.Point(164, 16);
            this.panelNombresYApellidos.Name = "panelNombresYApellidos";
            this.panelNombresYApellidos.Size = new System.Drawing.Size(635, 84);
            this.panelNombresYApellidos.TabIndex = 2;
            this.panelNombresYApellidos.Visible = false;
            // 
            // panelNombreYApellidosbBuscar
            // 
            this.panelNombreYApellidosbBuscar.Location = new System.Drawing.Point(552, 10);
            this.panelNombreYApellidosbBuscar.Name = "panelNombreYApellidosbBuscar";
            this.panelNombreYApellidosbBuscar.Size = new System.Drawing.Size(75, 23);
            this.panelNombreYApellidosbBuscar.TabIndex = 16;
            this.panelNombreYApellidosbBuscar.Text = "Buscar";
            this.panelNombreYApellidosbBuscar.UseVisualStyleBackColor = true;
            this.panelNombreYApellidosbBuscar.Click += new System.EventHandler(this.panelNombreYApellidosbBuscar_Click);
            // 
            // panelNombreYApellidostbSegundoApellido
            // 
            this.panelNombreYApellidostbSegundoApellido.Location = new System.Drawing.Point(376, 38);
            this.panelNombreYApellidostbSegundoApellido.Name = "panelNombreYApellidostbSegundoApellido";
            this.panelNombreYApellidostbSegundoApellido.Size = new System.Drawing.Size(170, 20);
            this.panelNombreYApellidostbSegundoApellido.TabIndex = 15;
            // 
            // panelNombreYApellidostbSegundoNombre
            // 
            this.panelNombreYApellidostbSegundoNombre.Location = new System.Drawing.Point(376, 12);
            this.panelNombreYApellidostbSegundoNombre.Name = "panelNombreYApellidostbSegundoNombre";
            this.panelNombreYApellidostbSegundoNombre.Size = new System.Drawing.Size(170, 20);
            this.panelNombreYApellidostbSegundoNombre.TabIndex = 14;
            // 
            // panelNombreYApellidostbApellido
            // 
            this.panelNombreYApellidostbApellido.Location = new System.Drawing.Point(104, 38);
            this.panelNombreYApellidostbApellido.Name = "panelNombreYApellidostbApellido";
            this.panelNombreYApellidostbApellido.Size = new System.Drawing.Size(170, 20);
            this.panelNombreYApellidostbApellido.TabIndex = 13;
            // 
            // panelNombresYApellidostbPrimerNombre
            // 
            this.panelNombresYApellidostbPrimerNombre.Location = new System.Drawing.Point(104, 12);
            this.panelNombresYApellidostbPrimerNombre.Name = "panelNombresYApellidostbPrimerNombre";
            this.panelNombresYApellidostbPrimerNombre.Size = new System.Drawing.Size(170, 20);
            this.panelNombresYApellidostbPrimerNombre.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Segundo Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Primer Nombre*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.gbInfomTbCedula);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Location = new System.Drawing.Point(10, 262);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(791, 208);
            this.gbInfo.TabIndex = 4;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cedula";
            // 
            // gbInfomTbCedula
            // 
            this.gbInfomTbCedula.Location = new System.Drawing.Point(52, 16);
            this.gbInfomTbCedula.Mask = "000-0000000-0";
            this.gbInfomTbCedula.Name = "gbInfomTbCedula";
            this.gbInfomTbCedula.ResetOnSpace = false;
            this.gbInfomTbCedula.Size = new System.Drawing.Size(80, 20);
            this.gbInfomTbCedula.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre";
            // 
            // ConsultarMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 480);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelApellidos);
            this.Controls.Add(this.panelNombresYApellidos);
            this.Controls.Add(this.panelCedula);
            this.Controls.Add(this.gbFiltrarPor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarMiembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarMiembros";
            this.gbFiltrarPor.ResumeLayout(false);
            this.gbFiltrarPor.PerformLayout();
            this.panelCedula.ResumeLayout(false);
            this.panelCedula.PerformLayout();
            this.panelApellidos.ResumeLayout(false);
            this.panelApellidos.PerformLayout();
            this.panelNombresYApellidos.ResumeLayout(false);
            this.panelNombresYApellidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltrarPor;
        private System.Windows.Forms.RadioButton rbNombresYApellidos;
        private System.Windows.Forms.RadioButton rbApellidos;
        private System.Windows.Forms.RadioButton rbCedula;
        private System.Windows.Forms.Panel panelCedula;
        private System.Windows.Forms.Panel panelApellidos;
        private System.Windows.Forms.Panel panelNombresYApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox panelCedulamTbCedula;
        private System.Windows.Forms.TextBox panelNombreYApellidostbSegundoApellido;
        private System.Windows.Forms.TextBox panelNombreYApellidostbSegundoNombre;
        private System.Windows.Forms.TextBox panelNombreYApellidostbApellido;
        private System.Windows.Forms.TextBox panelNombresYApellidostbPrimerNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button panelCedulabBuscar;
        private System.Windows.Forms.Button panelNombreYApellidosbBuscar;
        private System.Windows.Forms.TextBox panelApellidostbPrimerApellido;
        private System.Windows.Forms.TextBox panelApellidostbSegundoApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button panelApellidosbBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.MaskedTextBox gbInfomTbCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}