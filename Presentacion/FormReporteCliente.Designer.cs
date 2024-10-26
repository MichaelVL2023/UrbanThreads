
namespace Presentacion
{
    partial class FormReporteCliente
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgReporteClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClienteVenta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBuscarPorSexo = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenorClienteVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(79, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(190, 25);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgReporteClientes
            // 
            this.dgReporteClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteClientes.Location = new System.Drawing.Point(418, 66);
            this.dgReporteClientes.Name = "dgReporteClientes";
            this.dgReporteClientes.Size = new System.Drawing.Size(341, 343);
            this.dgReporteClientes.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Reporte de Clientes";
            // 
            // btnClienteVenta
            // 
            this.btnClienteVenta.BackColor = System.Drawing.Color.LawnGreen;
            this.btnClienteVenta.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClienteVenta.FlatAppearance.BorderSize = 0;
            this.btnClienteVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteVenta.Location = new System.Drawing.Point(79, 156);
            this.btnClienteVenta.Name = "btnClienteVenta";
            this.btnClienteVenta.Size = new System.Drawing.Size(219, 41);
            this.btnClienteVenta.TabIndex = 49;
            this.btnClienteVenta.Text = "Clientes Por Mayor numero de transacciones";
            this.btnClienteVenta.UseVisualStyleBackColor = false;
            this.btnClienteVenta.Click += new System.EventHandler(this.btnClienteVenta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox1.Location = new System.Drawing.Point(402, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 369);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.brick_549148_1280;
            this.pictureBox3.Location = new System.Drawing.Point(0, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 455);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // btnBuscarPorSexo
            // 
            this.btnBuscarPorSexo.BackColor = System.Drawing.Color.LawnGreen;
            this.btnBuscarPorSexo.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBuscarPorSexo.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarPorSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorSexo.Location = new System.Drawing.Point(79, 86);
            this.btnBuscarPorSexo.Name = "btnBuscarPorSexo";
            this.btnBuscarPorSexo.Size = new System.Drawing.Size(219, 40);
            this.btnBuscarPorSexo.TabIndex = 50;
            this.btnBuscarPorSexo.Text = "Buscar por Sexo";
            this.btnBuscarPorSexo.UseVisualStyleBackColor = false;
            this.btnBuscarPorSexo.Click += new System.EventHandler(this.btnBuscarPorSexo_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(148, 59);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(150, 21);
            this.cbSexo.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Seleccione sexo:";
            // 
            // btnMenorClienteVentas
            // 
            this.btnMenorClienteVentas.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMenorClienteVentas.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnMenorClienteVentas.FlatAppearance.BorderSize = 0;
            this.btnMenorClienteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenorClienteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorClienteVentas.Location = new System.Drawing.Point(79, 225);
            this.btnMenorClienteVentas.Name = "btnMenorClienteVentas";
            this.btnMenorClienteVentas.Size = new System.Drawing.Size(219, 41);
            this.btnMenorClienteVentas.TabIndex = 53;
            this.btnMenorClienteVentas.Text = "Clientes Por Menor numero de transacciones";
            this.btnMenorClienteVentas.UseVisualStyleBackColor = false;
            this.btnMenorClienteVentas.Click += new System.EventHandler(this.btnMenorClienteVentas_Click);
            // 
            // FormReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenorClienteVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btnBuscarPorSexo);
            this.Controls.Add(this.btnClienteVenta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgReporteClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormReporteCliente";
            this.Text = "FormReporteCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgReporteClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnClienteVenta;
        private System.Windows.Forms.Button btnBuscarPorSexo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenorClienteVentas;
    }
}