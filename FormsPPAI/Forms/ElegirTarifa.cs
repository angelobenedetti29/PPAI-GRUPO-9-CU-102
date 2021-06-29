using Dashbord.DataAccessLayer;
using Dashbord.Utilities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dashbord {
	public partial class ElegirTarifa : Form {
		private string username;

		public ElegirTarifa(string username) {
			InitializeComponent();

			this.username = username;
		}

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();

		private void ElegirTarifa_Load(object sender, EventArgs e) {
			lblCargo.Text = UsuarioAdapter.ReadCargo(username).Rows[0][0].ToString();

			try {
				Generics.LoadComboBox(cmbEntrada, "nombre", () => TiposEntradasAdapter.ReadTipoEntrada());
				Generics.LoadComboBox(cmbVisita, "nombre", () => TiposVisitasAdapter.ReadTiposVisitas());
			} catch (SqlException) {
				MessageBox.Show("Error con la base de datos.");
				Application.Exit();
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e) {
			if (cmbEntrada.SelectedIndex == -1 && cmbVisita.SelectedIndex == -1 && (rdoSi.Checked || rdoNo.Checked)) {
				MessageBox.Show("Insertar todos los datos.");
				return;
			}

			// TODO: preguntarle a la profe que hacer con este dato
			ObraAdapter.ReadTiempo();

			new ElegirEntradas(username, cmbEntrada.SelectedValue.ToString(), cmbVisita.SelectedValue.ToString(), rdoSi.Checked, TiempoAdapter.ReadDuracion()).ShowDialog();
		}
	}
}
