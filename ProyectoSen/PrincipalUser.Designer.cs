namespace ProyectoSen
{
    partial class PrincipalUser
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
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTecnico = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.txtBuscarR = new System.Windows.Forms.TextBox();
            this.btnBuscarR = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClienteB = new System.Windows.Forms.Button();
            this.txtDni_C = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.Color.White;
            this.cmbBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "TECNICO",
            "CLIENTE"});
            this.cmbBuscar.Location = new System.Drawing.Point(119, 103);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(373, 31);
            this.cmbBuscar.TabIndex = 23;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.txtBuscar.Location = new System.Drawing.Point(644, 103);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(499, 32);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.Text = "Ingrese DNI";
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(939, 39);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(205, 36);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTecnico
            // 
            this.btnTecnico.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTecnico.FlatAppearance.BorderSize = 0;
            this.btnTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTecnico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnico.ForeColor = System.Drawing.Color.White;
            this.btnTecnico.Location = new System.Drawing.Point(119, 37);
            this.btnTecnico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTecnico.Name = "btnTecnico";
            this.btnTecnico.Size = new System.Drawing.Size(205, 38);
            this.btnTecnico.TabIndex = 26;
            this.btnTecnico.Text = "TECNICO";
            this.btnTecnico.UseVisualStyleBackColor = false;
            this.btnTecnico.Click += new System.EventHandler(this.btnTecnico_Click);
            // 
            // btnEquipo
            // 
            this.btnEquipo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEquipo.FlatAppearance.BorderSize = 0;
            this.btnEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipo.ForeColor = System.Drawing.Color.White;
            this.btnEquipo.Location = new System.Drawing.Point(392, 37);
            this.btnEquipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(207, 38);
            this.btnEquipo.TabIndex = 27;
            this.btnEquipo.Text = "EQUIPO";
            this.btnEquipo.UseVisualStyleBackColor = false;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Location = new System.Drawing.Point(673, 37);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(205, 37);
            this.btnCliente.TabIndex = 28;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrincipal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPrincipal.Location = new System.Drawing.Point(119, 155);
            this.dgvPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.Size = new System.Drawing.Size(900, 135);
            this.dgvPrincipal.TabIndex = 29;
            // 
            // txtBuscarR
            // 
            this.txtBuscarR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.txtBuscarR.Location = new System.Drawing.Point(44, 36);
            this.txtBuscarR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarR.Name = "txtBuscarR";
            this.txtBuscarR.Size = new System.Drawing.Size(417, 32);
            this.txtBuscarR.TabIndex = 31;
            this.txtBuscarR.Text = "Ingrese DNI Tecnico";
            this.txtBuscarR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarR.Enter += new System.EventHandler(this.txtBuscarR_Enter);
            this.txtBuscarR.Leave += new System.EventHandler(this.txtBuscarR_Leave);
            // 
            // btnBuscarR
            // 
            this.btnBuscarR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarR.FlatAppearance.BorderSize = 0;
            this.btnBuscarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarR.ForeColor = System.Drawing.Color.White;
            this.btnBuscarR.Location = new System.Drawing.Point(529, 36);
            this.btnBuscarR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarR.Name = "btnBuscarR";
            this.btnBuscarR.Size = new System.Drawing.Size(371, 33);
            this.btnBuscarR.TabIndex = 32;
            this.btnBuscarR.Text = "BUSCAR REPORTE";
            this.btnBuscarR.UseVisualStyleBackColor = false;
            this.btnBuscarR.Click += new System.EventHandler(this.btnBuscarR_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(119, 165);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.RowTemplate.Height = 24;
            this.dgvReporte.Size = new System.Drawing.Size(1025, 153);
            this.dgvReporte.TabIndex = 33;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(40, 46);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(261, 66);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.dgvPrincipal);
            this.groupBox1.Controls.Add(this.btnEquipo);
            this.groupBox1.Controls.Add(this.btnTecnico);
            this.groupBox1.Controls.Add(this.cmbBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(301, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1252, 315);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgvReporte);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(301, 480);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1252, 334);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REPORTE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClienteB);
            this.groupBox3.Controls.Add(this.txtDni_C);
            this.groupBox3.Controls.Add(this.txtBuscarR);
            this.groupBox3.Controls.Add(this.btnBuscarR);
            this.groupBox3.Location = new System.Drawing.Point(119, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(972, 137);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BUSQUEDAS";
            // 
            // btnClienteB
            // 
            this.btnClienteB.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClienteB.FlatAppearance.BorderSize = 0;
            this.btnClienteB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteB.ForeColor = System.Drawing.Color.White;
            this.btnClienteB.Location = new System.Drawing.Point(529, 85);
            this.btnClienteB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClienteB.Name = "btnClienteB";
            this.btnClienteB.Size = new System.Drawing.Size(371, 33);
            this.btnClienteB.TabIndex = 34;
            this.btnClienteB.Text = "BUSCAR CLIENTE";
            this.btnClienteB.UseVisualStyleBackColor = false;
            this.btnClienteB.Click += new System.EventHandler(this.btnClienteB_Click);
            // 
            // txtDni_C
            // 
            this.txtDni_C.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni_C.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtDni_C.Location = new System.Drawing.Point(44, 85);
            this.txtDni_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDni_C.Name = "txtDni_C";
            this.txtDni_C.Size = new System.Drawing.Size(417, 32);
            this.txtDni_C.TabIndex = 33;
            this.txtDni_C.Text = "Ingrese DNI Cliente";
            this.txtDni_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDni_C.Enter += new System.EventHandler(this.txtDni_C_Enter);
            this.txtDni_C.Leave += new System.EventHandler(this.txtDni_C_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(385, 46);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1168, 66);
            this.panel4.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(487, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "MODO USUARIO TAREA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrincipalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1560, 818);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrincipalUser";
            this.Text = "PrincipalUser";
            this.Load += new System.EventHandler(this.PrincipalUser_Load);
            this.DoubleClick += new System.EventHandler(this.PrincipalUser_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTecnico;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.TextBox txtBuscarR;
        private System.Windows.Forms.Button btnBuscarR;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDni_C;
        private System.Windows.Forms.Button btnClienteB;
    }
}