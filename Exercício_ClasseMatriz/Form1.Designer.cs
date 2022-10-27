namespace Exercício_ClasseMatriz
{
    partial class Form1
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
            this.btnExibeMat = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblResTrans = new System.Windows.Forms.Label();
            this.btnExibeTrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExibeMat
            // 
            this.btnExibeMat.Location = new System.Drawing.Point(31, 63);
            this.btnExibeMat.Name = "btnExibeMat";
            this.btnExibeMat.Size = new System.Drawing.Size(75, 23);
            this.btnExibeMat.TabIndex = 0;
            this.btnExibeMat.Text = "Exibir Matriz";
            this.btnExibeMat.UseVisualStyleBackColor = true;
            this.btnExibeMat.Click += new System.EventHandler(this.btnExibeMat_Click);
            // 
            // lblRes
            // 
            this.lblRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(133, 63);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(10, 13);
            this.lblRes.TabIndex = 1;
            this.lblRes.Text = ".";
            // 
            // lblResTrans
            // 
            this.lblResTrans.AutoSize = true;
            this.lblResTrans.Location = new System.Drawing.Point(154, 147);
            this.lblResTrans.Name = "lblResTrans";
            this.lblResTrans.Size = new System.Drawing.Size(10, 13);
            this.lblResTrans.TabIndex = 3;
            this.lblResTrans.Text = ".";
            // 
            // btnExibeTrans
            // 
            this.btnExibeTrans.Location = new System.Drawing.Point(31, 126);
            this.btnExibeTrans.Name = "btnExibeTrans";
            this.btnExibeTrans.Size = new System.Drawing.Size(75, 34);
            this.btnExibeTrans.TabIndex = 2;
            this.btnExibeTrans.Text = "Exibir Transposta";
            this.btnExibeTrans.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.lblResTrans);
            this.Controls.Add(this.btnExibeTrans);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnExibeMat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExibeMat;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblResTrans;
        private System.Windows.Forms.Button btnExibeTrans;
    }
}

