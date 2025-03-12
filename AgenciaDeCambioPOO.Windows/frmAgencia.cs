using AgenciaDeCambioPOO.Datos;
using AgenciaDeCambioPOO.Entidades;
using AgenciaDeCambioPOO.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace AgenciaDeCambioPOO.Windows
{
    public partial class frmAgencia : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public frmAgencia(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

        }

        private void frmAgencia_Load(object sender, EventArgs e)
        {
            AgenciaDeCambio agencia = _serviceProvider.GetService<AgenciaDeCambio>()!;
            GridHelper.MostrarDatosEnGrilla<Moneda>(agencia.ObtenerMonedas(), dgvDivisas);

        }

        private void tsbNuevaDivisa_Click(object sender, EventArgs e)
        {
            frmDivisaAE frmDivisaAE = new frmDivisaAE();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarDivisa frmActualizarDivisa = new frmActualizarDivisa();
        }
    }
}
