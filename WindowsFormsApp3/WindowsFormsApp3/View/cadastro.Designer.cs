namespace WindowsFormsApp3.View
{
    partial class cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtFechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(14, 60);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(14, 82);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "RG";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(14, 112);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 13);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "Endereço";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(14, 142);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(264, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.Text = "t";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(73, 53);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(264, 20);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.Text = "t";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(73, 79);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(264, 20);
            this.txtRG.TabIndex = 8;
            this.txtRG.Text = "t";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(73, 105);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(264, 20);
            this.txtEnd.TabIndex = 9;
            this.txtEnd.Text = "t";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(73, 135);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(264, 20);
            this.txtIdade.TabIndex = 10;
            this.txtIdade.Text = "0";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(73, 187);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 11;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtFechar
            // 
            this.txtFechar.Location = new System.Drawing.Point(202, 187);
            this.txtFechar.Name = "txtFechar";
            this.txtFechar.Size = new System.Drawing.Size(75, 23);
            this.txtFechar.TabIndex = 12;
            this.txtFechar.Text = "Fechar";
            this.txtFechar.UseVisualStyleBackColor = true;
            this.txtFechar.Click += new System.EventHandler(this.txtFechar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFechar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Name = "cadastro";
            this.Text = "cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button txtFechar;
        private System.Windows.Forms.Button button1;
    }
}