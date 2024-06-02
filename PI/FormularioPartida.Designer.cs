namespace lobby
{
    partial class FormularioPartida
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
            this.lblHelsinque = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.lblNomeJ1 = new System.Windows.Forms.Label();
            this.lblNomeJ2 = new System.Windows.Forms.Label();
            this.lblNomeJ4 = new System.Windows.Forms.Label();
            this.lblNomeJ3 = new System.Windows.Forms.Label();
            this.lblJogadorVez = new System.Windows.Forms.Label();
            this.lblRodada = new System.Windows.Forms.Label();
            this.lblStatusPartida = new System.Windows.Forms.Label();
            this.lblStatusRodada = new System.Windows.Forms.Label();
            this.lblPontuacaoTurnoJ3 = new System.Windows.Forms.Label();
            this.lblPontuacaoTotalJ3 = new System.Windows.Forms.Label();
            this.lblPontuacaoTotalJ1 = new System.Windows.Forms.Label();
            this.lblPontuacaoTurnoJ1 = new System.Windows.Forms.Label();
            this.lblPontuacaoTurnoJ4 = new System.Windows.Forms.Label();
            this.lblPontuacaoTotalJ4 = new System.Windows.Forms.Label();
            this.lblPontuacaoTotalJ2 = new System.Windows.Forms.Label();
            this.lblPontuacaoTurnoJ2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCarta = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lstCartas = new System.Windows.Forms.ListBox();
            this.btnAtualizarCartas = new System.Windows.Forms.Button();
            this.tmrTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.lblVersion.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(585, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 14);
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
            this.tmrTimer.Interval = 4000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(137, 497);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(185, 53);
            this.btnStartTimer.TabIndex = 29;
            this.btnStartTimer.Text = "Iniciar Timer";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // lblNomeJ1
            // 
            this.lblNomeJ1.AutoSize = true;
            this.lblNomeJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJ1.Font = new System.Drawing.Font("Inter ExtraLight", 13.75F);
            this.lblNomeJ1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblNomeJ1.Location = new System.Drawing.Point(636, 736);
            this.lblNomeJ1.Name = "lblNomeJ1";
            this.lblNomeJ1.Size = new System.Drawing.Size(0, 23);
            this.lblNomeJ1.TabIndex = 34;
            // 
            // lblNomeJ2
            // 
            this.lblNomeJ2.AutoSize = true;
            this.lblNomeJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJ2.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblNomeJ2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblNomeJ2.Location = new System.Drawing.Point(1533, 950);
            this.lblNomeJ2.Name = "lblNomeJ2";
            this.lblNomeJ2.Size = new System.Drawing.Size(0, 21);
            this.lblNomeJ2.TabIndex = 35;
            // 
            // lblNomeJ4
            // 
            this.lblNomeJ4.AutoSize = true;
            this.lblNomeJ4.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJ4.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblNomeJ4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblNomeJ4.Location = new System.Drawing.Point(111, 951);
            this.lblNomeJ4.Name = "lblNomeJ4";
            this.lblNomeJ4.Size = new System.Drawing.Size(0, 21);
            this.lblNomeJ4.TabIndex = 36;
            // 
            // lblNomeJ3
            // 
            this.lblNomeJ3.AutoSize = true;
            this.lblNomeJ3.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJ3.Font = new System.Drawing.Font("Inter ExtraLight", 13.75F);
            this.lblNomeJ3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblNomeJ3.Location = new System.Drawing.Point(636, 320);
            this.lblNomeJ3.Name = "lblNomeJ3";
            this.lblNomeJ3.Size = new System.Drawing.Size(0, 23);
            this.lblNomeJ3.TabIndex = 37;
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadorVez.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblJogadorVez.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblJogadorVez.Location = new System.Drawing.Point(1685, 150);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(0, 21);
            this.lblJogadorVez.TabIndex = 38;
            // 
            // lblRodada
            // 
            this.lblRodada.AutoSize = true;
            this.lblRodada.BackColor = System.Drawing.Color.Transparent;
            this.lblRodada.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblRodada.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblRodada.Location = new System.Drawing.Point(1617, 116);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(0, 21);
            this.lblRodada.TabIndex = 39;
            // 
            // lblStatusPartida
            // 
            this.lblStatusPartida.AutoSize = true;
            this.lblStatusPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusPartida.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblStatusPartida.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblStatusPartida.Location = new System.Drawing.Point(1675, 82);
            this.lblStatusPartida.Name = "lblStatusPartida";
            this.lblStatusPartida.Size = new System.Drawing.Size(0, 21);
            this.lblStatusPartida.TabIndex = 40;
            // 
            // lblStatusRodada
            // 
            this.lblStatusRodada.AutoSize = true;
            this.lblStatusRodada.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusRodada.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblStatusRodada.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblStatusRodada.Location = new System.Drawing.Point(1676, 183);
            this.lblStatusRodada.Name = "lblStatusRodada";
            this.lblStatusRodada.Size = new System.Drawing.Size(0, 21);
            this.lblStatusRodada.TabIndex = 41;
            // 
            // lblPontuacaoTurnoJ3
            // 
            this.lblPontuacaoTurnoJ3.AutoSize = true;
            this.lblPontuacaoTurnoJ3.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacaoTurnoJ3.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblPontuacaoTurnoJ3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPontuacaoTurnoJ3.Location = new System.Drawing.Point(986, 321);
            this.lblPontuacaoTurnoJ3.Name = "lblPontuacaoTurnoJ3";
            this.lblPontuacaoTurnoJ3.Size = new System.Drawing.Size(0, 21);
            this.lblPontuacaoTurnoJ3.TabIndex = 42;
            // 
            // lblPontuacaoTotalJ3
            // 
            this.lblPontuacaoTotalJ3.AutoSize = true;
            this.lblPontuacaoTotalJ3.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacaoTotalJ3.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblPontuacaoTotalJ3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPontuacaoTotalJ3.Location = new System.Drawing.Point(1245, 321);
            this.lblPontuacaoTotalJ3.Name = "lblPontuacaoTotalJ3";
            this.lblPontuacaoTotalJ3.Size = new System.Drawing.Size(0, 21);
            this.lblPontuacaoTotalJ3.TabIndex = 43;
            // 
            // lblPontuacaoTotalJ1
            // 
            this.lblPontuacaoTotalJ1.AutoSize = true;
            this.lblPontuacaoTotalJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacaoTotalJ1.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblPontuacaoTotalJ1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPontuacaoTotalJ1.Location = new System.Drawing.Point(1245, 738);
            this.lblPontuacaoTotalJ1.Name = "lblPontuacaoTotalJ1";
            this.lblPontuacaoTotalJ1.Size = new System.Drawing.Size(0, 21);
            this.lblPontuacaoTotalJ1.TabIndex = 45;
            // 
            // lblPontuacaoTurnoJ1
            // 
            this.lblPontuacaoTurnoJ1.AutoSize = true;
            this.lblPontuacaoTurnoJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacaoTurnoJ1.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblPontuacaoTurnoJ1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPontuacaoTurnoJ1.Location = new System.Drawing.Point(986, 738);
            this.lblPontuacaoTurnoJ1.Name = "lblPontuacaoTurnoJ1";
            this.lblPontuacaoTurnoJ1.Size = new System.Drawing.Size(0, 21);
            this.lblPontuacaoTurnoJ1.TabIndex = 44;
            // 
            // lblPontuacaoTurnoJ4
            // 
            this.lblPontuacaoTurnoJ4.AutoSize = true;
            this.lblPontuacaoTurnoJ4.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacaoTurnoJ4.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblPontuacaoTurnoJ4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPontuacaoTurnoJ4.Location = new System.Drawing.Point(273, 981);
            this.lblPontuacaoTurnoJ4.Name = "lblPontuacaoTurnoJ4";
            this.lblPontuacaoTurnoJ4.Size = new System.Drawing.Size(0, 21);
            this.lblPontuacaoTurnoJ4.TabIndex = 46;
            // 
            // lblPontuacaoTotalJ4
            // 
            this.lblPontuacaoTotalJ4.AutoSize = true;
            this.lblPontuacaoTotalJ4.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacaoTotalJ4.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblPontuacaoTotalJ4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPontuacaoTotalJ4.Location = new System.Drawing.Point(273, 1016);
            this.lblPontuacaoTotalJ4.Name = "lblPontuacaoTotalJ4";
            this.lblPontuacaoTotalJ4.Size = new System.Drawing.Size(0, 21);
            this.lblPontuacaoTotalJ4.TabIndex = 47;
            // 
            // lblPontuacaoTotalJ2
            // 
            this.lblPontuacaoTotalJ2.AutoSize = true;
            this.lblPontuacaoTotalJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacaoTotalJ2.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblPontuacaoTotalJ2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPontuacaoTotalJ2.Location = new System.Drawing.Point(1697, 1016);
            this.lblPontuacaoTotalJ2.Name = "lblPontuacaoTotalJ2";
            this.lblPontuacaoTotalJ2.Size = new System.Drawing.Size(0, 21);
            this.lblPontuacaoTotalJ2.TabIndex = 49;
            // 
            // lblPontuacaoTurnoJ2
            // 
            this.lblPontuacaoTurnoJ2.AutoSize = true;
            this.lblPontuacaoTurnoJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacaoTurnoJ2.Font = new System.Drawing.Font("Inter ExtraLight", 13F);
            this.lblPontuacaoTurnoJ2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPontuacaoTurnoJ2.Location = new System.Drawing.Point(1697, 981);
            this.lblPontuacaoTurnoJ2.Name = "lblPontuacaoTurnoJ2";
            this.lblPontuacaoTurnoJ2.Size = new System.Drawing.Size(0, 21);
            this.lblPontuacaoTurnoJ2.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id do Jogador:";
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(450, 185);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(78, 20);
            this.txtIdJogador.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha do Jogador: ";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(450, 222);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(78, 20);
            this.txtSenhaJogador.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id da Carta:";
            // 
            // txtIdCarta
            // 
            this.txtIdCarta.Location = new System.Drawing.Point(450, 259);
            this.txtIdCarta.Name = "txtIdCarta";
            this.txtIdCarta.Size = new System.Drawing.Size(78, 20);
            this.txtIdCarta.TabIndex = 9;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(347, 300);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(495, 300);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(75, 23);
            this.btnApostar.TabIndex = 10;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lstCartas
            // 
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.Location = new System.Drawing.Point(137, 30);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(185, 394);
            this.lstCartas.TabIndex = 0;
            // 
            // btnAtualizarCartas
            // 
            this.btnAtualizarCartas.Location = new System.Drawing.Point(177, 449);
            this.btnAtualizarCartas.Name = "btnAtualizarCartas";
            this.btnAtualizarCartas.Size = new System.Drawing.Size(99, 34);
            this.btnAtualizarCartas.TabIndex = 20;
            this.btnAtualizarCartas.Text = "Atualizar Cartas";
            this.btnAtualizarCartas.UseVisualStyleBackColor = true;
            this.btnAtualizarCartas.Click += new System.EventHandler(this.btnAtualizarCartas_Click);
            // 
            // tmrTimer2
            // 
            this.tmrTimer2.Interval = 1000;
            this.tmrTimer2.Tick += new System.EventHandler(this.tmrTimer2_Tick);
            // 
            // FormularioPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SistemaAutonomo.Properties.Resources.FormularioPartida;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblPontuacaoTotalJ2);
            this.Controls.Add(this.lblPontuacaoTurnoJ2);
            this.Controls.Add(this.lblPontuacaoTotalJ4);
            this.Controls.Add(this.lblPontuacaoTurnoJ4);
            this.Controls.Add(this.lblPontuacaoTotalJ1);
            this.Controls.Add(this.lblPontuacaoTurnoJ1);
            this.Controls.Add(this.lblPontuacaoTotalJ3);
            this.Controls.Add(this.lblPontuacaoTurnoJ3);
            this.Controls.Add(this.lblStatusRodada);
            this.Controls.Add(this.lblStatusPartida);
            this.Controls.Add(this.lblRodada);
            this.Controls.Add(this.lblJogadorVez);
            this.Controls.Add(this.lblNomeJ3);
            this.Controls.Add(this.lblNomeJ4);
            this.Controls.Add(this.lblNomeJ2);
            this.Controls.Add(this.lblNomeJ1);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblHelsinque);
            this.Controls.Add(this.btnAtualizarCartas);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.txtIdCarta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lstCartas);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPartida";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHelsinque;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Label lblNomeJ1;
        private System.Windows.Forms.Label lblNomeJ2;
        private System.Windows.Forms.Label lblNomeJ4;
        private System.Windows.Forms.Label lblNomeJ3;
        private System.Windows.Forms.Label lblJogadorVez;
        private System.Windows.Forms.Label lblRodada;
        private System.Windows.Forms.Label lblStatusPartida;
        private System.Windows.Forms.Label lblStatusRodada;
        private System.Windows.Forms.Label lblPontuacaoTurnoJ3;
        private System.Windows.Forms.Label lblPontuacaoTotalJ3;
        private System.Windows.Forms.Label lblPontuacaoTotalJ1;
        private System.Windows.Forms.Label lblPontuacaoTurnoJ1;
        private System.Windows.Forms.Label lblPontuacaoTurnoJ4;
        private System.Windows.Forms.Label lblPontuacaoTotalJ4;
        private System.Windows.Forms.Label lblPontuacaoTotalJ2;
        private System.Windows.Forms.Label lblPontuacaoTurnoJ2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCarta;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.ListBox lstCartas;
        private System.Windows.Forms.Button btnAtualizarCartas;
        private System.Windows.Forms.Timer tmrTimer2;
    }
}