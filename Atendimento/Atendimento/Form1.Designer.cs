namespace Atendimento
{
    partial class Form1
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
            this.buttonGerar = new System.Windows.Forms.Button();
            this.listBoxSenhas = new System.Windows.Forms.ListBox();
            this.labelQtdeGuiches = new System.Windows.Forms.Label();
            this.labelNGuiches = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.listBoxGuiche = new System.Windows.Forms.ListBox();
            this.buttonChamar = new System.Windows.Forms.Button();
            this.labelGuiche = new System.Windows.Forms.Label();
            this.buttonListarAtend = new System.Windows.Forms.Button();
            this.buttonListarSenhas = new System.Windows.Forms.Button();
            this.textBoxGuiche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGerar
            // 
            this.buttonGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonGerar.Location = new System.Drawing.Point(85, 47);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(80, 25);
            this.buttonGerar.TabIndex = 0;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // listBoxSenhas
            // 
            this.listBoxSenhas.FormattingEnabled = true;
            this.listBoxSenhas.Location = new System.Drawing.Point(12, 78);
            this.listBoxSenhas.Name = "listBoxSenhas";
            this.listBoxSenhas.Size = new System.Drawing.Size(234, 160);
            this.listBoxSenhas.TabIndex = 1;
            // 
            // labelQtdeGuiches
            // 
            this.labelQtdeGuiches.AutoSize = true;
            this.labelQtdeGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelQtdeGuiches.Location = new System.Drawing.Point(252, 113);
            this.labelQtdeGuiches.Name = "labelQtdeGuiches";
            this.labelQtdeGuiches.Size = new System.Drawing.Size(113, 20);
            this.labelQtdeGuiches.TabIndex = 2;
            this.labelQtdeGuiches.Text = " Qtde guichês";
            // 
            // labelNGuiches
            // 
            this.labelNGuiches.AutoSize = true;
            this.labelNGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.labelNGuiches.Location = new System.Drawing.Point(292, 133);
            this.labelNGuiches.Name = "labelNGuiches";
            this.labelNGuiches.Size = new System.Drawing.Size(36, 39);
            this.labelNGuiches.TabIndex = 3;
            this.labelNGuiches.Text = "0";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAdicionar.Location = new System.Drawing.Point(271, 175);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(80, 25);
            this.buttonAdicionar.TabIndex = 4;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // listBoxGuiche
            // 
            this.listBoxGuiche.FormattingEnabled = true;
            this.listBoxGuiche.Location = new System.Drawing.Point(371, 78);
            this.listBoxGuiche.Name = "listBoxGuiche";
            this.listBoxGuiche.Size = new System.Drawing.Size(324, 160);
            this.listBoxGuiche.TabIndex = 5;
            this.listBoxGuiche.SelectedIndexChanged += new System.EventHandler(this.listBoxGuiches_SelectedIndexChanged);
            // 
            // buttonChamar
            // 
            this.buttonChamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonChamar.Location = new System.Drawing.Point(579, 45);
            this.buttonChamar.Name = "buttonChamar";
            this.buttonChamar.Size = new System.Drawing.Size(80, 25);
            this.buttonChamar.TabIndex = 6;
            this.buttonChamar.Text = "Chamar";
            this.buttonChamar.UseVisualStyleBackColor = true;
            this.buttonChamar.Click += new System.EventHandler(this.buttonChamar_Click);
            // 
            // labelGuiche
            // 
            this.labelGuiche.AutoSize = true;
            this.labelGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelGuiche.Location = new System.Drawing.Point(377, 47);
            this.labelGuiche.Name = "labelGuiche";
            this.labelGuiche.Size = new System.Drawing.Size(62, 20);
            this.labelGuiche.TabIndex = 7;
            this.labelGuiche.Text = "Guiche";
            // 
            // buttonListarAtend
            // 
            this.buttonListarAtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonListarAtend.Location = new System.Drawing.Point(410, 244);
            this.buttonListarAtend.Name = "buttonListarAtend";
            this.buttonListarAtend.Size = new System.Drawing.Size(240, 25);
            this.buttonListarAtend.TabIndex = 9;
            this.buttonListarAtend.Text = "Listar Atendimentos";
            this.buttonListarAtend.UseVisualStyleBackColor = true;
            this.buttonListarAtend.Click += new System.EventHandler(this.buttonListarAtend_Click);
            // 
            // buttonListarSenhas
            // 
            this.buttonListarSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonListarSenhas.Location = new System.Drawing.Point(44, 244);
            this.buttonListarSenhas.Name = "buttonListarSenhas";
            this.buttonListarSenhas.Size = new System.Drawing.Size(160, 25);
            this.buttonListarSenhas.TabIndex = 10;
            this.buttonListarSenhas.Text = "Listar Senhas";
            this.buttonListarSenhas.UseVisualStyleBackColor = true;
            this.buttonListarSenhas.Click += new System.EventHandler(this.buttonListarSenhas_Click);
            // 
            // textBoxGuiche
            // 
            this.textBoxGuiche.Location = new System.Drawing.Point(446, 46);
            this.textBoxGuiche.Name = "textBoxGuiche";
            this.textBoxGuiche.Size = new System.Drawing.Size(55, 20);
            this.textBoxGuiche.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxGuiche);
            this.Controls.Add(this.buttonListarSenhas);
            this.Controls.Add(this.buttonListarAtend);
            this.Controls.Add(this.labelGuiche);
            this.Controls.Add(this.buttonChamar);
            this.Controls.Add(this.listBoxGuiche);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelNGuiches);
            this.Controls.Add(this.labelQtdeGuiches);
            this.Controls.Add(this.listBoxSenhas);
            this.Controls.Add(this.buttonGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.ListBox listBoxSenhas;
        private System.Windows.Forms.Label labelQtdeGuiches;
        private System.Windows.Forms.Label labelNGuiches;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.ListBox listBoxGuiche;
        private System.Windows.Forms.Button buttonChamar;
        private System.Windows.Forms.Label labelGuiche;
        private System.Windows.Forms.Button buttonListarAtend;
        private System.Windows.Forms.Button buttonListarSenhas;
        private System.Windows.Forms.TextBox textBoxGuiche;
    }
}

