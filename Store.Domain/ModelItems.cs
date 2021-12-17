using System;
using System.Collections.Generic;
using System.Linq;
namespace Store.Domain
{
    public class ModelItems
    {
        public int Id { get; set; }

        public int ModelId { get; set; }

        public Model Model { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int Count { get; set; }
    }
}
