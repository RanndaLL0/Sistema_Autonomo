using SistemaAutonomo.Properties;
using System.Resources;

namespace SistemaAutonomo
{
    partial class FormularioCriarPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCriarPartida));
            this.btnBack = new System.Windows.Forms.Button();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIDPartida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 26;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.BackColor = System.Drawing.Color.Black;
            this.txtNomePartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomePartida.Font = new System.Drawing.Font("Inter", 11.47F);
            this.txtNomePartida.ForeColor = System.Drawing.Color.White;
            this.txtNomePartida.Location = new System.Drawing.Point(13, 8);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(223, 19);
            this.txtNomePartida.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtNomePartida);
            this.panel1.Location = new System.Drawing.Point(326, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 36);
            this.panel1.TabIndex = 27;
            // 
            // lblIDPartida
            // 
            this.lblIDPartida.AutoSize = true;
            this.lblIDPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblIDPartida.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPartida.ForeColor = System.Drawing.Color.White;
            this.lblIDPartida.Location = new System.Drawing.Point(387, 229);
            this.lblIDPartida.Name = "lblIDPartida";
            this.lblIDPartida.Size = new System.Drawing.Size(131, 19);
            this.lblIDPartida.TabIndex = 16;
            this.lblIDPartida.Text = "Nome da Partida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(386, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Senha da Partida";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.txtSenhaPartida);
            this.panel2.Location = new System.Drawing.Point(326, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 36);
            this.panel2.TabIndex = 29;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.BackColor = System.Drawing.Color.Black;
            this.txtSenhaPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaPartida.Font = new System.Drawing.Font("Inter", 11.47F);
            this.txtSenhaPartida.ForeColor = System.Drawing.Color.White;
            this.txtSenhaPartida.Location = new System.Drawing.Point(13, 8);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(223, 19);
            this.txtSenhaPartida.TabIndex = 15;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.Black;
            this.btnCriarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPartida.FlatAppearance.BorderSize = 0;
            this.btnCriarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPartida.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.ForeColor = System.Drawing.Color.White;
            this.btnCriarPartida.Location = new System.Drawing.Point(360, 426);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(182, 41);
            this.btnCriarPartida.TabIndex = 30;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(802, 535);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(31, 25);
            this.panel4.TabIndex = 31;
            // 
            // FormularioCriarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 560);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIDPartida);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Inter ExtraLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(917, 599);
            this.MinimumSize = new System.Drawing.Size(917, 599);
            this.Name = "FormularioCriarPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIDPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Panel panel4;
    }
}