using System;
using System.Windows.Forms;
using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;
using System.Net;
using System.Net.Mail;

namespace Projeto3Camadas.Ui
{
    public partial class Frm_Login : Form
    {

        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                Frm_Medicamentos frm_Medicamentos = new Frm_Medicamentos();
                frm_Medicamentos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique seu e-mail e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkLabEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("11900342@aluno.cotemig.com.br", "sxatttudhfwuiguw"),
                EnableSsl = true
            };

            loginDTO.Email = txtEmail.Text;
            string senha = loginBLL.RetornarSenha(loginDTO);

            client.Send("11900342@aluno.cotemig.com.br", $"{txtEmail.Text}", "Redefinição de Senha", $"Seu e-mail é {txtEmail.Text} com senha {senha}");

            MessageBox.Show("E-mail e senha enviados com sucesso.", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
