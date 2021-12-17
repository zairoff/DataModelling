namespace Store.Domain
{
    public class Item
    {
        public int Id { get; set; }

        public int ItemTypeId { get; set; }

        public ItemType ItemType { get; set; }

        public string Name { get; set; }

        public string Characteristics { get; set; }
    }
}
