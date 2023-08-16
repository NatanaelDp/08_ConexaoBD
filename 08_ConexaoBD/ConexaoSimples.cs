using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConexaoBD
{
    internal class ConexaoSimples
    {
        //Informações de conexão com o banco
        string host = "localhost";
        string banco = "08_lista_tarefas";
        string usuario = "root";
        string senha = "senac";
        
        //Método construtor
        //automaticamente quando a classe é criada
        public ConexaoSimples()
        {
            //Usa os dados do banco para se conectar 
            string dadosConexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
            //cria a conexão com o banco usando os dados acima
            //O banco não se conecta sozinho, ele apenas cria  conexão
            MySqlConnection conexao= new MySqlConnection(dadosConexao);

            //Abre a conexão com o banco
            conexao.Open();

            //Linha de código do SQL
            string query = "SELECT*FROM tarefas;";
            //Envia um comando para o banco
            MySqlCommand comando = new MySqlCommand(query,conexao);
            //Guarda os dados que vieram no banco dentro de "dados"
            //MySqlDataReader recebe os dados em formato de tabela
            MySqlDataReader dados= comando.ExecuteReader();

            //Roda cada dado da tabela,até a última linha
            //A última linha vai ser FALSE e quebrar o loop
            while(dados.Read()==true)
            {
                Console.WriteLine("Descrição da tarefa: " + dados["descricao"]);
            }

            //Fecha a conexão com o banco
            conexao.Close();
        }

    }
}
