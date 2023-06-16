namespace ProyectoSen
{
    partial class ActualizarEstadoE_Admin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbEntrega = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstadoE = new System.Windows.Forms.ComboBox();
            this.btnBuscarEquipo = new System.Windows.Forms.Button();
            this.txtDefectoE = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 55);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRUPO PERUSIS SAC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1100, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "MODO ADMINISTRADOR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgvReporte);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(239, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 613);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado de Equipo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbEntrega);
            this.groupBox4.Location = new System.Drawing.Point(383, 79);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(379, 81);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ENTREGA";
            // 
            // cmbEntrega
            // 
            this.cmbEntrega.FormattingEnabled = true;
            this.cmbEntrega.Items.AddRange(new object[] {
            "ENTREGADO",
            "FALTA ENTREGAR"});
            this.cmbEntrega.Location = new System.Drawing.Point(12, 31);
            this.cmbEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEntrega.Name = "cmbEntrega";
            this.cmbEntrega.Size = new System.Drawing.Size(252, 31);
            this.cmbEntrega.TabIndex = 52;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEstado);
            this.groupBox3.Location = new System.Drawing.Point(20, 79);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(338, 81);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ESTADO EQUIPO";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(5, 29);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(305, 31);
            this.txtEstado.TabIndex = 27;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvReporte
            // 
            this.dgvReporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(40, 328);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.RowTemplate.Height = 24;
            this.dgvReporte.Size = new System.Drawing.Size(742, 254);
            this.dgvReporte.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEstadoE);
            this.groupBox1.Controls.Add(this.btnBuscarEquipo);
            this.groupBox1.Location = new System.Drawing.Point(20, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 75);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR ESTADO EQUIPO";
            // 
            // cmbEstadoE
            // 
            this.cmbEstadoE.FormattingEnabled = true;
            this.cmbEstadoE.Items.AddRange(new object[] {
            "NUEVO",
            "PROCESO",
            "FINALIZADO"});
            this.cmbEstadoE.Location = new System.Drawing.Point(20, 36);
            this.cmbEstadoE.Name = "cmbEstadoE";
            this.cmbEstadoE.Size = new System.Drawing.Size(328, 31);
            this.cmbEstadoE.TabIndex = 26;
            // 
            // btnBuscarEquipo
            // 
            this.btnBuscarEquipo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarEquipo.FlatAppearance.BorderSize = 0;
            this.btnBuscarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEquipo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEquipo.Location = new System.Drawing.Point(483, 29);
            this.btnBuscarEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEquipo.Name = "btnBuscarEquipo";
            this.btnBuscarEquipo.Size = new System.Drawing.Size(208, 40);
            this.btnBuscarEquipo.TabIndex = 25;
            this.btnBuscarEquipo.Text = "BUSCAR";
            this.btnBuscarEquipo.UseVisualStyleBackColor = false;
            this.btnBuscarEquipo.Click += new System.EventHandler(this.btnBuscarEquipo_Click);
            // 
            // txtDefectoE
            // 
            this.txtDefectoE.BackColor = System.Drawing.SystemColors.Control;
            this.txtDefectoE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDefectoE.ForeColor = System.Drawing.Color.White;
            this.txtDefectoE.Location = new System.Drawing.Point(37, 500);
            this.txtDefectoE.Margin = new System.Windows.Forms.Padding(2);
            this.txtDefectoE.Name = "txtDefectoE";
            this.txtDefectoE.ReadOnly = true;
            this.txtDefectoE.Size = new System.Drawing.Size(156, 13);
            this.txtDefectoE.TabIndex = 53;
            this.txtDefectoE.Text = "FALTA ENTREGAR";
            this.txtDefectoE.Visible = false;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Control;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Location = new System.Drawing.Point(12, 448);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(213, 13);
            this.txtId.TabIndex = 29;
            this.txtId.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 120);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(211, 54);
            this.btnVolver.TabIndex = 50;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(12, 226);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(211, 58);
            this.btnModificar.TabIndex = 51;
            this.btnModificar.Text = "ACTUALIZAR ESTADO";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEntrega
            // 
            this.btnEntrega.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEntrega.FlatAppearance.BorderSize = 0;
            this.btnEntrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrega.Location = new System.Drawing.Point(12, 337);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(211, 58);
            this.btnEntrega.TabIndex = 52;
            this.btnEntrega.Text = "ACTUALIZAR ENTREGA";
            this.btnEntrega.UseVisualStyleBackColor = false;
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
            // 
            // ActualizarEstadoE_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 725);
            this.Controls.Add(this.btnEntrega);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtDefectoE);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Name = "ActualizarEstadoE_Admin";
            this.Text = "ActualizarEstadoE_Admin";
            this.Load += new System.EventHandler(this.ActualizarEstadoE_Admin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEstadoE;
        private System.Windows.Forms.Button btnBuscarEquipo;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEntrega;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.TextBox txtDefectoE;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}