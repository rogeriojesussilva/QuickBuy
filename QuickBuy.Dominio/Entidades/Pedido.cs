using System;
using System.Collections.Generic;
using System.Linq;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public String EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public Pedido()
        {
        }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
            {
                MensagemValidacao.Add("O Pedido não pode ficar se Itens de Pedido.");
            }

            if (string.IsNullOrEmpty(CEP))
            {
                MensagemValidacao.Add("O CEP deve ser informado.");

            }

            if (string.IsNullOrEmpty(CEP))
            {
                MensagemValidacao.Add("O CEP deve ser informado.");

            }
        }
    }
}
