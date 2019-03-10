namespace AgendaLegalWinForms
{
    partial class Agenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeTbx = new System.Windows.Forms.TextBox();
            this.telefoneTbx = new System.Windows.Forms.TextBox();
            this.emailTbx = new System.Windows.Forms.TextBox();
            this.adicionarBtn = new System.Windows.Forms.Button();
            this.contatosDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.contatosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // nomeTbx
            // 
            this.nomeTbx.Location = new System.Drawing.Point(106, 32);
            this.nomeTbx.Name = "nomeTbx";
            this.nomeTbx.Size = new System.Drawing.Size(355, 20);
            this.nomeTbx.TabIndex = 3;
            // 
            // telefoneTbx
            // 
            this.telefoneTbx.Location = new System.Drawing.Point(106, 69);
            this.telefoneTbx.Name = "telefoneTbx";
            this.telefoneTbx.Size = new System.Drawing.Size(355, 20);
            this.telefoneTbx.TabIndex = 4;
            // 
            // emailTbx
            // 
            this.emailTbx.Location = new System.Drawing.Point(106, 108);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(355, 20);
            this.emailTbx.TabIndex = 5;
            // 
            // adicionarBtn
            // 
            this.adicionarBtn.Location = new System.Drawing.Point(506, 32);
            this.adicionarBtn.Name = "adicionarBtn";
            this.adicionarBtn.Size = new System.Drawing.Size(125, 96);
            this.adicionarBtn.TabIndex = 6;
            this.adicionarBtn.Text = "&Adicionar";
            this.adicionarBtn.UseVisualStyleBackColor = true;
            this.adicionarBtn.Click += new System.EventHandler(this.adicionarBtn_Click);
            // 
            // contatosDgv
            // 
            this.contatosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contatosDgv.Location = new System.Drawing.Point(53, 173);
            this.contatosDgv.Name = "contatosDgv";
            this.contatosDgv.Size = new System.Drawing.Size(578, 251);
            this.contatosDgv.TabIndex = 7;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.contatosDgv);
            this.Controls.Add(this.adicionarBtn);
            this.Controls.Add(this.emailTbx);
            this.Controls.Add(this.telefoneTbx);
            this.Controls.Add(this.nomeTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agenda";
            this.Text = "Agenda Legal";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contatosDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeTbx;
        private System.Windows.Forms.TextBox telefoneTbx;
        private System.Windows.Forms.TextBox emailTbx;
        private System.Windows.Forms.Button adicionarBtn;
        private System.Windows.Forms.DataGridView contatosDgv;
    }
}

