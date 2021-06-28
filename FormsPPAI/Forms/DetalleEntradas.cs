using Dashbord.DataAccessLayer;
using System.Windows.Forms;

namespace Dashbord {
	public partial class DetalleEntradas : Form {
		private string tipo_entrada;
		private string tipoVisita;
		private bool hayGuia;
		private int cantidad;

		public DetalleEntradas(string tipoEntrada, string tipoVisita, bool hayGuia, int cantidad) {
			InitializeComponent();

			tipo_entrada = tipoEntrada;
			this.tipoVisita = tipoVisita;
			this.hayGuia = hayGuia;
			this.cantidad = cantidad;
		}

		private void btnCloseForm_Click(object sender, System.EventArgs e) => Close();

		private void btnAceptar_Click(object sender, System.EventArgs e) {
			MessageBox.Show("Exito.");

			EntradasAdapter.UpdateEntradas(cantidad.ToString());
		}

		private void DetalleEntradas_Load(object sender, System.EventArgs e) {
			dtgDetalleEntradas.Rows.Add(cantidad, tipo_entrada, tipoVisita, hayGuia, PrecioAdapter.ReadPrecio(tipo_entrada, tipoVisita, hayGuia ? "true" : "false"));

			lblTotal.Text = $"Total {cantidad * PrecioAdapter.ReadPrecio(tipo_entrada, tipoVisita, hayGuia ? "true" : "false")}";
		}
	}
}
