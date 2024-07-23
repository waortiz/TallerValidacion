namespace TallerValidacion
{
    partial class FormularioValidaciones
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
            this.components = new System.ComponentModel.Container();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnVerResultado = new System.Windows.Forms.Button();
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(179, 100);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(33, 15);
            this.lblNota.TabIndex = 0;
            this.lblNota.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(284, 105);
            this.txtNota.MaxLength = 3;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(185, 23);
            this.txtNota.TabIndex = 1;
            this.ttMensaje.SetToolTip(this.txtNota, "Por favor ingrese una nota entre 0 y 10");
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // btnVerResultado
            // 
            this.btnVerResultado.Location = new System.Drawing.Point(182, 150);
            this.btnVerResultado.Name = "btnVerResultado";
            this.btnVerResultado.Size = new System.Drawing.Size(287, 23);
            this.btnVerResultado.TabIndex = 2;
            this.btnVerResultado.Text = "Ver Resultado";
            this.btnVerResultado.UseVisualStyleBackColor = true;
            this.btnVerResultado.Click += new System.EventHandler(this.btnVerResultado_Click);
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(179, 242);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(290, 53);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormularioValidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerResultado);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Name = "FormularioValidaciones";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNota;
        private TextBox txtNota;
        private Button btnVerResultado;
        private ErrorProvider erpMensaje;
        private ToolTip ttMensaje;
        private Button btnCerrar;
    }
}