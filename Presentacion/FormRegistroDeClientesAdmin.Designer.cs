
namespace Presentacion
{
    partial class FormRegistroDeClientesAdmin
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
            this.btnBuscarDNI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscarPorPais = new System.Windows.Forms.Button();
            this.btnBuscarPorNombre = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBuscarDNI = new System.Windows.Forms.TextBox();
            this.tbBuscarPorPais = new System.Windows.Forms.TextBox();
            this.tbBuscarPorNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarDNI
            // 
            this.btnBuscarDNI.BackColor = System.Drawing.Color.LawnGreen;
            this.btnBuscarDNI.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBuscarDNI.FlatAppearance.BorderSize = 0;
            this.btnBuscarDNI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDNI.Location = new System.Drawing.Point(327, 341);
            this.btnBuscarDNI.Name = "btnBuscarDNI";
            this.btnBuscarDNI.Size = new System.Drawing.Size(143, 21);
            this.btnBuscarDNI.TabIndex = 21;
            this.btnBuscarDNI.Text = "Buscar por DNI";
            this.btnBuscarDNI.UseVisualStyleBackColor = false;
            this.btnBuscarDNI.Click += new System.EventHandler(this.btnBuscarDNI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Registro de Clientes";
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(81, 66);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(629, 230);
            this.dgClientes.TabIndex = 23;
            // 
            // btnBuscarPorPais
            // 
            this.btnBuscarPorPais.BackColor = System.Drawing.Color.LawnGreen;
            this.btnBuscarPorPais.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBuscarPorPais.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorPais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarPorPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorPais.Location = new System.Drawing.Point(327, 409);
            this.btnBuscarPorPais.Name = "btnBuscarPorPais";
            this.btnBuscarPorPais.Size = new System.Drawing.Size(143, 21);
            this.btnBuscarPorPais.TabIndex = 25;
            this.btnBuscarPorPais.Text = "Buscar por País";
            this.btnBuscarPorPais.UseVisualStyleBackColor = false;
            this.btnBuscarPorPais.Click += new System.EventHandler(this.btnBuscarPorPais_Click);
            // 
            // btnBuscarPorNombre
            // 
            this.btnBuscarPorNombre.BackColor = System.Drawing.Color.LawnGreen;
            this.btnBuscarPorNombre.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBuscarPorNombre.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarPorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorNombre.Location = new System.Drawing.Point(327, 375);
            this.btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            this.btnBuscarPorNombre.Size = new System.Drawing.Size(143, 21);
            this.btnBuscarPorNombre.TabIndex = 26;
            this.btnBuscarPorNombre.Text = "Buscar por Nombre";
            this.btnBuscarPorNombre.UseVisualStyleBackColor = false;
            this.btnBuscarPorNombre.Click += new System.EventHandler(this.btnBuscarPorNombre_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(648, 371);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(62, 25);
            this.btnRegresar.TabIndex = 28;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Buscar por DNI:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(571, 371);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 25);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Buscar por País:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Buscar por Nombre:";
            // 
            // tbBuscarDNI
            // 
            this.tbBuscarDNI.Location = new System.Drawing.Point(179, 342);
            this.tbBuscarDNI.Name = "tbBuscarDNI";
            this.tbBuscarDNI.Size = new System.Drawing.Size(125, 20);
            this.tbBuscarDNI.TabIndex = 33;
            // 
            // tbBuscarPorPais
            // 
            this.tbBuscarPorPais.Location = new System.Drawing.Point(179, 410);
            this.tbBuscarPorPais.Name = "tbBuscarPorPais";
            this.tbBuscarPorPais.Size = new System.Drawing.Size(125, 20);
            this.tbBuscarPorPais.TabIndex = 34;
            // 
            // tbBuscarPorNombre
            // 
            this.tbBuscarPorNombre.Location = new System.Drawing.Point(179, 376);
            this.tbBuscarPorNombre.Name = "tbBuscarPorNombre";
            this.tbBuscarPorNombre.Size = new System.Drawing.Size(125, 20);
            this.tbBuscarPorNombre.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox1.Location = new System.Drawing.Point(65, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 256);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.brick_549148_1280;
            this.pictureBox3.Location = new System.Drawing.Point(0, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 455);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // FormRegistroDeClientesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbBuscarPorNombre);
            this.Controls.Add(this.tbBuscarPorPais);
            this.Controls.Add(this.tbBuscarDNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBuscarPorNombre);
            this.Controls.Add(this.btnBuscarPorPais);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnBuscarDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormRegistroDeClientesAdmin";
            this.Text = "FormRegistroDeClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarPorPais;
        private System.Windows.Forms.Button btnBuscarPorNombre;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBuscarDNI;
        private System.Windows.Forms.TextBox tbBuscarPorPais;
        private System.Windows.Forms.TextBox tbBuscarPorNombre;
    }
}