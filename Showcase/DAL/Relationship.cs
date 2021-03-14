using System.Collections.Generic;
using System;
using System.Text;
using Models.Items;
using Models.Showcase;

namespace Showcase.Creator
{
    public class Relationship
    {
        private ICollection<IItem> items = new List<IItem>();
        private ICollection<IShowcase> showcases = new List<IShowcase>();
        public Relationship()
        {

        }
        public void MainMenu()
        {

        }
    }
}
