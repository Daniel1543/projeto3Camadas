using System;
using System.Windows.Forms;

using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas.Ui
{
    public partial class Frm_Medicamentos : Form
    {
        
        MedicamentosBLL medbll = new MedicamentosBLL();
        MedicamentosDTO meddto = new MedicamentosDTO();

        public Frm_Medicamentos()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            meddto.Medicamento = txtMedicamentos.Text;
            meddto.Composicao = txtComposicao.Text;

            medbll.Inserir(meddto);

            MessageBox.Show("Cadastrado com sucesso!", "Medicamento",MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtComposicao.Clear();
            txtID.Clear();
            txtMedicamentos.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
