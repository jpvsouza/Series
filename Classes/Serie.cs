using System;
namespace Series

{
    public class Serie : EntidadeBase
    {
         //Atributos de cada série
         private Genero Genero  { get; set; } 
         private string Titulo { get; set; }
         private string Descricao { get; set; }
         private int Ano { get; set; }

         private bool Excluido { get; set;}

         //Método construtor
         public Serie(int id, Genero genero, string titulo, string descricao, int ano)
         {
             this.ID = id;
             this.Genero = genero;
             this.Titulo = titulo;
             this.Descricao = descricao;
             this.Ano = ano;
             this.Excluido = false;
         }

        //Sobrescrever o método ToString
        public override string ToString()
        {
            string retorno = "";
            retorno +="Gênero: "+this.Genero+Environment.NewLine;
            retorno +="Título: "+this.Titulo+Environment.NewLine;
            retorno +="Descrição: "+this.Descricao+Environment.NewLine;
            retorno +="Ano de Início: "+this.Ano + Environment.NewLine;
            retorno +="Excluído: "+this.Excluido;

            return retorno;
        }

        //Encapsulamento para retornar o título
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        //Encapsulamento para retornar o ID
        public int retornaID()
        {
            return this.ID;
        }

        //Marca o atributo excluido como true
        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}