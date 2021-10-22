using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = fileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    InputRichTextBox.Text = reader.ReadToEnd();
                }
            }
        }

        private void CalculateWeight(object sender, EventArgs e)
        {
            Gift gift = new Gift();
            gift.stringToGift(InputRichTextBox.Text);
            WeightGiftTextBox.Text = gift.getWeightOfGift().ToString();
        }

        private void FindSweet(object sender, EventArgs e)
        {
            Gift gift = new Gift();
            gift.stringToGift(InputRichTextBox.Text);
            int from = int.Parse(FromSugarWeightTextBox.Text);
            int to = int.Parse(ToSugarWeightTextBox.Text);
            Sweet foundSweet = gift.findSweetBySugar(from, to);
            if (foundSweet == null)
                FindSweetTextBox.Text = "такой конфеты нет";
            else
                FindSweetTextBox.Text = foundSweet.ToString();
        }

        private void SortByParamert(object sender, EventArgs e)
        {
            Gift gift = new Gift();
            gift.stringToGift(InputRichTextBox.Text);
            if (NameCheckBox.Checked)
                gift.sortSweetsByName();
            if (WeightCheckBox.Checked)
                gift.sortSweetsByWeight();
            if (SugarCheckBox.Checked)
                gift.sortSweetsBySugar();
            if (MaterialCheckBox.Checked)
                gift.sortSweetsByMaterial();
            OutputRichTextBox.Text = gift.getStringOfGift();
        }
    }
}
