using Modelo;
using Persistencia.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico
{
    public class ItemServico
    {
        private ItemDAL itemDAL = new ItemDAL();
        public IQueryable<Item> ObterItemsClassificadosPorNome()
        {
            return itemDAL.ObterItemsClassificadosPorNome();
        }
        public Item ObterItemPorId(long id)
        {
            return itemDAL.ObterItemPorId(id);
        }
        public void GravarItem(Item item)
        {
            itemDAL.GravarItem(item);
        }
        public Item EliminarItemPorId(long id)
        {
            Item item = itemDAL.ObterItemPorId(id);
            itemDAL.EliminarItemPorId(id);
            return item;
        }
    }
}
