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
            meddto.Id = int.Parse(txtID.Text);
            meddto.Medicamento = txtMedicamentos.Text;
            meddto.Composicao = txtComposicao.Text;

            medbll.Editar(meddto);

            MessageBox.Show("Alterado com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtID.Clear();
            txtMedicamentos.Clear();
            txtComposicao.Clear();
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
            meddto.Id = int.Parse(txtID.Text);

            medbll.Excluir(meddto);

            MessageBox.Show("Excluido com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtID.Clear();
            txtMedicamentos.Clear();
            txtComposicao.Clear();
        }

        private void Frm_Medicamentos_Load(object sender, EventArgs e)
        {
            dgvMedicamentos.DataSource = medbll.Listar();
        }

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvMedicamentos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMedicamentos.Text = dgvMedicamentos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtComposicao.Text = dgvMedicamentos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
