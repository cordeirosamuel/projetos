using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Utils;
using Titulo;


namespace TratamentoBancos
{
    public partial class Fm_Principal : Form
    {
        public Fm_Principal()
        {
            InitializeComponent();

            Arquivo.Apagar(); // Se já existir o arquivo "2", apaga.

            if (File.Exists(Arquivo.arquivoSeed))
            {
                Tb_Arquivo.Text = (Arquivo.arquivoSeed).ToString(); // Se já existir o arquivo SEED na pasta, exibe o caminho e nome do arquivo.
            }
            else
            {
                Btn_Iniciar.Enabled = false;
                Tb_Arquivo.Text = "Arquivo não existente";
            }
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {

            if (File.Exists(Arquivo.arquivoSeed))
            {
                Btn_Iniciar.Enabled = false;
                
                Corrigir.Correcao(); //Chama a função para iniciar a correção do arquivo

                // Define a barra de progresso
                progressBar1.Visible    = true;
                progressBar1.Maximum    = Corrigir.qtdLinhas;
                progressBar1.Value      = 0;

                for (int i = 0; i <= progressBar1.Maximum; i++)
                {
                    progressBar1.Value = i;
                }

                if (progressBar1.Value == progressBar1.Maximum)
                {
                    Lb_Concluido.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("O arquivo não existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*
            if (Corrigir.Inmetro != null)
            {
                textBox1.Text = ("Consta título do Inmetro");
            }*/


            // Exibe os títulos especiais (Direito de regresso e original), se existir.
            //textBox1.Text += String.Join("\r\n", Corrigir.tituloEspecial);

            StringBuilder sb = new StringBuilder(textBox1.Text);
            if (Corrigir.Inmetro != null)
            {
                sb.Append("Consta título do Inmetro");
            }
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            if (Corrigir.tituloEspecial != null)
            {
                sb.Append(textBox1.Text += String.Join("\r\n", Corrigir.tituloEspecial));
            }
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            textBox1.Text = sb.ToString();
        }
    }
}
