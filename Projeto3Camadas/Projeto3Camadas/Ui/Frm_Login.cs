﻿using System;
using System.Windows.Forms;
using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

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
                MessageBox.Show("Verifique seu e-mail e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            }
        }
    }
}
