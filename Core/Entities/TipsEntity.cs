namespace Core.Entities {
    public class TipsEntity : BaseEntity {
        public string type { get; set; }
        public string text { get; set; }
        public byte[] Picture { get; set; }
    }
}
