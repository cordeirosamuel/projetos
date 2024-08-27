using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    internal class Arquivo
    {
        public static string arquivo1           = CaminhoArquivo() + "DC08" + Data() + "." + Ano() + "1";
        public static string arquivoSeed        = CaminhoArquivo() + "DC08" + Data() + "." + Ano() + "9";
        public static string arquivoCopia       = CaminhoArquivo() + "DC08" + Data() + "." + Ano() + "2";
        public static string backup             = CaminhoBackup()  + AnoCompleto() + @"\"; //Verificar porque não reconhece o caminho
        public static string Data()
        {
            string dia = DateTime.Now.ToString(dia = "dd");
            string mes = DateTime.Now.ToString(mes = "MM");
            return dia + mes;
        }

        public static string Ano()
        {
            string ano = DateTime.Now.ToString(ano = "yy");
            return ano;
        }

        public static string AnoCompleto()
        {
            string anoCompleto = DateTime.Now.ToString(anoCompleto = "yyyy");
            return anoCompleto;
        }

        public static string CaminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }
        public static string CaminhoBackup()
        {
            return ConfigurationManager.AppSettings["CaminhoBackup"];
        }

        public static void Apagar()
        {           
            if (File.Exists(arquivoCopia))
            {
                File.Delete(arquivoCopia);
            }
        }

        public static void Gravar(string correcao)
        {
            try
            {
                StreamWriter gravar = new StreamWriter(arquivoCopia, true);
               
                foreach (string linha in correcao.Split('\n'))
                {
                    gravar.Flush();
                    gravar.WriteLine(linha);
                    gravar.Flush();
                }
                gravar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação do arquivo: " + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Backup()
        {
            if (File.Exists(arquivoCopia))
            {
                File.Copy(arquivoCopia, backup);
            }
        }
    }
}
