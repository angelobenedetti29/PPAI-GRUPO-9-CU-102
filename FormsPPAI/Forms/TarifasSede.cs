using Dashbord.DataAccessLayer;
using System;
using System.Windows.Forms;

namespace Dashbord {
	public partial class TarifasSede : Form {
		public TarifasSede() => InitializeComponent();

		private void btnAceptar_Click(object sender, EventArgs e) => new ElegirTarifa().ShowDialog();

		private void TarifasSede_Load(object sender, EventArgs e) => dtgTarifaSede.DataSource = TarifaAdapter.ReadTarifasWithMontos();

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();
	}
}
