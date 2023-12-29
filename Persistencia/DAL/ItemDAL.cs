using Modelo;
using Persistencia.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL
{
    public class ItemDAL
    {
        private EFContext context = new EFContext();
        public IQueryable<Item> ObterItemsClassificadosPorNome()
        {
            return context.Items.OrderBy(b => b.Nome);
        }
        public Item ObterItemPorId(long id)
        {
            return context.Items.Where(f => f.ItemId == id).First();
        }
        public void GravarItem(Item item)
        {
            if (item.ItemId == 0)
            {
                context.Items.Add(item);
            }
            else
            {
                context.Entry(item).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public Item EliminarItemPorId(long id)
        {
            Item item = ObterItemPorId(id);
            context.Items.Remove(item);
            context.SaveChanges();
            return item;
        }
    }
}
