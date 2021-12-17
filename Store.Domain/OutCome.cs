using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Store.Domain
{
    public class OutCome
    {
        public int Id { get; set; }

        public int FactoryId { get; set; }

        public Factory Factory { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int Count { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
