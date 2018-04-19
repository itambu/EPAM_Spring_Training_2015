using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Gift
    {
        private ICollection<Item> _items;
        private ICollection<Provider> _providers;


        public IEnumerable<Item> GetOrderedById()
        {
            return GetOrderedItems(x=>x.Id);
        }

        protected IEnumerable<Item> 
            GetOrderedItems<Key>(Func<Item, Key> keySelector)
        {
            return _items.OrderBy(keySelector);
        }

        public IEnumerable<Item> GetItems()
        {
            var query =
                from item in
                    (from x in _items
                     join y in _providers on
                         x.ProviderId equals y.Id
                     select new
                     {
                         ItemName = x.Name,
                         ProviderName = y.Name
                     })
                group item by item.ItemName
                    into g
                    select new { ItemName = g.Key, 
                        Providers = g.Select(x => x.ProviderName)
                        .ToArray() };
                
                
                
                _items
                .Where(x => (x.Id % 2 == 0))
                .Select(x => new { Id = x.Id, Name = "" })
                ;
        }
    }
}
