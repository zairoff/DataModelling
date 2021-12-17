using System;
using System.Collections.Generic;
using System.Linq;
namespace Store.Domain
{
    public class Income
    {
        public int Id { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int Count { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
