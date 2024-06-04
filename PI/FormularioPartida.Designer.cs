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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPartida));
            this.lblHelsinque = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.lblNomeJ1 = new System.Windows.Forms.Label();
            this.lblNomeJ2 = new System.Windows.Forms.Label();
            this.lblNomeJ4 = new System.Windows.Forms.Label();
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
            this.tmrTimer2 = new System.Windows.Forms.Timer(this.components);
            this.lblNomeJ3 = new System.Windows.Forms.Label();
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
            this.lblHelsinque.Visible = false;
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
            this.lblVersion.Visible = false;
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
            this.tmrTimer.Interval = 1500;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.Black;
            this.btnStartTimer.FlatAppearance.BorderSize = 0;
            this.btnStartTimer.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStartTimer.ForeColor = System.Drawing.Color.White;
            this.btnStartTimer.Location = new System.Drawing.Point(413, 984);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(185, 53);
            this.btnStartTimer.TabIndex = 29;
            this.btnStartTimer.Text = "Iniciar Timer";
            this.btnStartTimer.UseVisualStyleBackColor = false;
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
            // tmrTimer2
            // 
            this.tmrTimer2.Interval = 1000;
            this.tmrTimer2.Tick += new System.EventHandler(this.tmrTimer2_Tick);
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
            this.lblNomeJ3.TabIndex = 50;
            // 
            // FormularioPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SistemaAutonomo.Properties.Resources.FormularioPartida;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblNomeJ3);
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
            this.Controls.Add(this.lblNomeJ4);
            this.Controls.Add(this.lblNomeJ2);
            this.Controls.Add(this.lblNomeJ1);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblHelsinque);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioPartida";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Partida";
            this.TopMost = true;
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
        private System.Windows.Forms.Timer tmrTimer2;
        private System.Windows.Forms.Label lblNomeJ3;
    }
}