namespace TallerValidacion
{
    public partial class FormularioValidaciones : Form
    {
        public FormularioValidaciones()
        {
            InitializeComponent();
        }

        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            //1. Validaciones
            try
            {
                erpMensaje.SetError(txtNota, null);
                if (string.IsNullOrEmpty(txtNota.Text))
                {
                    erpMensaje.SetError(txtNota, "La nota no es válida");
                    MessageBox.Show("La nota no es válida");
                    return;
                }
                Nota nota = new Nota();
                nota.Calificacion = double.Parse(txtNota.Text);
                if (nota.Calificacion < 0 || nota.Calificacion > 10)
                {
                    erpMensaje.SetError(txtNota, "La nota no es válida. Debe estar entre 0 y 10");
                    MessageBox.Show("La nota no es válida. Debe estar entre 0 y 10");
                    return;
                }
                   
                CalculoNota calculo = new CalculoNota();
                if (calculo.ValidarNota(nota))
                {
                    MessageBox.Show($"Felicitaciones. Haz ganado con una nota de {nota.Calificacion.ToString("###.#")}");
                }
                else
                {
                    MessageBox.Show($"Lo sentimos. Haz perdido con una nota de {nota.Calificacion.ToString("###.#")}");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("No fue posible hacer la evaluación");
            }

        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] caracteresValidos = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',' };
            if (!caracteresValidos.Contains(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cierra la ventana actual
            //this.Close();

            //Cierra la aplicación
            Application.Exit();
        }
    }
}