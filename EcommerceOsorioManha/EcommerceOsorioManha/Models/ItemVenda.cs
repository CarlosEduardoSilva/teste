using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceOsorioManha.Models
{
    public class ItemVenda
    {
        public int ItemVendaId { get; set; }

        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public DateTime Data { get; set; }

        public string CarrinhoId { get; set; }

    }
}