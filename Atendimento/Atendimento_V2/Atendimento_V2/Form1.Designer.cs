namespace Atendimento_V2
{
    partial class FormAtendimentoPorSenha
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
            this.botaoGerar = new System.Windows.Forms.Button();
            this.botaoAdicionarGuiche = new System.Windows.Forms.Button();
            this.botaoListarAtendimentos = new System.Windows.Forms.Button();
            this.botaoListarSenhas = new System.Windows.Forms.Button();
            this.botaoChamar = new System.Windows.Forms.Button();
            this.listBoxSenhas = new System.Windows.Forms.ListBox();
            this.listBoxAgendamentos = new System.Windows.Forms.ListBox();
            this.labelQntdGuiches = new System.Windows.Forms.Label();
            this.textBoxNumeroGuiche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoGerar
            // 
            this.botaoGerar.Location = new System.Drawing.Point(47, 32);
            this.botaoGerar.Name = "botaoGerar";
            this.botaoGerar.Size = new System.Drawing.Size(150, 30);
            this.botaoGerar.TabIndex = 0;
            this.botaoGerar.Text = "Gerar";
            this.botaoGerar.UseVisualStyleBackColor = true;
            this.botaoGerar.Click += new System.EventHandler(this.botaoGerar_Click_1);
            // 
            // botaoAdicionarGuiche
            // 
            this.botaoAdicionarGuiche.Location = new System.Drawing.Point(242, 245);
            this.botaoAdicionarGuiche.Name = "botaoAdicionarGuiche";
            this.botaoAdicionarGuiche.Size = new System.Drawing.Size(120, 30);
            this.botaoAdicionarGuiche.TabIndex = 3;
            this.botaoAdicionarGuiche.Text = "Adicionar";
            this.botaoAdicionarGuiche.UseVisualStyleBackColor = true;
            this.botaoAdicionarGuiche.Click += new System.EventHandler(this.botaoAdicionarGuiche_Click);
            // 
            // botaoListarAtendimentos
            // 
            this.botaoListarAtendimentos.Location = new System.Drawing.Point(586, 291);
            this.botaoListarAtendimentos.Name = "botaoListarAtendimentos";
            this.botaoListarAtendimentos.Size = new System.Drawing.Size(150, 30);
            this.botaoListarAtendimentos.TabIndex = 5;
            this.botaoListarAtendimentos.Text = "Listar Atendimentos";
            this.botaoListarAtendimentos.UseVisualStyleBackColor = true;
            this.botaoListarAtendimentos.Click += new System.EventHandler(this.botaoListarAtendimentos_Click);
            // 
            // botaoListarSenhas
            // 
            this.botaoListarSenhas.Location = new System.Drawing.Point(47, 291);
            this.botaoListarSenhas.Name = "botaoListarSenhas";
            this.botaoListarSenhas.Size = new System.Drawing.Size(150, 30);
            this.botaoListarSenhas.TabIndex = 2;
            this.botaoListarSenhas.Text = "Listar Senhas";
            this.botaoListarSenhas.UseVisualStyleBackColor = true;
            this.botaoListarSenhas.Click += new System.EventHandler(this.botaoListarSenhas_Click_1);
            // 
            // botaoChamar
            // 
            this.botaoChamar.Location = new System.Drawing.Point(586, 32);
            this.botaoChamar.Name = "botaoChamar";
            this.botaoChamar.Size = new System.Drawing.Size(150, 30);
            this.botaoChamar.TabIndex = 4;
            this.botaoChamar.Text = "Chamar";
            this.botaoChamar.UseVisualStyleBackColor = true;
            this.botaoChamar.Click += new System.EventHandler(this.botaoChamar_Click);
            // 
            // listBoxSenhas
            // 
            this.listBoxSenhas.FormattingEnabled = true;
            this.listBoxSenhas.Location = new System.Drawing.Point(12, 76);
            this.listBoxSenhas.Name = "listBoxSenhas";
            this.listBoxSenhas.Size = new System.Drawing.Size(214, 199);
            this.listBoxSenhas.TabIndex = 5;
            // 
            // listBoxAgendamentos
            // 
            this.listBoxAgendamentos.FormattingEnabled = true;
            this.listBoxAgendamentos.Location = new System.Drawing.Point(379, 76);
            this.listBoxAgendamentos.Name = "listBoxAgendamentos";
            this.listBoxAgendamentos.Size = new System.Drawing.Size(409, 199);
            this.listBoxAgendamentos.TabIndex = 6;
            // 
            // labelQntdGuiches
            // 
            this.labelQntdGuiches.AutoSize = true;
            this.labelQntdGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelQntdGuiches.Location = new System.Drawing.Point(288, 198);
            this.labelQntdGuiches.Name = "labelQntdGuiches";
            this.labelQntdGuiches.Size = new System.Drawing.Size(29, 31);
            this.labelQntdGuiches.TabIndex = 7;
            this.labelQntdGuiches.Text = "0";
            // 
            // textBoxNumeroGuiche
            // 
            this.textBoxNumeroGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNumeroGuiche.Location = new System.Drawing.Point(495, 33);
            this.textBoxNumeroGuiche.Name = "textBoxNumeroGuiche";
            this.textBoxNumeroGuiche.Size = new System.Drawing.Size(68, 26);
            this.textBoxNumeroGuiche.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(248, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Qntd. Guichês";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(430, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Guichê:";
            // 
            // FormAtendimentoPorSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumeroGuiche);
            this.Controls.Add(this.labelQntdGuiches);
            this.Controls.Add(this.listBoxAgendamentos);
            this.Controls.Add(this.listBoxSenhas);
            this.Controls.Add(this.botaoChamar);
            this.Controls.Add(this.botaoListarSenhas);
            this.Controls.Add(this.botaoListarAtendimentos);
            this.Controls.Add(this.botaoAdicionarGuiche);
            this.Controls.Add(this.botaoGerar);
            this.Name = "FormAtendimentoPorSenha";
            this.Text = "Atendimento por Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoGerar;
        private System.Windows.Forms.Button botaoAdicionarGuiche;
        private System.Windows.Forms.Button botaoListarAtendimentos;
        private System.Windows.Forms.Button botaoListarSenhas;
        private System.Windows.Forms.Button botaoChamar;
        private System.Windows.Forms.ListBox listBoxSenhas;
        private System.Windows.Forms.ListBox listBoxAgendamentos;
        private System.Windows.Forms.Label labelQntdGuiches;
        private System.Windows.Forms.TextBox textBoxNumeroGuiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

