using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DAO
{
    class ClienteDAO
    {
        // Insert statement
        public void AdicionarCliente(Model.Cliente cliente)
        {

            string query = "Insert INTO cliente (nome,cpf,rg,endereco,idade) VALUES(@nome,@sobrenome,@cpf,@rg,@endereco,@idade)";

            //criando os parametros


        }

    }
}
