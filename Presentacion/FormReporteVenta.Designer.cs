
namespace Presentacion
{
    partial class FormReporteVenta
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
            this.dgReporteVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.btnVentaFecha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMayorMonto = new System.Windows.Forms.Button();
            this.btnMenorMonto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteVentas)).BeginInit();
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
            this.btnSalir.Location = new System.Drawing.Point(84, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(190, 25);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgReporteVentas
            // 
            this.dgReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteVentas.Location = new System.Drawing.Point(418, 66);
            this.dgReporteVentas.Name = "dgReporteVentas";
            this.dgReporteVentas.Size = new System.Drawing.Size(341, 343);
            this.dgReporteVentas.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Reporte de Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fecha Fin:";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(155, 249);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 46;
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(155, 298);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 20);
            this.dtFin.TabIndex = 47;
            // 
            // btnVentaFecha
            // 
            this.btnVentaFecha.BackColor = System.Drawing.Color.LawnGreen;
            this.btnVentaFecha.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVentaFecha.FlatAppearance.BorderSize = 0;
            this.btnVentaFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaFecha.Location = new System.Drawing.Point(55, 335);
            this.btnVentaFecha.Name = "btnVentaFecha";
            this.btnVentaFecha.Size = new System.Drawing.Size(235, 46);
            this.btnVentaFecha.TabIndex = 48;
            this.btnVentaFecha.Text = "Buscar Ventas Por Rango de fecha especifico";
            this.btnVentaFecha.UseVisualStyleBackColor = false;
            this.btnVentaFecha.Click += new System.EventHandler(this.btnVentaFecha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox1.Location = new System.Drawing.Point(402, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 369);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.brick_549148_1280;
            this.pictureBox3.Location = new System.Drawing.Point(0, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 455);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // btnMayorMonto
            // 
            this.btnMayorMonto.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMayorMonto.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnMayorMonto.FlatAppearance.BorderSize = 0;
            this.btnMayorMonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMayorMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayorMonto.Location = new System.Drawing.Point(55, 77);
            this.btnMayorMonto.Name = "btnMayorMonto";
            this.btnMayorMonto.Size = new System.Drawing.Size(235, 46);
            this.btnMayorMonto.TabIndex = 49;
            this.btnMayorMonto.Text = "Mostrar Ventas Con Mayor Monto Total de Venta";
            this.btnMayorMonto.UseVisualStyleBackColor = false;
            this.btnMayorMonto.Click += new System.EventHandler(this.btnMayorMonto_Click);
            // 
            // btnMenorMonto
            // 
            this.btnMenorMonto.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMenorMonto.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnMenorMonto.FlatAppearance.BorderSize = 0;
            this.btnMenorMonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenorMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorMonto.Location = new System.Drawing.Point(55, 156);
            this.btnMenorMonto.Name = "btnMenorMonto";
            this.btnMenorMonto.Size = new System.Drawing.Size(235, 46);
            this.btnMenorMonto.TabIndex = 50;
            this.btnMenorMonto.Text = "Mostrar Ventas Con Menor Monto Total de Venta";
            this.btnMenorMonto.UseVisualStyleBackColor = false;
            this.btnMenorMonto.Click += new System.EventHandler(this.btnMenorMonto_Click);
            // 
            // FormReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenorMonto);
            this.Controls.Add(this.btnMayorMonto);
            this.Controls.Add(this.btnVentaFecha);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgReporteVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormReporteVenta";
            this.Text = "FormReporteVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgReporteVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Button btnVentaFecha;
        private System.Windows.Forms.Button btnMayorMonto;
        private System.Windows.Forms.Button btnMenorMonto;
    }
}