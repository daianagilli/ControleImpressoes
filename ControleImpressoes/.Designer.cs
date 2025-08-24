namespace ControleImpressoes
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EnviarImprimir = new System.Windows.Forms.Button();
            this.NomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPaginas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaginas)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantas páginas deseja imprimir?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "25",
            "50"});
            this.comboBox1.Location = new System.Drawing.Point(287, 202);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // EnviarImprimir
            // 
            this.EnviarImprimir.BackColor = System.Drawing.SystemColors.Highlight;
            this.EnviarImprimir.ForeColor = System.Drawing.SystemColors.Control;
            this.EnviarImprimir.Location = new System.Drawing.Point(245, 257);
            this.EnviarImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.EnviarImprimir.Name = "EnviarImprimir";
            this.EnviarImprimir.Size = new System.Drawing.Size(97, 43);
            this.EnviarImprimir.TabIndex = 13;
            this.EnviarImprimir.Text = "Imprimir";
            this.EnviarImprimir.UseVisualStyleBackColor = false;
            this.EnviarImprimir.Click += new System.EventHandler(this.EnviarImprimir_Click);
            // 
            // NomeAluno
            // 
            this.NomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NomeAluno.Location = new System.Drawing.Point(167, 166);
            this.NomeAluno.Margin = new System.Windows.Forms.Padding(2);
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.Size = new System.Drawing.Size(233, 20);
            this.NomeAluno.TabIndex = 12;
            this.NomeAluno.Text = "Nome...";
            this.NomeAluno.TextChanged += new System.EventHandler(this.NomeAluno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite o nome do aluno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(142, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.label1.Size = new System.Drawing.Size(320, 62);
            this.label1.TabIndex = 10;
            this.label1.Text = "Para realizar Impressões:";
            // 
            // numericUpDownPaginas
            // 
            this.numericUpDownPaginas.Location = new System.Drawing.Point(399, 203);
            this.numericUpDownPaginas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPaginas.Name = "numericUpDownPaginas";
            this.numericUpDownPaginas.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownPaginas.TabIndex = 16;
            this.numericUpDownPaginas.ValueChanged += new System.EventHandler(this.numericUpDownPaginas_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.numericUpDownPaginas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EnviarImprimir);
            this.Controls.Add(this.NomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaginas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button EnviarImprimir;
        private System.Windows.Forms.TextBox NomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPaginas;
    }
}