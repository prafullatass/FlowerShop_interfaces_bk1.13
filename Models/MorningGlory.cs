namespace FlowerShop
{
    public class MorningGlory : IIMothersDay
    {
        public string Color {get;set; }
        public string Type {get;set; }
        public int PetalCount {get;set; }
        public double StemLength {get;set; }
        public bool Thorny {get;set;}
        public int Size { get ; set; }

        public override string ToString() {
            return "A Pleasent Morning Glory";
        }
    }
}