
namespace Presentacion
{
    partial class FormReporteProducto
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
            this.dgReporteProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMenorStock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscarPorCategoria = new System.Windows.Forms.Button();
            this.btnListarPorCostoMayor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteProducto)).BeginInit();
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
            // dgReporteProducto
            // 
            this.dgReporteProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReporteProducto.Location = new System.Drawing.Point(418, 66);
            this.dgReporteProducto.Name = "dgReporteProducto";
            this.dgReporteProducto.Size = new System.Drawing.Size(341, 343);
            this.dgReporteProducto.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Reporte de Productos";
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
            // btnMenorStock
            // 
            this.btnMenorStock.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMenorStock.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnMenorStock.FlatAppearance.BorderSize = 0;
            this.btnMenorStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenorStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorStock.Location = new System.Drawing.Point(79, 183);
            this.btnMenorStock.Name = "btnMenorStock";
            this.btnMenorStock.Size = new System.Drawing.Size(190, 57);
            this.btnMenorStock.TabIndex = 52;
            this.btnMenorStock.Text = "Mostrar producto con Menor stock";
            this.btnMenorStock.UseVisualStyleBackColor = false;
            this.btnMenorStock.Click += new System.EventHandler(this.btnMenorStock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Seleccione Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Verano",
            "Invierno",
            "Primavera",
            "Otoño"});
            this.cbCategoria.Location = new System.Drawing.Point(148, 66);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 54;
            // 
            // btnBuscarPorCategoria
            // 
            this.btnBuscarPorCategoria.BackColor = System.Drawing.Color.LawnGreen;
            this.btnBuscarPorCategoria.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBuscarPorCategoria.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarPorCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorCategoria.Location = new System.Drawing.Point(79, 93);
            this.btnBuscarPorCategoria.Name = "btnBuscarPorCategoria";
            this.btnBuscarPorCategoria.Size = new System.Drawing.Size(190, 54);
            this.btnBuscarPorCategoria.TabIndex = 53;
            this.btnBuscarPorCategoria.Text = "Buscar por Categoria";
            this.btnBuscarPorCategoria.UseVisualStyleBackColor = false;
            this.btnBuscarPorCategoria.Click += new System.EventHandler(this.btnBuscarPorCategoria_Click);
            // 
            // btnListarPorCostoMayor
            // 
            this.btnListarPorCostoMayor.BackColor = System.Drawing.Color.LawnGreen;
            this.btnListarPorCostoMayor.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnListarPorCostoMayor.FlatAppearance.BorderSize = 0;
            this.btnListarPorCostoMayor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarPorCostoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPorCostoMayor.Location = new System.Drawing.Point(79, 280);
            this.btnListarPorCostoMayor.Name = "btnListarPorCostoMayor";
            this.btnListarPorCostoMayor.Size = new System.Drawing.Size(190, 57);
            this.btnListarPorCostoMayor.TabIndex = 56;
            this.btnListarPorCostoMayor.Text = "Listar Por Costo Mayor";
            this.btnListarPorCostoMayor.UseVisualStyleBackColor = false;
            this.btnListarPorCostoMayor.Click += new System.EventHandler(this.btnListarPorCostoMayor_Click);
            // 
            // FormReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarPorCostoMayor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnBuscarPorCategoria);
            this.Controls.Add(this.btnMenorStock);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgReporteProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormReporteProducto";
            this.Text = "FormReporteProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgReporteProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgReporteProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnMenorStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnBuscarPorCategoria;
        private System.Windows.Forms.Button btnListarPorCostoMayor;
    }
}