namespace ControleImpressoes
{
    partial class ComprarImpressoes
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
            this.EnviarCompra = new System.Windows.Forms.Button();
            this.NomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EnviarCompra
            // 
            this.EnviarCompra.BackColor = System.Drawing.SystemColors.Highlight;
            this.EnviarCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.EnviarCompra.Location = new System.Drawing.Point(217, 258);
            this.EnviarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.EnviarCompra.Name = "EnviarCompra";
            this.EnviarCompra.Size = new System.Drawing.Size(125, 43);
            this.EnviarCompra.TabIndex = 7;
            this.EnviarCompra.Text = "Confirmar compra";
            this.EnviarCompra.UseVisualStyleBackColor = false;
            this.EnviarCompra.Click += new System.EventHandler(this.EnviarCompra_Click);
            // 
            // NomeAluno
            // 
            this.NomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NomeAluno.Location = new System.Drawing.Point(162, 162);
            this.NomeAluno.Margin = new System.Windows.Forms.Padding(2);
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.Size = new System.Drawing.Size(233, 20);
            this.NomeAluno.TabIndex = 6;
            this.NomeAluno.Text = "Nome...";
            this.NomeAluno.TextChanged += new System.EventHandler(this.NomeAluno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite o nome do aluno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(137, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.label1.Size = new System.Drawing.Size(331, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Para comprar impressões:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Escolha o pacote:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ComprarImpressoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnviarCompra);
            this.Controls.Add(this.NomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ComprarImpressoes";
            this.Text = "COMPRAR";
            this.Load += new System.EventHandler(this.ComprarImpressoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnviarCompra;
        private System.Windows.Forms.TextBox NomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}