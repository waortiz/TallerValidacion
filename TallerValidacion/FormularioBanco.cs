using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerValidacion.Clientes;

namespace TallerValidacion
{
    public partial class FormularioBanco : Form
    {
        ServicioBanco servicioBanco = new ServicioBanco();
        public FormularioBanco()
        {
            InitializeComponent();
        }

        private void btnObtenerCupo_Click(object sender, EventArgs e)
        {
            IOro clienteOro = new ClienteOro() { Cupo = 20000 };
            MessageBox.Show(servicioBanco.ObtenerCupo(clienteOro).ToString());

            Cliente cliente = new Cliente();
            MessageBox.Show(servicioBanco.ObtenerCupo(cliente).ToString());
        }
    }
}
