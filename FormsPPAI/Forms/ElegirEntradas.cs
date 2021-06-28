using Dashbord.DataAccessLayer;
using System;
using System.Windows.Forms;

namespace Dashbord {
	public partial class ElegirEntradas : Form {
		private string tipoEntrada;
		private string tipoVisita;
		private bool hayGuia;
		private int tiempo;

		public ElegirEntradas(string tipoEntrada, string tipoVisita, bool hayGuia, int tiempo) {
			InitializeComponent();

			this.tipoEntrada = tipoEntrada;
			this.tipoVisita = tipoVisita;
			this.hayGuia = hayGuia;
			this.tiempo = tiempo;
		}

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();

		private void btnAceptar_Click(object sender, EventArgs e) {
			if (txtNroEntradas.Text.Equals("")) {
				MessageBox.Show("Insertar datos.");
				return;
			}

			if (int.Parse(txtNroEntradas.Text.Trim()) > (SedeAdapter.ReadMaxEntradas() - EntradasAdapter.ReadEntradas())) {
				MessageBox.Show("Numero de entradas maximo superado.");
				return;
			}

			new DetalleEntradas(tipoEntrada, tipoVisita, hayGuia, int.Parse(txtNroEntradas.Text.Trim())).ShowDialog();
		}
	}
}
