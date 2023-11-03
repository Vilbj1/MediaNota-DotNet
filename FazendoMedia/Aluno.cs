using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendoMedia
{
    public class Aluno
    {
        // Aqui estou criando atributos para o nome de um futuro objeto
        public required string nome;

        public double nota1, nota2;

        //a partir daqui, métodos criados para a média e situação do aluno

        //média
        public double media()
        {
            return (nota1 + nota2)/2;
        }
        //situação
        public string situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }

        //Mensagem
        public void mensagem()
        {
            //Obtendo a media
            double obterMedia = media();

            //Obter a situação
            string obterSituacao = situacao(obterMedia);

            //Mensagem
            Console.WriteLine(nome + " está " + obterSituacao + " com média " + obterMedia);
        }
    }
}
