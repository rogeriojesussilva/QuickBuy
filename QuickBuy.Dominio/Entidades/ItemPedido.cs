﻿using System;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Dominio
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public ItemPedido()
        {
        }

        public override void Validate()
        {
            LimparMensagensValidacao();
        }
    }
}