using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

        public DataTable Listar() 
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);               
        
        }

        public void Editar(MedicamentosDTO meddto)
        {
            string alterar = $"update {tabela} set medicamentos = '{meddto.Medicamento}', composicao = '{meddto.Composicao}' where id = '{meddto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(MedicamentosDTO meddto)
        {
            string excluir = $"delete from {tabela} where id = '{meddto.Id}';";
            conexao.ExecutarComando(excluir);
        }

    }
}
