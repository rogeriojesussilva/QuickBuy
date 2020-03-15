using System;
namespace QuickBuy.Dominio
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public ItemPedido()
        {
        }
    }
}
