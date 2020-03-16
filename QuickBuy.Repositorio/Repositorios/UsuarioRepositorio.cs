using System;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.Contratos;

namespace QuickBuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Produto>, IUsuarioRepositorio
    {
        public UsuarioRepositorio()
        {
        }
    }
}
