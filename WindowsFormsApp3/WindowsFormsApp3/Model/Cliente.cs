﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    class Cliente
    {
        private String nome;
        private String cpf;
        private String rg;
        private String endereco;
        private int idade;

        public String getNome() {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getCpf()
        {
            return cpf;
        }

        public void setCpf(String cpf) {
            this.cpf = cpf;
        }

        public String getRg() {
            return rg;
        }

        public void setRg(String rg) {
            this.rg = rg;
        }

        public String getEndereco() {
            return endereco;
        }

        public void setEndereco(String endereco) {
            this.endereco = endereco;
        }

        public int getIdade() {
            return idade;
        }

        public void setIdade(int idade) {
            this.idade = idade;
        }

        public Cliente(String nome, int idade) {
            this.nome = nome;
            this.idade = idade;
        }

    }
}
