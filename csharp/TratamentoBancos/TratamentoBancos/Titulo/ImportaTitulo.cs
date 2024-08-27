using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportaArquivoDC.Titulos
{
    class ImportaTitulo
    {
        //Construtores do Portador
        public string titulocontrolearquivo { get; set; }
        public string tituloportadorcodh { get; set; }
        public string tituloportadornome { get; set; }
        public string titulodataapresentacao { get; set; }

        public string Tituloportadorcod { get; set; }
        public string Tituloportadornome { get; set; }
        public string Titulodataapresentacao { get; set; }

        //Construtores do Titulo
        public string Tituloagcodcedente { get; set; }
        public string Titulofavorecido { get; set; }
        public string Titulosacadornome { get; set; }
        public string Titulosacadordocumento { get; set; }
        public string Titulosacadorendereco { get; set; }
        public string Titulosacadorcep { get; set; }
        public string Titulosacadorcidade { get; set; }
        public string Titulosacadoruf { get; set; }
        public string Titulonossonumero { get; set; }
        public string Especiecod { get; set; }
        public string Titulonumero { get; set; }
        public string Tituloemissao { get; set; }
        public string Titulovencimento { get; set; }
        public string Moedacod { get; set; }
        public Decimal Titulovalor { get; set; }
        public Decimal Titulosaldo { get; set; }
        public string Titulopracapagto { get; set; }
        public string Tipoendossocod { get; set; }
        public string Tituloaceito { get; set; }
        public string Seqdevedor { get; set; }

        //Construtores do Devedor
        public string Titulodevedornome { get; set; }
        public string Titulodevedortipodoc { get; set; }
        public string Titulodevedorcpf { get; set; }
        public string Titulodevedorrg { get; set; }

        //Construtores do Endereco
        public string Titulodevedorenderecodescr { get; set; }
        public string Titulodevedorenderecocep { get; set; }
        public string Titulodevedorenderecocidadenome { get; set; }
        public string Titulodevedorenderecoestado { get; set; }

        //Construtores do Titulo - parte 2
        public string Tituloprotocolo { get; set; }
        public string Titulodataentrada { get; set; }
        public string Msgportadorcod { get; set; }
        public string Titulodevedorenderecobairro { get; set; }
        public string Titulofalencia { get; set; }
        public string Seqregistro { get; set; }



        public ImportaTitulo(string tituloportadorcod, string tituloagcodcedente, string titulofavorecido, string titulosacadornome, string titulosacadordocumento, string titulosacadorendereco, string titulosacadorcep, string titulosacadorcidade, string titulosacadoruf, string titulonossonumero, string especiecod, string titulonumero, string tituloemissao, string titulovencimento, string moedacod, string titulovalor, string titulosaldo, string titulopracapagto, string tipoendossocod, string tituloaceito, string seqdevedor, string titulodevedornome, string titulodevedortipodoc, string titulodevedorcpf, string titulodevedorrg, string titulodevedorenderecodescr, string titulodevedorenderecocep, string titulodevedorenderecocidadenome, string titulodevedorenderecoestado, string tituloprotocolo, string titulodataentrada, string msgportadorcod, string titulodevedorenderecobairro, string titulofalencia, string seqregistro)
        {
            this.Tituloportadorcod = tituloportadorcod;
            this.Tituloagcodcedente = tituloagcodcedente;
            this.Titulofavorecido = titulofavorecido;
            this.Titulosacadornome = titulosacadornome;
            this.Titulosacadordocumento = titulosacadordocumento;
            this.Titulosacadorendereco = titulosacadorendereco;
            this.Titulosacadorcep = titulosacadorcep;
            this.Titulosacadorcidade = titulosacadorcidade;
            this.Titulosacadoruf = titulosacadoruf;
            this.Titulonossonumero = titulonossonumero;
            this.Especiecod = especiecod;
            this.Titulonumero = titulonumero;
            this.Tituloemissao = tituloemissao.Substring(0, 2) + "/" + tituloemissao.Substring(2, 2) + "/" + tituloemissao.Substring(4, 4);
            this.Titulovencimento = titulovencimento.Substring(0, 2) + "/" + titulovencimento.Substring(2, 2) + "/" + titulovencimento.Substring(4, 4);
            this.Moedacod = moedacod;
            this.Titulovalor = Convert.ToDecimal(titulovalor.Substring(0, 12) + "," + titulovalor.Substring(12, 2));
            this.Titulosaldo = Convert.ToDecimal(titulosaldo.Substring(0, 12) + "," + titulosaldo.Substring(12, 2)); ;
            this.Titulopracapagto = titulopracapagto;
            this.Tipoendossocod = tipoendossocod;
            this.Tituloaceito = tituloaceito;
            this.Seqdevedor = seqdevedor;
            this.Titulodevedornome = titulodevedornome;
            this.Titulodevedortipodoc = titulodevedortipodoc;
            this.Titulodevedorcpf = titulodevedorcpf;
            this.Titulodevedorrg = titulodevedorrg;
            this.Titulodevedorenderecodescr = titulodevedorenderecodescr;
            this.Titulodevedorenderecocep = titulodevedorenderecocep;
            this.Titulodevedorenderecocidadenome = titulodevedorenderecocidadenome;
            this.Titulodevedorenderecoestado = titulodevedorenderecoestado;
            this.Tituloprotocolo = tituloprotocolo;
            this.Titulodataentrada = titulodataentrada.Substring(0, 2) + "/" + titulodataentrada.Substring(2, 2) + "/" + titulodataentrada.Substring(4, 4);
            this.Msgportadorcod = msgportadorcod;
            this.Titulodevedorenderecobairro = titulodevedorenderecobairro;
            this.Titulofalencia = titulofalencia;
            this.Seqregistro = seqregistro;
        }

    }
}
