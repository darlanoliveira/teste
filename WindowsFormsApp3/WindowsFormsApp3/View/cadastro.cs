using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.DAO;

namespace WindowsFormsApp3.View
{
    public partial class cadastro : Form
    {
        private string nome;
        private string cpf;
        private string rg;
        private string endereco;
        private int idade;

        public String getNome()
        {
            nome = txtNome.Text;
            return nome;
        }

        public void setNome(String nome) {
            this.nome = nome;
        }

        public String getCpf() {
            cpf = txtCPF.Text;
            return cpf;
        }
        
        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }

        public String getRg()
        {
            rg = txtRG.Text;
            return rg;

        }

        public void setRg(String rg)
        {
            this.rg = rg;
        }

        public String getEndereco()
        {
            endereco = txtEnd.Text;
            return endereco;
        }

        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }

        public int getIdade()
        {
            idade = Convert.ToInt32(txtIdade.Text);
            return idade;
        }



        public cadastro()
        {
            InitializeComponent();
            setNome(txtNome.Text);

        }

        private void txtFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPrincipal abrir = new TelaPrincipal();
            abrir.ShowDialog();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Conexao cad = new Conexao();

           

            cad.Insert();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setNome(txtNome.Text);

            MessageBox.Show(getNome());
        }
    }
}
