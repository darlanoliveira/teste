namespace WindowsFormsApp3
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHead = new System.Windows.Forms.Panel();
            this.txtValorConta = new System.Windows.Forms.TextBox();
            this.lblValorConta = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPop = new System.Windows.Forms.Button();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.txtValorConta);
            this.pnlHead.Controls.Add(this.lblValorConta);
            this.pnlHead.Controls.Add(this.lblTitular);
            this.pnlHead.Controls.Add(this.lblCliente);
            this.pnlHead.Location = new System.Drawing.Point(13, 13);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(775, 25);
            this.pnlHead.TabIndex = 0;
            // 
            // txtValorConta
            // 
            this.txtValorConta.Enabled = false;
            this.txtValorConta.Location = new System.Drawing.Point(604, 4);
            this.txtValorConta.Name = "txtValorConta";
            this.txtValorConta.Size = new System.Drawing.Size(132, 20);
            this.txtValorConta.TabIndex = 3;
            // 
            // lblValorConta
            // 
            this.lblValorConta.AutoSize = true;
            this.lblValorConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConta.Location = new System.Drawing.Point(479, 4);
            this.lblValorConta.Name = "lblValorConta";
            this.lblValorConta.Size = new System.Drawing.Size(119, 17);
            this.lblValorConta.TabIndex = 2;
            this.lblValorConta.Text = "Valor em Conta";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.Location = new System.Drawing.Point(66, 4);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(55, 17);
            this.lblTitular.TabIndex = 1;
            this.lblTitular.Text = "Titular";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(4, 4);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 17);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabela
            // 
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.c8,
            this.c9,
            this.c10});
            this.tabela.Location = new System.Drawing.Point(20, 149);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(738, 150);
            this.tabela.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(20, 107);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lst1
            // 
            this.lst1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lst1.Location = new System.Drawing.Point(20, 305);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(738, 123);
            this.lst1.TabIndex = 5;
            this.lst1.UseCompatibleStateImageBehavior = false;
            this.lst1.View = System.Windows.Forms.View.Details;
            // 
            // c1
            // 
            this.c1.HeaderText = "c1";
            this.c1.Name = "c1";
            // 
            // c2
            // 
            this.c2.HeaderText = "c2";
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.HeaderText = "c3";
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.HeaderText = "c4";
            this.c4.Name = "c4";
            // 
            // c5
            // 
            this.c5.HeaderText = "c5";
            this.c5.Name = "c5";
            // 
            // c6
            // 
            this.c6.HeaderText = "c6";
            this.c6.Name = "c6";
            // 
            // c7
            // 
            this.c7.HeaderText = "c7";
            this.c7.Name = "c7";
            // 
            // c8
            // 
            this.c8.HeaderText = "c8";
            this.c8.Name = "c8";
            // 
            // c9
            // 
            this.c9.HeaderText = "c9";
            this.c9.Name = "c9";
            // 
            // c10
            // 
            this.c10.HeaderText = "c10";
            this.c10.Name = "c10";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CPF";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "RG";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Endereço";
            this.columnHeader5.Width = 205;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Idade";
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(20, 434);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 6;
            this.btnPop.Text = "populate";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlHead);
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtValorConta;
        private System.Windows.Forms.Label lblValorConta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListView lst1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
        private System.Windows.Forms.DataGridViewTextBoxColumn c8;
        private System.Windows.Forms.DataGridViewTextBoxColumn c9;
        private System.Windows.Forms.DataGridViewTextBoxColumn c10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnPop;
    }
}

