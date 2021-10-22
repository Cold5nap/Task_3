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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*Gift gift = new Gift();
            gift.addSweet(new Candy("dandhorse",133,111,11));
            gift.addSweet(new Candy("bandr",30,12,13));
            gift.addSweet(new Candy("cander",40,20,15));
            gift.addSweet(new ChocolateBar("chocpop",50,33,22));
            gift.addSweet(new ChocolateBar("ahocyou",60,44,10));
            gift.addSweet(new ChocolateBar("chocme",30,19,10));
            gift.sortSweetsByMaterial();
            gift.sortSweetsByName();
            //gift.sortSweetsBySugar();
            Console.WriteLine(gift.getStringOfGift());*/
        }
    }
}
