namespace ControleImpressoes
{
    partial class CadastrarAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeAluno = new System.Windows.Forms.TextBox();
            this.EnviarAluno = new System.Windows.Forms.Button();
            this.MatriculaAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.label1.Size = new System.Drawing.Size(319, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para o cadastrar o aluno:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o nome do aluno:";
            // 
            // NomeAluno
            // 
            this.NomeAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NomeAluno.Location = new System.Drawing.Point(50, 140);
            this.NomeAluno.Margin = new System.Windows.Forms.Padding(2);
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.Size = new System.Drawing.Size(233, 20);
            this.NomeAluno.TabIndex = 2;
            this.NomeAluno.Text = "Nome...";
            this.NomeAluno.TextChanged += new System.EventHandler(this.NomeAluno_TextChanged);
            // 
            // EnviarAluno
            // 
            this.EnviarAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EnviarAluno.BackColor = System.Drawing.SystemColors.Highlight;
            this.EnviarAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.EnviarAluno.Location = new System.Drawing.Point(109, 237);
            this.EnviarAluno.Margin = new System.Windows.Forms.Padding(2);
            this.EnviarAluno.Name = "EnviarAluno";
            this.EnviarAluno.Size = new System.Drawing.Size(84, 33);
            this.EnviarAluno.TabIndex = 3;
            this.EnviarAluno.Text = "Salvar";
            this.EnviarAluno.UseVisualStyleBackColor = false;
            this.EnviarAluno.Click += new System.EventHandler(this.EnviarAluno_Click);
            // 
            // MatriculaAluno
            // 
            this.MatriculaAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MatriculaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MatriculaAluno.Location = new System.Drawing.Point(50, 202);
            this.MatriculaAluno.Margin = new System.Windows.Forms.Padding(2);
            this.MatriculaAluno.Name = "MatriculaAluno";
            this.MatriculaAluno.Size = new System.Drawing.Size(233, 20);
            this.MatriculaAluno.TabIndex = 4;
            this.MatriculaAluno.Text = "Matricula...";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite a matrícula do aluno:";
            // 
            // CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MatriculaAluno);
            this.Controls.Add(this.EnviarAluno);
            this.Controls.Add(this.NomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastrarAluno";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeAluno;
        private System.Windows.Forms.Button EnviarAluno;
        private System.Windows.Forms.TextBox MatriculaAluno;
        private System.Windows.Forms.Label label3;
    }
}