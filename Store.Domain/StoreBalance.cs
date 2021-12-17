namespace Store.Domain
{
    public class StoreBalance
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int Count { get; set; }
    }
}
