using EJOGOS.Interface;
using System.Collections.Generic;
using System.IO;

namespace EJOGOS.Models
{
    public class Equipe : EquipeBase, IEquipes
    {


        public Equipe()
        {
            //Criando nossa pasta é arquivo;
            CriaPastaArquivo(caminho);
        }

        public int IdEquipe;
        public string Nome;
        public string Imagem;

        //Caminho do nosso BD
        private const string caminho = "Database/equipe.csv";

        //Transformando nossa equipe em um textor;
        public string EquipeTexto(Equipe e)
        {
            return $"{e.IdEquipe}; {e.Nome}; {e.Imagem};";
        }

        public void CriaEquipe(Equipe NovaEquipe)
        {
            //Transformando em um array de string
            string[] EquipeTextualizada = { EquipeTexto(NovaEquipe) };

            //Escrevendo no arquivo;
            File.AppendAllLines(caminho, EquipeTextualizada);
        }

        public List<Equipe> ListaEquipes()
        {
            List<Equipe> equipes = new List<Equipe>();

            string[] linhas = File.ReadAllLines(caminho);

            //percorrendo todas as linhas dentro do nosso arquivo banco;
            foreach (string linha in linhas)
            {
                //divindo em array cada linha do arquivo, com elas criamos nossa equipe e salvamos em nossa lista e retornamos para o nosso cliente;
                string[] conteudo = linha.Split(';');

                Equipe EquipeAtual = new Equipe();
                EquipeAtual.IdEquipe = int.Parse(conteudo[0]);
                EquipeAtual.Nome = conteudo[1];
                EquipeAtual.Imagem = conteudo[2];

                equipes.Add(EquipeAtual);
            }
            //devolvendo equipes;
            return equipes;
        }
    }
}
