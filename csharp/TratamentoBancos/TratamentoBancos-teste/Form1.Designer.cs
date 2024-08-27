namespace TratamentoBancos
{
    partial class Fm_Principal
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
            this.Tb_Arquivo = new System.Windows.Forms.TextBox();
            this.Btn_Iniciar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Lb_Concluido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correção dos arquivos do CRA";
            // 
            // Tb_Arquivo
            // 
            this.Tb_Arquivo.Enabled = false;
            this.Tb_Arquivo.Location = new System.Drawing.Point(29, 64);
            this.Tb_Arquivo.Name = "Tb_Arquivo";
            this.Tb_Arquivo.Size = new System.Drawing.Size(245, 20);
            this.Tb_Arquivo.TabIndex = 1;
            // 
            // Btn_Iniciar
            // 
            this.Btn_Iniciar.Location = new System.Drawing.Point(29, 99);
            this.Btn_Iniciar.Name = "Btn_Iniciar";
            this.Btn_Iniciar.Size = new System.Drawing.Size(93, 23);
            this.Btn_Iniciar.TabIndex = 3;
            this.Btn_Iniciar.Text = "Iniciar processo";
            this.Btn_Iniciar.UseVisualStyleBackColor = true;
            this.Btn_Iniciar.Click += new System.EventHandler(this.Btn_Iniciar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 152);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(325, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            // 
            // Lb_Concluido
            // 
            this.Lb_Concluido.AutoSize = true;
            this.Lb_Concluido.Location = new System.Drawing.Point(30, 136);
            this.Lb_Concluido.Name = "Lb_Concluido";
            this.Lb_Concluido.Size = new System.Drawing.Size(102, 13);
            this.Lb_Concluido.TabIndex = 5;
            this.Lb_Concluido.Text = "Processo concluído";
            this.Lb_Concluido.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(325, 157);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "";
            // 
            // Fm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 351);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lb_Concluido);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Btn_Iniciar);
            this.Controls.Add(this.Tb_Arquivo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Fm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamento magnéticos - Beta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Arquivo;
        private System.Windows.Forms.Button Btn_Iniciar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Lb_Concluido;
        public System.Windows.Forms.RichTextBox textBox1;
    }
}

