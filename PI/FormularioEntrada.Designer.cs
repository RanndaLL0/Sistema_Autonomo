namespace SistemaAutonomo
{
    partial class FormularioEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEntrada));
            this.lstPartidasEncontradas = new System.Windows.Forms.ListBox();
            this.btnListarPartida = new System.Windows.Forms.Button();
            this.lblIDPartida = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.txtIDPartida = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrarLobby = new System.Windows.Forms.Button();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.btnComecarPartida = new System.Windows.Forms.Button();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPartidasEncontradas
            // 
            this.lstPartidasEncontradas.BackColor = System.Drawing.Color.Black;
            this.lstPartidasEncontradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPartidasEncontradas.Font = new System.Drawing.Font("Inter", 8.66F);
            this.lstPartidasEncontradas.ForeColor = System.Drawing.Color.White;
            this.lstPartidasEncontradas.FormattingEnabled = true;
            this.lstPartidasEncontradas.ItemHeight = 15;
            this.lstPartidasEncontradas.Location = new System.Drawing.Point(21, 136);
            this.lstPartidasEncontradas.Name = "lstPartidasEncontradas";
            this.lstPartidasEncontradas.Size = new System.Drawing.Size(214, 405);
            this.lstPartidasEncontradas.TabIndex = 2;
            this.lstPartidasEncontradas.SelectedIndexChanged += new System.EventHandler(this.lstPartidasEncontradas_SelectedIndexChanged);
            // 
            // btnListarPartida
            // 
            this.btnListarPartida.BackColor = System.Drawing.Color.Black;
            this.btnListarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPartida.FlatAppearance.BorderSize = 0;
            this.btnListarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnListarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPartida.Font = new System.Drawing.Font("Inter SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartida.ForeColor = System.Drawing.Color.White;
            this.btnListarPartida.Location = new System.Drawing.Point(21, 94);
            this.btnListarPartida.Name = "btnListarPartida";
            this.btnListarPartida.Size = new System.Drawing.Size(143, 41);
            this.btnListarPartida.TabIndex = 1;
            this.btnListarPartida.Text = "Listar Partidas";
            this.btnListarPartida.UseVisualStyleBackColor = false;
            this.btnListarPartida.Click += new System.EventHandler(this.btnListarPartida_Click);
            // 
            // lblIDPartida
            // 
            this.lblIDPartida.AutoSize = true;
            this.lblIDPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblIDPartida.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPartida.ForeColor = System.Drawing.Color.White;
            this.lblIDPartida.Location = new System.Drawing.Point(402, 215);
            this.lblIDPartida.Name = "lblIDPartida";
            this.lblIDPartida.Size = new System.Drawing.Size(104, 19);
            this.lblIDPartida.TabIndex = 3;
            this.lblIDPartida.Text = "ID da Partida";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogador.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.ForeColor = System.Drawing.Color.White;
            this.lblNomeJogador.Location = new System.Drawing.Point(384, 293);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(136, 19);
            this.lblNomeJogador.TabIndex = 4;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.ForeColor = System.Drawing.Color.White;
            this.lblSenhaJogador.Location = new System.Drawing.Point(386, 370);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(135, 19);
            this.lblSenhaJogador.TabIndex = 5;
            this.lblSenhaJogador.Text = "Senha da Partida";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.BackColor = System.Drawing.Color.Black;
            this.txtNomeJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeJogador.Font = new System.Drawing.Font("Inter", 11.47F);
            this.txtNomeJogador.ForeColor = System.Drawing.Color.White;
            this.txtNomeJogador.Location = new System.Drawing.Point(13, 9);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(223, 19);
            this.txtNomeJogador.TabIndex = 14;
            // 
            // txtIDPartida
            // 
            this.txtIDPartida.BackColor = System.Drawing.Color.Black;
            this.txtIDPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDPartida.Font = new System.Drawing.Font("Inter", 11.47F);
            this.txtIDPartida.ForeColor = System.Drawing.Color.White;
            this.txtIDPartida.Location = new System.Drawing.Point(13, 8);
            this.txtIDPartida.Name = "txtIDPartida";
            this.txtIDPartida.Size = new System.Drawing.Size(223, 19);
            this.txtIDPartida.TabIndex = 15;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Black;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Inter", 11.47F);
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(13, 9);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(223, 19);
            this.txtSenha.TabIndex = 16;
            // 
            // btnEntrarLobby
            // 
            this.btnEntrarLobby.BackColor = System.Drawing.Color.Black;
            this.btnEntrarLobby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarLobby.FlatAppearance.BorderSize = 0;
            this.btnEntrarLobby.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEntrarLobby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarLobby.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarLobby.ForeColor = System.Drawing.Color.White;
            this.btnEntrarLobby.Location = new System.Drawing.Point(360, 463);
            this.btnEntrarLobby.Name = "btnEntrarLobby";
            this.btnEntrarLobby.Size = new System.Drawing.Size(182, 41);
            this.btnEntrarLobby.TabIndex = 17;
            this.btnEntrarLobby.Text = "Entrar no Lobby";
            this.btnEntrarLobby.UseVisualStyleBackColor = false;
            this.btnEntrarLobby.Click += new System.EventHandler(this.btnEntrarLobby_Click);
            // 
            // lstJogadores
            // 
            this.lstJogadores.BackColor = System.Drawing.Color.Black;
            this.lstJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstJogadores.Font = new System.Drawing.Font("Inter", 8.66F);
            this.lstJogadores.ForeColor = System.Drawing.Color.White;
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 15;
            this.lstJogadores.Location = new System.Drawing.Point(697, 138);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(182, 195);
            this.lstJogadores.TabIndex = 18;
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.Color.Black;
            this.btnListarJogadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarJogadores.FlatAppearance.BorderSize = 0;
            this.btnListarJogadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnListarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarJogadores.Font = new System.Drawing.Font("Inter SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJogadores.ForeColor = System.Drawing.Color.White;
            this.btnListarJogadores.Location = new System.Drawing.Point(697, 94);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(143, 41);
            this.btnListarJogadores.TabIndex = 19;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // btnComecarPartida
            // 
            this.btnComecarPartida.BackColor = System.Drawing.Color.Black;
            this.btnComecarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComecarPartida.FlatAppearance.BorderSize = 0;
            this.btnComecarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnComecarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComecarPartida.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComecarPartida.ForeColor = System.Drawing.Color.White;
            this.btnComecarPartida.Location = new System.Drawing.Point(697, 363);
            this.btnComecarPartida.Name = "btnComecarPartida";
            this.btnComecarPartida.Size = new System.Drawing.Size(182, 41);
            this.btnComecarPartida.TabIndex = 20;
            this.btnComecarPartida.Text = "Começar Partida";
            this.btnComecarPartida.UseVisualStyleBackColor = false;
            this.btnComecarPartida.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.Black;
            this.btnEntrarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarPartida.FlatAppearance.BorderSize = 0;
            this.btnEntrarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.ForeColor = System.Drawing.Color.White;
            this.btnEntrarPartida.Location = new System.Drawing.Point(697, 429);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(182, 41);
            this.btnEntrarPartida.TabIndex = 21;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtIDPartida);
            this.panel1.Location = new System.Drawing.Point(326, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 36);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.txtNomeJogador);
            this.panel2.Location = new System.Drawing.Point(326, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 36);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.txtSenha);
            this.panel3.Location = new System.Drawing.Point(326, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 36);
            this.panel3.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Inter SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(21, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 26);
            this.btnBack.TabIndex = 25;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(802, 535);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(31, 25);
            this.panel4.TabIndex = 26;
            // 
            // FormularioEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 560);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.btnComecarPartida);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.btnEntrarLobby);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.lblIDPartida);
            this.Controls.Add(this.btnListarPartida);
            this.Controls.Add(this.lstPartidasEncontradas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(917, 599);
            this.MinimumSize = new System.Drawing.Size(917, 599);
            this.Name = "FormularioEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPartidasEncontradas;
        private System.Windows.Forms.Button btnListarPartida;
        private System.Windows.Forms.Label lblIDPartida;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.TextBox txtIDPartida;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrarLobby;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Button btnComecarPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
    }

}
