namespace Core.Entities {
    public class FoodEntity : BaseEntity {
        public string Ingredients { get; set; }
        public string Preparation { get; set; }
        public string Comment { get; set; }
        public string Genre { get; set; }
        public string Category { get; set; }
        public byte[] Picture { get; set; }
    }
}