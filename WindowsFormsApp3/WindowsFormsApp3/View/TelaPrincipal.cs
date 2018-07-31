using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp3.DAO;
using WindowsFormsApp3.View;

namespace WindowsFormsApp3
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Cliente Victor = new Model.Cliente("Victor", 18);

           ListViewItem adic = new ListViewItem("darlan");
            adic.SubItems.Add("11111");

            lst1.Items.Add(adic);

            Conta contaVictor = new Conta();
            contaVictor.titular = Victor;
            contaVictor.setSaldo(100.0);
            contaVictor.setNumero(10);

            //MessageBox.Show("Bem vindo sr." + Victor.getNome() + " o seu saldo é de " + contaVictor.getSaldo());


            int[][] matrix;


            String[] vezes = new string[10];
            int n1 = 1;


            Random rnd = new Random();


            tabela.Rows.Clear();
            tabela.Columns.Clear();
            // escrevendo a string 9 vezes.

            String[] gerador()
            {

                for (int i = 0; i < 10; i++)
                {
                    int ale = rnd.Next(1, 100);
                    vezes[i] = Convert.ToString(ale);


                    
                }
                return vezes;
            }





            for (int i = 0; i < 10; i++)
            {

                tabela.Columns.Add("s", Convert.ToString(i));

            }

            int[] soma = new int[10];
            for (int i = 0; i < 10; i++)
            {

                gerador();
                soma[i] = soma[i] + Convert.ToInt16(vezes[i]);
                tabela.Rows.Add(vezes);

            }




            tabela.Rows.Add(Convert.ToString(soma[0]));









        }
        
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Conexao inserir = new Conexao();
             inserir.Insert();*/
             this.Hide();
            cadastro abrir = new cadastro();
            abrir.ShowDialog();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
          /*  Conexao select = new Conexao();
            select.Select();*/
        }
    }
}
