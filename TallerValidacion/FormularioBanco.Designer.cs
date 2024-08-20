namespace TallerValidacion
{
    partial class FormularioBanco
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
            this.btnObtenerCupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObtenerCupo
            // 
            this.btnObtenerCupo.Location = new System.Drawing.Point(350, 194);
            this.btnObtenerCupo.Name = "btnObtenerCupo";
            this.btnObtenerCupo.Size = new System.Drawing.Size(178, 42);
            this.btnObtenerCupo.TabIndex = 0;
            this.btnObtenerCupo.Text = "Obtener Cupo";
            this.btnObtenerCupo.UseVisualStyleBackColor = true;
            this.btnObtenerCupo.Click += new System.EventHandler(this.btnObtenerCupo_Click);
            // 
            // FormularioBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObtenerCupo);
            this.Name = "FormularioBanco";
            this.Text = "FormularioBanco";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnObtenerCupo;
    }
}