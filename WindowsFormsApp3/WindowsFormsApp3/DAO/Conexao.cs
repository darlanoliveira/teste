// adicionando a biblioteca de conexão.
using MySql.Data.MySqlClient;
//*******************************//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.DAO
{
    public class Conexao
    {
        private MySqlConnection connection; //Importante
        private String server;
        private String database;
        private String uid;
        private String password;

        //Construtor
        public Conexao()
        {
            Inicializar();
        }

        //Inicia valores
        private void Inicializar()
        {
            server = "localhost"; // string do local onde se encontra o bd
            database = "teste"; // nome da bd
            uid = "root"; // usuario da bd
            password = ""; // password da bd

            string stringDeConexao; // string de conexão
            stringDeConexao = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" +
                password + ";";

            connection = new MySqlConnection(stringDeConexao);

        }

        // Método para abrir a conexão
        private bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                // dois erros mais comuns ao tentar se conectar são
                // 0: Cannot connect to server
                // 1045: Senha ou usuário errados.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrador");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid User or wrong Password");
                        break;
                }
                return false;
            }
        }

        // Método para fechar a conexão
        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

       // Insert statement
        public void Insert()
        {
            View.cadastro inserir = new View.cadastro();
            string query = "Insert INTO cliente (nome,cpf,rg,endereco,idade) VALUES('"+inserir.getNome()+"','"+inserir.getCpf()+"','"+inserir.getRg()+"','"+inserir.getEndereco()+"','"+inserir.getIdade()+"')";

           

            //Checando se conexão está aberta
            if(this.openConnection()==true)
            {


                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();
                this.closeConnection();




                /*  cmd.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
                   cmd.Parameters.Add("@cpf", System.Data.SqlDbType.NVarChar);
                   cmd.Parameters.Add("@rg", System.Data.SqlDbType.NVarChar);
                   cmd.Parameters.Add("@endereco", System.Data.SqlDbType.NVarChar);
                   cmd.Parameters.Add("@idade", System.Data.SqlDbType.Int);

                   View.cadastro inserir = new View.cadastro();
                   cmd.Parameters["@nome"].Value = inserir.nome;
                   cmd.Parameters["@cpf"].Value = inserir.cpf;
                   cmd.Parameters["@rg"].Value = inserir.rg;
                   cmd.Parameters["@endereco"].Value = inserir.endereco;
                   cmd.Parameters["@idade"].Value = inserir.idade;*/

            }
        }

        //Select Statement
       /* public List<string>[] Select()
        {
            string query = "Select * FROM cliente ORDER BY nome ASC";

            if (this.openConnection() == true) {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();

                TelaPrincipal lst = new TelaPrincipal();
                
                while (dr.Read())
                {

                }

            }
        }
        */
        /*
        // Update statement
        public void Update()
        {

        }

        //Delete statement
        public void Delete()
        {
        }

        */
        
        /*
        // Count Statement
        public int Count()
        {
        }

        //Backup
        public void backup()
        {
        }

        // Restore
        public void Restore()
        {
        }
        */




    }


}

