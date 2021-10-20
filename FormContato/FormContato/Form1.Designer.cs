
namespace FormContato
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNovo = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxFone = new System.Windows.Forms.TextBox();
            this.textBoxDia = new System.Windows.Forms.TextBox();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.labelFone = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonExluir = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(87, 165);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 23);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.Text = "NOVO";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(117, 36);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 19);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "EMAIL:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(175, 33);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(249, 26);
            this.textBoxEmail.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(87, 194);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(637, 175);
            this.listBox1.TabIndex = 3;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(117, 68);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 19);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "NOME:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(175, 65);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(249, 26);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxFone
            // 
            this.textBoxFone.Location = new System.Drawing.Point(175, 97);
            this.textBoxFone.Name = "textBoxFone";
            this.textBoxFone.Size = new System.Drawing.Size(173, 26);
            this.textBoxFone.TabIndex = 6;
            // 
            // textBoxDia
            // 
            this.textBoxDia.Location = new System.Drawing.Point(175, 129);
            this.textBoxDia.Name = "textBoxDia";
            this.textBoxDia.Size = new System.Drawing.Size(38, 26);
            this.textBoxDia.TabIndex = 7;
            // 
            // textBoxMes
            // 
            this.textBoxMes.Location = new System.Drawing.Point(219, 129);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(38, 26);
            this.textBoxMes.TabIndex = 8;
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(263, 129);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(56, 26);
            this.textBoxAno.TabIndex = 9;
            // 
            // labelFone
            // 
            this.labelFone.AutoSize = true;
            this.labelFone.Location = new System.Drawing.Point(117, 100);
            this.labelFone.Name = "labelFone";
            this.labelFone.Size = new System.Drawing.Size(47, 19);
            this.labelFone.TabIndex = 10;
            this.labelFone.Text = "FONE:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(117, 132);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(45, 19);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "DATA:";
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(168, 165);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 12;
            this.buttonGravar.Text = "GRAVAR";
            this.buttonGravar.UseVisualStyleBackColor = true;
            // 
            // buttonExluir
            // 
            this.buttonExluir.Location = new System.Drawing.Point(249, 165);
            this.buttonExluir.Name = "buttonExluir";
            this.buttonExluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExluir.TabIndex = 13;
            this.buttonExluir.Text = "EXCLUIR";
            this.buttonExluir.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(330, 165);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(82, 23);
            this.buttonPesquisar.TabIndex = 14;
            this.buttonPesquisar.Text = "PESQUISA";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(418, 165);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 15;
            this.buttonListar.Text = "LISTAR";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonExluir);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelFone);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.textBoxMes);
            this.Controls.Add(this.textBoxDia);
            this.Controls.Add(this.textBoxFone);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonNovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxFone;
        private System.Windows.Forms.TextBox textBoxDia;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.Label labelFone;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonExluir;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonListar;
    }
}

