using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TratamentoBancos;
using Utils;
using static System.Windows.Forms.LinkLabel;

namespace Titulo
{
    internal class Corrigir
    {
        public static int contEspecial  = 0;
        public static int qtdLinhas     = File.ReadLines(Arquivo.arquivo1).Count();
        public static int qtdprot       = 0;
        public static string Inmetro    = null;
        public static List<string> tituloEspecial = new List<string>();
        public static List<string> cidadeErrada   = new List<string>();

        //public static string nroProtocolo = null;
        //public static string codComprovacao = null;
        public static string prot = null;

        public static void Correcao()
        {
            // Abre o arquivo "1" para verificar se tem Inmetro, se tiver, salva na variável
            using (StreamReader arquivo1 = File.OpenText(Arquivo.arquivo1))
            {
                string linhainmetro = null;

                while ((linhainmetro = arquivo1.ReadLine()) != null)
                {
                    if (linhainmetro.Contains("INMETRO"))
                    {
                        Inmetro = linhainmetro.Substring(19, 90);
                    }
                }
            }

            // Abre o arquivo do "SEED" e inicia as correções
            if (File.Exists(Arquivo.arquivoSeed))
            {

                var linha = "";

                using (StreamReader arquivo = File.OpenText(Arquivo.arquivoSeed))
                {

                    //Inicio - lista com a cidade escrito errado
                    cidadeErrada.Add("S PAULO             ");
                    cidadeErrada.Add("SP                  ");
                    cidadeErrada.Add("S O PAULO           ");
                    cidadeErrada.Add("S.PAULO             ");
                    cidadeErrada.Add("S. PAULO            ");
                    cidadeErrada.Add("SOPAULO             ");
                    cidadeErrada.Add("SAO APULO           ");
                    cidadeErrada.Add("SAOPAULO            ");
                    cidadeErrada.Add("SOA PAULO           ");
                    cidadeErrada.Add("S?O PAULO           ");
                    cidadeErrada.Add("SA PAULO            ");
                    cidadeErrada.Add("SAO  PAULO          ");
                    cidadeErrada.Add("SO PAULO            ");
                    cidadeErrada.Add("000000SAO PAULO     ");
                    cidadeErrada.Add("000000S O PAULO     ");
                    //Fim - lista com a cidade escrito errado


                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        string nroProtocolo = linha.Substring(453, 4);
                        string codComprovacao = linha.Substring(475, 3);
                        //prot = nroProtocolo;
                        // Percorre a lista com SAO PAULO escrito errado na praça de pagamento e na cidade e substitui pelo correto.
                        string cidadeCorreta = "SAO PAULO           ";

                        foreach (string c in cidadeErrada)
                        {
                            if (linha.Substring(274, 20) == c) // Praça de pagamento
                            {
                                linha = linha.Substring(0, 274) + cidadeCorreta + linha.Substring(294);
                            }

                            if (linha.Substring(423, 20) == c) // Cidade
                            {
                                linha = linha.Substring(0, 423) + cidadeCorreta + linha.Substring(443);
                            }
                        }

                        if (linha.Substring(274, 9) == "SAO PAULO" && linha.Substring(294, 11) != "           ")
                        {
                            linha = linha.Substring(0, 274) + cidadeCorreta + linha.Substring(294);
                        }

                        if (linha.Substring(423, 9) == "SAO PAULO" && linha.Substring(432, 11) != "           ")
                        {
                            linha = linha.Substring(0, 423) + cidadeCorreta + linha.Substring(443);
                        }
                        
                        string codPortador      = linha.Substring(0, 4);    //Captura o código do portador
                        string headerPortador   = linha.Substring(4, 40);   //Captura o nome do portador

                        // Corrige o nome da Ailos
                        string corrigeAilos = "COOPERATIVA CENTRAL DE CREDITO - AILOS  ";

                        if ((codPortador == "0085") || (codPortador == "9085"))
                        {
                            linha = linha.Replace(headerPortador, corrigeAilos);
                        }

                        // Corrige o nome da SABESP
                        string corrigeSabesp = "CIA.SANEAMENTO BASICO ESTADO DE S.P. - S";

                        if ((codPortador == "0EGW") || (codPortador == "9EGW"))
                        {
                            linha = linha.Replace(headerPortador, corrigeSabesp);
                        }

                        // Corrige o nome do Inmetro
                        if ((codPortador == "1888") && (Inmetro != null) && (linha.Substring(19, 26) == "PROCURADORIA GERAL FEDERAL"))
                        {
                            linha = linha.Substring(0, 19) + Inmetro + linha.Substring(109);
                        }

                        // Corrige o nome da Comgás
                        string CorrigeComgas = "COMPANHIA DE GAS DE SAO PAULO COMGAS    ";

                        if ((codPortador == "0915") || (codPortador == "9915"))
                        {
                            linha = linha.Replace(headerPortador, CorrigeComgas);
                        }

                        //Procura títulos com direito de regresso, comprovante original, comprovação do portador errada


                        if (codComprovacao == "0R0")
                        {
                            tituloEspecial.Add("Direito de regresso " + nroProtocolo);
                        }

                        if (codComprovacao == "0A0")
                        {
                            tituloEspecial.Add("Verificar original " + nroProtocolo);
                        }

                        if (codComprovacao == "000")
                        {
                            linha = linha.Substring(0, 475) + "0A0" + linha.Substring(478);
                            tituloEspecial.Add("Msg portador incorreta " + nroProtocolo);
                        }
                        prot = nroProtocolo;

                        Arquivo.Gravar(linha);
                    }
                }
            }
            //IMPLEMENTAR
            //Arquivo.Backup(); 
        }
    }
}
