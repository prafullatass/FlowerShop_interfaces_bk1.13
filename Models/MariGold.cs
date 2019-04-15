namespace FlowerShop
{
    public class MariGold : IBirthday
    {
        public string Color {get;set; }
        public string Type {get;set; }
        public int PetalCount {get;set; }
        public double StemLength {get;set; }
        public bool Thorny {get;set;}
        public override string ToString() {
            return "A Ferocious MariGold";
        }
    }
}