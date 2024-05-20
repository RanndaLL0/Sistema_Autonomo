namespace lobby
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.lstCartas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIDVez = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCarta = new System.Windows.Forms.TextBox();
            this.btnApostar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRodadaVez = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatusVez = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPartidaStatus = new System.Windows.Forms.Label();
            this.btnAtualizarVez = new System.Windows.Forms.Button();
            this.btnAtualizarCartas = new System.Windows.Forms.Button();
            this.lblHelsinque = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.lstJogadas = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCartas
            // 
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.Location = new System.Drawing.Point(236, 12);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(185, 394);
            this.lstCartas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vez do Jogador: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDVez
            // 
            this.lblIDVez.AutoSize = true;
            this.lblIDVez.Location = new System.Drawing.Point(132, 64);
            this.lblIDVez.Name = "lblIDVez";
            this.lblIDVez.Size = new System.Drawing.Size(35, 13);
            this.lblIDVez.TabIndex = 2;
            this.lblIDVez.Text = "label2";
            this.lblIDVez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(63, 317);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(110, 202);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(78, 20);
            this.txtIdJogador.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id do Jogador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha do Jogador: ";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(110, 239);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(78, 20);
            this.txtSenhaJogador.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id da Carta:";
            // 
            // txtIdCarta
            // 
            this.txtIdCarta.Location = new System.Drawing.Point(110, 276);
            this.txtIdCarta.Name = "txtIdCarta";
            this.txtIdCarta.Size = new System.Drawing.Size(78, 20);
            this.txtIdCarta.TabIndex = 9;
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(155, 317);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(75, 23);
            this.btnApostar.TabIndex = 10;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rodada:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRodadaVez
            // 
            this.lblRodadaVez.AutoSize = true;
            this.lblRodadaVez.Location = new System.Drawing.Point(132, 87);
            this.lblRodadaVez.Name = "lblRodadaVez";
            this.lblRodadaVez.Size = new System.Drawing.Size(35, 13);
            this.lblRodadaVez.TabIndex = 14;
            this.lblRodadaVez.Text = "label2";
            this.lblRodadaVez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusVez
            // 
            this.lblStatusVez.AutoSize = true;
            this.lblStatusVez.Location = new System.Drawing.Point(132, 109);
            this.lblStatusVez.Name = "lblStatusVez";
            this.lblStatusVez.Size = new System.Drawing.Size(35, 13);
            this.lblStatusVez.TabIndex = 16;
            this.lblStatusVez.Text = "label2";
            this.lblStatusVez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status Partida:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartidaStatus
            // 
            this.lblPartidaStatus.AutoSize = true;
            this.lblPartidaStatus.Location = new System.Drawing.Point(132, 42);
            this.lblPartidaStatus.Name = "lblPartidaStatus";
            this.lblPartidaStatus.Size = new System.Drawing.Size(35, 13);
            this.lblPartidaStatus.TabIndex = 18;
            this.lblPartidaStatus.Text = "label2";
            this.lblPartidaStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtualizarVez
            // 
            this.btnAtualizarVez.Location = new System.Drawing.Point(49, 140);
            this.btnAtualizarVez.Name = "btnAtualizarVez";
            this.btnAtualizarVez.Size = new System.Drawing.Size(118, 23);
            this.btnAtualizarVez.TabIndex = 19;
            this.btnAtualizarVez.Text = "Atualizar Vez";
            this.btnAtualizarVez.UseVisualStyleBackColor = true;
            this.btnAtualizarVez.Click += new System.EventHandler(this.btnAtualizarVez_Click);
            // 
            // btnAtualizarCartas
            // 
            this.btnAtualizarCartas.Location = new System.Drawing.Point(277, 412);
            this.btnAtualizarCartas.Name = "btnAtualizarCartas";
            this.btnAtualizarCartas.Size = new System.Drawing.Size(99, 34);
            this.btnAtualizarCartas.TabIndex = 20;
            this.btnAtualizarCartas.Text = "Atualizar Cartas";
            this.btnAtualizarCartas.UseVisualStyleBackColor = true;
            this.btnAtualizarCartas.Click += new System.EventHandler(this.btnAtualizarCartas_Click);
            // 
            // lblHelsinque
            // 
            this.lblHelsinque.AutoSize = true;
            this.lblHelsinque.Location = new System.Drawing.Point(513, 9);
            this.lblHelsinque.Name = "lblHelsinque";
            this.lblHelsinque.Size = new System.Drawing.Size(58, 13);
            this.lblHelsinque.TabIndex = 22;
            this.lblHelsinque.Text = "Budapeste";
            this.lblHelsinque.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(585, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 28;
            this.lblVersion.Text = "versão:";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(627, 9);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 13);
            this.lblVersao.TabIndex = 27;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 5000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(236, 452);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(185, 53);
            this.btnStartTimer.TabIndex = 29;
            this.btnStartTimer.Text = "Iniciar Timer";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // lstJogadas
            // 
            this.lstJogadas.FormattingEnabled = true;
            this.lstJogadas.Location = new System.Drawing.Point(17, 558);
            this.lstJogadas.Name = "lstJogadas";
            this.lstJogadas.Size = new System.Drawing.Size(185, 394);
            this.lstJogadas.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Cartas Jogadas";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.Location = new System.Drawing.Point(236, 558);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(185, 394);
            this.lstStatus.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Status Partida";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstJogadas);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblHelsinque);
            this.Controls.Add(this.btnAtualizarCartas);
            this.Controls.Add(this.btnAtualizarVez);
            this.Controls.Add(this.lblPartidaStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStatusVez);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRodadaVez);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.txtIdCarta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblIDVez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCartas);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCartas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIDVez;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCarta;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRodadaVez;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatusVez;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPartidaStatus;
        private System.Windows.Forms.Button btnAtualizarVez;
        private System.Windows.Forms.Button btnAtualizarCartas;
        private System.Windows.Forms.Label lblHelsinque;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.ListBox lstJogadas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.Label label9;
    }
}