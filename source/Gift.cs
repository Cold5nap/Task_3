using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                stringGift += sweet.ToString();
                stringGift += "\n";
            }
            return stringGift;
        }
        //вернет вес подарка
        public double getWeightOfGift()
        {
            double weight = 0;
            foreach (Sweet sweet in sweets)
            {
                weight += sweet._weight;
            }
            return weight;
        }
        //возвращает отсортированный лист конфет по весу
        public void sortSweetsByWeight()
        {
            sweets.Sort(new SweetComparerByWeight());
        }
        //возвращает отсортированный лист конфет по содержанию сахара
        public void sortSweetsBySugar()
        {
            sweets.Sort(new SweetComparerBySugar());
        }
        //возвращает отсортированный лист конфет по алфавиту
        public void sortSweetsByName()
        {
            sweets.Sort(new SweetComparerByName());
        }
        // Сортирует по шоколаду или карамели.
        // Поскольку, имеется два класса Candy и ChocolateBar,
        // то у них разные Comparer(зависит от класса),
        // поэтому сортировка проводится по каждому отдельно,
        // а потом на основе двух отсортированных списков делаем сортированный список Sweets
        public void sortSweetsByMaterial()
        {   //промежуточные списки необходимые для хранения сортированных сладостей по шоколаду или карамели
            List<Candy> candies = sortedСandiesByMaterial();
            List<ChocolateBar> chocolateBars = sortedChocolateBarsByMaterial();
            sweets.Clear();
            int indexCandies = 0, indexChocolateBars = 0;
            for (int i = 0; i < candies.Count + chocolateBars.Count; i++)
            {
                //если остались только одни шоколадки
                if (indexCandies >= candies.Count)
                {
                    sweets.Add(chocolateBars[indexChocolateBars++]);
                }
                //если осталтсь только конфеты
                else if (indexChocolateBars >= chocolateBars.Count)
                {
                    sweets.Add(candies[indexCandies++]);
                }
                else
                {
                    if (candies[indexCandies]._weightOfCaramel > chocolateBars[indexChocolateBars]._weightOfChocolate)
                        sweets.Add(chocolateBars[indexChocolateBars++]);
                    else
                        sweets.Add(candies[indexCandies++]);
                }
            }
        }
        private List<Candy> sortedСandiesByMaterial()
        {
            List<Candy> candies = new List<Candy>();
            foreach (Sweet sweet in sweets)
            {
                if (sweet.GetType() == typeof(Candy))
                {
                    candies.Add((Candy)sweet);
                }
            }
            candies.Sort(new CandyComparerByMaterial());
            return candies;
        }
        private List<ChocolateBar> sortedChocolateBarsByMaterial()
        {
            List<ChocolateBar> chocolateBars = new List<ChocolateBar>();
            foreach (Sweet sweet in sweets)
            {
                if (sweet.GetType() == typeof(ChocolateBar))
                {
                    chocolateBars.Add((ChocolateBar)sweet);
                }
            }
            chocolateBars.Sort(new ChocolateBarComparerByMaterial());
            return chocolateBars;
        }
        //Возвращает null, если нет конфет в заданном диапозоне содержания сахара
        //параметры состовляют диапозон [from, to]
        public Sweet findSweetBySugar(double from, double to)
        {
            foreach (Sweet sweet in sweets)
            {
                if (sweet._weightOfSugar > from && sweet._weightOfSugar < to)
                    return sweet;
            }
            return null;
        }

        public void stringToGift(string text)
        {
            string[] lines = text.Split('\n');
            foreach (string line in lines)
            {
                sweets.Add(stringLineToSweet(line));
            }
        }
        // преобразует строку в sweet
        private Sweet stringLineToSweet(string line)
        {
            Regex regex = new Regex(@"\w*");
            MatchCollection matches = regex.Matches(line);
            List<string> stringSweet = new List<string>();
            foreach (Match item in matches)
            {
                if (item.Value != string.Empty)
                    stringSweet.Add(item.Value);
            }
            if (stringSweet.Count == 5)
                if (stringSweet[4].ToLower() == "конфета")
                    return new Candy(stringSweet[0], int.Parse(stringSweet[1]),
                        int.Parse(stringSweet[2]), int.Parse(stringSweet[3]));
                else if (stringSweet[4].ToLower() == "шоколадка")
                    return new Candy(stringSweet[0], int.Parse(stringSweet[1]),
                        int.Parse(stringSweet[2]), int.Parse(stringSweet[3]));
                else
                    throw new Exception("Такого типа сладости нет");
            else
                throw new Exception("Введены неправильные параметры конфеты.");
        }
    }
}
