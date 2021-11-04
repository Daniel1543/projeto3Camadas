using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;

namespace Projeto3Camadas.Code.BLL
{
    class MedicamentosBLL
    {

        Conexao conexao = new Conexao();
        string tabela = "tbl_medicamentos";



        public void Inserir(MedicamentosDTO meddto)
        {
            string inserir = $"insert into {tabela} values (null, '{meddto.Medicamento}', '{meddto.Composicao}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(MedicamentosDTO meddto)
        {

        }

        public void Excluir(MedicamentosDTO meddto)
        {

        }

        public void listar()
        {

        }
    }
}
