namespace TallerValidacion
{
    partial class FormularioVentas
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.rdbProductoNacional = new System.Windows.Forms.RadioButton();
            this.rdbProductoImportado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(258, 193);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(203, 56);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // rdbProductoNacional
            // 
            this.rdbProductoNacional.AutoSize = true;
            this.rdbProductoNacional.Location = new System.Drawing.Point(228, 81);
            this.rdbProductoNacional.Name = "rdbProductoNacional";
            this.rdbProductoNacional.Size = new System.Drawing.Size(124, 19);
            this.rdbProductoNacional.TabIndex = 1;
            this.rdbProductoNacional.TabStop = true;
            this.rdbProductoNacional.Text = "Producto Nacional";
            this.rdbProductoNacional.UseVisualStyleBackColor = true;
            // 
            // rdbProductoImportado
            // 
            this.rdbProductoImportado.AutoSize = true;
            this.rdbProductoImportado.Location = new System.Drawing.Point(228, 128);
            this.rdbProductoImportado.Name = "rdbProductoImportado";
            this.rdbProductoImportado.Size = new System.Drawing.Size(133, 19);
            this.rdbProductoImportado.TabIndex = 2;
            this.rdbProductoImportado.TabStop = true;
            this.rdbProductoImportado.Text = "Producto Importado";
            this.rdbProductoImportado.UseVisualStyleBackColor = true;
            // 
            // FormularioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbProductoImportado);
            this.Controls.Add(this.rdbProductoNacional);
            this.Controls.Add(this.btnComprar);
            this.Name = "FormularioVentas";
            this.Text = "FormularioVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnComprar;
        private RadioButton rdbProductoNacional;
        private RadioButton rdbProductoImportado;
    }
}