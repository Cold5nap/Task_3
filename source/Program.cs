using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Sweet candy = new Candy("Сластена",100, 80, 60);
            Sweet chocolateBar = new ChocolateBar("Аленка",40, 30, 25);
            Gift gift = new Gift();
            gift.addSweet(candy);
            gift.addSweet(chocolateBar);
            Console.WriteLine(gift.getWeightOfGift());
            Console.WriteLine(gift.getSweetBySugar(20,40).sweetToString());
            Console.WriteLine(gift.getStringOfGift());
            gift.sortSweetsByWeight();
            Console.WriteLine(gift.getStringOfGift());

        }
    }
}
