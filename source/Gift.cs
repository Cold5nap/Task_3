using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Gift
    {
        private List<Sweet> sweets = new List<Sweet>();
        
        public void addSweet(Sweet sweet)
        {
            sweets.Add(sweet);
        }
        public void removSweet(Sweet sweet)
        {
            sweets.Remove(sweet);
        }
        public List<Sweet> getSweets()
        {
            return new List<Sweet>(sweets);
        }
        public String getStringOfGift()
        {
            string stringGift = string.Empty;
            foreach (Sweet sweet in sweets)
            {
                stringGift += sweet.sweetToString();
                stringGift += "\n";
            }
            return stringGift;
        }
        //вернет вес подарка
        public double getWeightOfGift()
        {
            double weight=0;
            foreach (Sweet sweet in sweets)
            {
                weight+=sweet._weight;
            }
            return weight;
        }
        //возвращает отсортированный лист конфет по весу
        public void sortSweetsByWeight()
        {
            sweets.Sort(new SweetComparerByWeight());
        }
        //Возвращает null, если нет конфет в заданном диапозоне содержания сахара
        //параметры состовляют диапозон [from, to]
        public Sweet getSweetBySugar(double from,double to)
        {
            foreach(Sweet sweet in sweets)
            {
                if (sweet._weightOfSugar > from && sweet._weightOfSugar < to)
                    return sweet;
            }
            return null;
        }
    }
}
