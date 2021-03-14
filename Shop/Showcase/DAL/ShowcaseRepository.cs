using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Models.Items;
using Models.Showcase;
using Models;
namespace Showcase.Creator
{
    class ShowcaseRepository : IShowcaseRepository
    {
        private List<IShowcase> showcases = new List<IShowcase>(); // IShowcaseRepository
        private List<IShowcaseItem> items = new List<IShowcaseItem>(); // IShowcaseRepository
        public IEnumerable Showcases { get => showcases; } // IShowcaseRepository

        public void Add(Shop showcase)
        {
            IResult result =  showcase.Validate();
            if (result.Check == true)
                showcases.Add(showcase);
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public IEnumerable<Shop> All()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Shop GetById(int id)
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

        public void Update(Shop entity)
        {
            throw new NotImplementedException();
        }
    }
}
