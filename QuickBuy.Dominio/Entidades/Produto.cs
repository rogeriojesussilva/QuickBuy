using System;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }


        public Produto()
        {
        }

        public override void Validate()
        {
            LimparMensagensValidacao();
        }

    }
}
