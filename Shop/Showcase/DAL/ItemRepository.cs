using System;
using System.Collections.Generic;
using System.Text;
using Models.Items;
using Models.Showcase;
namespace Showcase.Creator
{
    class ItemRepository : IItemRepository
    {
        List<IShowcaseItem> items = new List<IShowcaseItem>();
        public void Add(Item entity)
        {

        }

        public IEnumerable<Item> All()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Item GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Seed(int count)
        {
            throw new NotImplementedException();
        }

        public void Update(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}
