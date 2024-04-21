namespace lobby
{
    partial class Lobby
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
            this.btnPartidas = new System.Windows.Forms.Button();
            this.lstPartsEncontradas = new System.Windows.Forms.ListBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.btnListJogadores = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblHelsinque = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenhaLogIn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPartidas
            // 
            this.btnPartidas.Location = new System.Drawing.Point(25, 35);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(120, 23);
            this.btnPartidas.TabIndex = 0;
            this.btnPartidas.Text = "Listar Partidas";
            this.btnPartidas.UseVisualStyleBackColor = true;
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click);
            // 
            // lstPartsEncontradas
            // 
            this.lstPartsEncontradas.FormattingEnabled = true;
            this.lstPartsEncontradas.Location = new System.Drawing.Point(25, 90);
            this.lstPartsEncontradas.Name = "lstPartsEncontradas";
            this.lstPartsEncontradas.Size = new System.Drawing.Size(181, 277);
            this.lstPartsEncontradas.TabIndex = 1;
            this.lstPartsEncontradas.SelectedIndexChanged += new System.EventHandler(this.lstPartsEncontradas_SelectedIndexChanged);
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(215, 90);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(149, 147);
            this.lstJogadores.TabIndex = 3;
            // 
            // btnListJogadores
            // 
            this.btnListJogadores.Location = new System.Drawing.Point(215, 35);
            this.btnListJogadores.Name = "btnListJogadores";
            this.btnListJogadores.Size = new System.Drawing.Size(127, 24);
            this.btnListJogadores.TabIndex = 2;
            this.btnListJogadores.Text = "Listar Jogadores ";
            this.btnListJogadores.UseVisualStyleBackColor = true;
            this.btnListJogadores.Click += new System.EventHandler(this.btnListJogadores_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(707, 440);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 13);
            this.lblVersao.TabIndex = 4;
            // 
            // lblHelsinque
            // 
            this.lblHelsinque.AutoSize = true;
            this.lblHelsinque.Location = new System.Drawing.Point(362, 9);
            this.lblHelsinque.Name = "lblHelsinque";
            this.lblHelsinque.Size = new System.Drawing.Size(58, 13);
            this.lblHelsinque.TabIndex = 5;
            this.lblHelsinque.Text = "Budapeste";
            this.lblHelsinque.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(434, 158);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Partidas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jogadores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome da partida: ";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(215, 264);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(149, 20);
            this.txtNomePartida.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Senha: ";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(215, 313);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(149, 20);
            this.txtSenha.TabIndex = 14;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(253, 344);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnCriarPartida.TabIndex = 15;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(535, 116);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(53, 20);
            this.txtID.TabIndex = 20;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(532, 100);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(24, 13);
            this.label.TabIndex = 19;
            this.label.Text = "ID: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Entrar na Partida:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(535, 164);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(149, 20);
            this.txtPlayerName.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nome do Jogador";
            // 
            // txtSenhaLogIn
            // 
            this.txtSenhaLogIn.Location = new System.Drawing.Point(535, 217);
            this.txtSenhaLogIn.Name = "txtSenhaLogIn";
            this.txtSenhaLogIn.Size = new System.Drawing.Size(149, 20);
            this.txtSenhaLogIn.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Senha: ";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(535, 261);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(149, 23);
            this.btnEntrar.TabIndex = 25;
            this.btnEntrar.Text = "Entrar no Lobby";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(662, 440);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 26;
            this.lblVersion.Text = "versão:";
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.Location = new System.Drawing.Point(391, 90);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(98, 23);
            this.btnStartMatch.TabIndex = 27;
            this.btnStartMatch.Text = "Começar Partida";
            this.btnStartMatch.UseVisualStyleBackColor = true;
            this.btnStartMatch.Click += new System.EventHandler(this.btnStartMatch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Primeiro jogador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "id:";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(391, 191);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(98, 23);
            this.btnEntrarPartida.TabIndex = 30;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(772, 477);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStartMatch);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSenhaLogIn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblHelsinque);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnListJogadores);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lstPartsEncontradas);
            this.Controls.Add(this.btnPartidas);
            this.MinimumSize = new System.Drawing.Size(788, 516);
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartidas;
        private System.Windows.Forms.ListBox lstPartsEncontradas;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Button btnListJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblHelsinque;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenhaLogIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnStartMatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEntrarPartida;
    }
}

