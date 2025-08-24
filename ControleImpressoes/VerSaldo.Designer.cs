namespace ControleImpressoes
{
    partial class VerSaldo
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
            this.EnviarSaldo = new System.Windows.Forms.Button();
            this.NomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSaldo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // EnviarSaldo
            // 
            this.EnviarSaldo.BackColor = System.Drawing.SystemColors.Highlight;
            this.EnviarSaldo.ForeColor = System.Drawing.SystemColors.Control;
            this.EnviarSaldo.Location = new System.Drawing.Point(221, 293);
            this.EnviarSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.EnviarSaldo.Name = "EnviarSaldo";
            this.EnviarSaldo.Size = new System.Drawing.Size(125, 43);
            this.EnviarSaldo.TabIndex = 13;
            this.EnviarSaldo.Text = "Consultar";
            this.EnviarSaldo.UseVisualStyleBackColor = false;
            this.EnviarSaldo.Click += new System.EventHandler(this.EnviarSaldo_Click);
            // 
            // NomeAluno
            // 
            this.NomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NomeAluno.Location = new System.Drawing.Point(165, 122);
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
            this.label2.Location = new System.Drawing.Point(163, 98);
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
            this.label1.Location = new System.Drawing.Point(93, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.label1.Size = new System.Drawing.Size(395, 62);
            this.label1.TabIndex = 10;
            this.label1.Text = "=== Para consultar saldos ===";
            // 
            // dataGridViewSaldo
            // 
            this.dataGridViewSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaldo.Location = new System.Drawing.Point(122, 162);
            this.dataGridViewSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSaldo.Name = "dataGridViewSaldo";
            this.dataGridViewSaldo.RowHeadersWidth = 51;
            this.dataGridViewSaldo.RowTemplate.Height = 24;
            this.dataGridViewSaldo.Size = new System.Drawing.Size(333, 106);
            this.dataGridViewSaldo.TabIndex = 14;
            this.dataGridViewSaldo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSaldo_CellContentClick);
            // 
            // VerSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridViewSaldo);
            this.Controls.Add(this.EnviarSaldo);
            this.Controls.Add(this.NomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerSaldo";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.VerSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EnviarSaldo;
        private System.Windows.Forms.TextBox NomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSaldo;
    }
}