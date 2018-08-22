using EcommerceOsorioManha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceOsorioManha.DAL
{
    public class ItemVendaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static void CadastrarItemVenda(ItemVenda itemVenda)
        {
            ctx.ItensVenda.Add(itemVenda);
            ctx.SaveChanges();
        }

        public static List<ItemVenda> BuscarItensVendaPorCarrinhoId(string carrinhoId)
        {
            return ctx.ItensVenda.Include("Produto").Where(x => x.CarrinhoId.Equals(carrinhoId)).ToList();
        }
        public static void RemoverItem(int id)
        {
            ctx.ItensVenda.Remove(BuscaItemPorId(id));
            ctx.SaveChanges();
        }

        private static ItemVenda BuscaItemPorId(int id)
        {
           return ctx.ItensVenda.Find(id);
        }
    }
}