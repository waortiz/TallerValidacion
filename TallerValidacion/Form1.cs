namespace TallerValidacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            //1. Validaciones
            try
            {
                erpMensaje.SetError(txtNota, null);
                var nota = txtNota.Text;

                if (string.IsNullOrEmpty(nota))
                {
                    erpMensaje.SetError(txtNota, "La nota no es válida");
                    MessageBox.Show("La nota no es válida");
                    return;
                }
            }
            catch(Exception exc)
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
    }
}