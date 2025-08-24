namespace ControleImpressoes
{
    partial class FormMenu
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
            this.cadastrar = new System.Windows.Forms.Button();
            this.Comprar = new System.Windows.Forms.Button();
            this.Imprimir = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.ConsultarHistorico = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "--- Sistema de Impressões ---";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cadastrar
            // 
            this.cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cadastrar.BackColor = System.Drawing.Color.SteelBlue;
            this.cadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cadastrar.Location = new System.Drawing.Point(223, 109);
            this.cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.cadastrar.Size = new System.Drawing.Size(155, 46);
            this.cadastrar.TabIndex = 1;
            this.cadastrar.Text = "Cadastrar Novo Aluno";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // Comprar
            // 
            this.Comprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Comprar.BackColor = System.Drawing.Color.SteelBlue;
            this.Comprar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Comprar.Location = new System.Drawing.Point(223, 169);
            this.Comprar.Margin = new System.Windows.Forms.Padding(2);
            this.Comprar.Name = "Comprar";
            this.Comprar.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.Comprar.Size = new System.Drawing.Size(155, 50);
            this.Comprar.TabIndex = 2;
            this.Comprar.Text = "Comprar Impressão";
            this.Comprar.UseVisualStyleBackColor = false;
            this.Comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // Imprimir
            // 
            this.Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Imprimir.BackColor = System.Drawing.Color.SteelBlue;
            this.Imprimir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Imprimir.Location = new System.Drawing.Point(223, 231);
            this.Imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.Imprimir.Size = new System.Drawing.Size(155, 51);
            this.Imprimir.TabIndex = 3;
            this.Imprimir.Text = "Realizar Impressão";
            this.Imprimir.UseVisualStyleBackColor = false;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // Consultar
            // 
            this.Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Consultar.BackColor = System.Drawing.Color.SteelBlue;
            this.Consultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Consultar.Location = new System.Drawing.Point(223, 296);
            this.Consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.Consultar.Size = new System.Drawing.Size(155, 53);
            this.Consultar.TabIndex = 4;
            this.Consultar.Text = "Consultar Saldo dos Alunos";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // ConsultarHistorico
            // 
            this.ConsultarHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ConsultarHistorico.BackColor = System.Drawing.Color.SteelBlue;
            this.ConsultarHistorico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConsultarHistorico.Location = new System.Drawing.Point(223, 368);
            this.ConsultarHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultarHistorico.Name = "ConsultarHistorico";
            this.ConsultarHistorico.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.ConsultarHistorico.Size = new System.Drawing.Size(155, 44);
            this.ConsultarHistorico.TabIndex = 5;
            this.ConsultarHistorico.Text = "Consultar Histórico";
            this.ConsultarHistorico.UseVisualStyleBackColor = false;
            this.ConsultarHistorico.Click += new System.EventHandler(this.ConsultarHistorico_Click);
            // 
            // Sair
            // 
            this.Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Sair.BackColor = System.Drawing.Color.SteelBlue;
            this.Sair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sair.Location = new System.Drawing.Point(267, 431);
            this.Sair.Margin = new System.Windows.Forms.Padding(2);
            this.Sair.Name = "Sair";
            this.Sair.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.Sair.Size = new System.Drawing.Size(64, 37);
            this.Sair.TabIndex = 6;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(580, 508);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.ConsultarHistorico);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.Comprar);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button Comprar;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button ConsultarHistorico;
        private System.Windows.Forms.Button Sair;
    }
}

