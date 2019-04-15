using System.Collections.Generic;

namespace FlowerShop
{
    public class FlowerShop
    {
        public string ShopName {get;set; }
        public string OpeningTime {get;set; }
        public string ClosingTime {get;set; }
        public List<Rose> Roses {get;set; } =new List<Rose>();
        public List<Tulip> Tulips {get;set; } =new List<Tulip>();
        public List<MariGold> MariGolds {get;set; } =new List<MariGold>();
        public List<MorningGlory> MorningGlorys {get;set; } =new List<MorningGlory>();

        public List<IIMothersDay> MakeMothersDayArragement () {
            List<IIMothersDay> arragement = new List<IIMothersDay>(){
                new Tulip(),
                new Tulip(),
                new Tulip(),
                new MorningGlory(),
                new MorningGlory(),
            };
            return arragement;
        }
        public List<IBirthday> MakeBirthDayArragement () {
            List<IBirthday> arragement = new List<IBirthday>(){
                new Rose(),
                new Rose(),
                new Rose(),
                new MariGold(),
                new MariGold(),
            };
            return arragement;
        }
    }
}