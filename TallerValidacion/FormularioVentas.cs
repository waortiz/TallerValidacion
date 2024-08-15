using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerValidacion.Ventas;

namespace TallerValidacion
{
    public partial class FormularioVentas : Form
    {
        public FormularioVentas()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Producto producto = null;
            if (rdbProductoNacional.Checked)
            {
                producto = new Nacional();
                producto.Codigo = "NAL01";
                producto.Descripcion = "Producto nacional 1";
                producto.Precio = 20000;
                ((Nacional)producto).Proveedor = "Proveedor 1";
            }
            else if (rdbProductoImportado.Checked)
            {
                producto = new Importado()
                {
                    Codigo = "IMP01",
                    Descripcion = "Producto Importado 1",
                    Precio = 30000,
                    Importador = "Tiendas ACME",
                    Procedencia = "CHINA"
                };
            }

            ServicioCompra servicioCompra = new ServicioCompra();
            var resultado = servicioCompra.Comprar(producto);
            MessageBox.Show(resultado ? "Compra exitosa" : "No fue posible la compra");
        }
    }
}
