namespace ControleImpressoes
{
    partial class ConsultarHistorico
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
            this.EnviarHistorico = new System.Windows.Forms.Button();
            this.NomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHistorico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // EnviarHistorico
            // 
            this.EnviarHistorico.BackColor = System.Drawing.SystemColors.Highlight;
            this.EnviarHistorico.ForeColor = System.Drawing.SystemColors.Control;
            this.EnviarHistorico.Location = new System.Drawing.Point(247, 260);
            this.EnviarHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.EnviarHistorico.Name = "EnviarHistorico";
            this.EnviarHistorico.Size = new System.Drawing.Size(81, 43);
            this.EnviarHistorico.TabIndex = 20;
            this.EnviarHistorico.Text = "Consultar";
            this.EnviarHistorico.UseVisualStyleBackColor = false;
            this.EnviarHistorico.Click += new System.EventHandler(this.EnviarHistorico_Click);
            // 
            // NomeAluno
            // 
            this.NomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NomeAluno.Location = new System.Drawing.Point(149, 102);
            this.NomeAluno.Margin = new System.Windows.Forms.Padding(2);
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.Size = new System.Drawing.Size(217, 20);
            this.NomeAluno.TabIndex = 19;
            this.NomeAluno.Text = "Nome...";
            this.NomeAluno.TextChanged += new System.EventHandler(this.NomeAluno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Digite o nome do aluno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.label1.Size = new System.Drawing.Size(424, 62);
            this.label1.TabIndex = 17;
            this.label1.Text = "=== Para consultar Histórico ===";
            // 
            // dataGridViewHistorico
            // 
            this.dataGridViewHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorico.Location = new System.Drawing.Point(89, 144);
            this.dataGridViewHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHistorico.Name = "dataGridViewHistorico";
            this.dataGridViewHistorico.RowHeadersWidth = 51;
            this.dataGridViewHistorico.RowTemplate.Height = 24;
            this.dataGridViewHistorico.Size = new System.Drawing.Size(398, 101);
            this.dataGridViewHistorico.TabIndex = 24;
            this.dataGridViewHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistorico_CellContentClick);
            // 
            // ConsultarHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridViewHistorico);
            this.Controls.Add(this.EnviarHistorico);
            this.Controls.Add(this.NomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarHistorico";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.ConsultarHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EnviarHistorico;
        private System.Windows.Forms.TextBox NomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHistorico;
    }
}