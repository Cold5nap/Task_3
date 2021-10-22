
namespace Task_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.InputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.FromSugarWeightTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ToSugarWeightTextBox = new System.Windows.Forms.TextBox();
            this.FindSweetTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WeightGiftTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WeightCheckBox = new System.Windows.Forms.CheckBox();
            this.SugarCheckBox = new System.Windows.Forms.CheckBox();
            this.MaterialCheckBox = new System.Windows.Forms.CheckBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteButton.Location = new System.Drawing.Point(272, 468);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(225, 43);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "Посчитать вес";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.CalculateWeight);
            // 
            // InputRichTextBox
            // 
            this.InputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputRichTextBox.Location = new System.Drawing.Point(31, 147);
            this.InputRichTextBox.Name = "InputRichTextBox";
            this.InputRichTextBox.Size = new System.Drawing.Size(394, 266);
            this.InputRichTextBox.TabIndex = 1;
            this.InputRichTextBox.Text = "Американка, 50, 20, 20, конфета \nИринка, 100, 16, 80, шоколадка \nВоробейка, 10, 6" +
    ", 5, конфета \nЖенчела, 21, 10, 5, конфета \nЧухчелла, 33, 20, 20, конфета ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Входные данные о сладости:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(782, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название, вес сладости, сахара, карамели или шоколада, конфета или шоколадка";
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputRichTextBox.Location = new System.Drawing.Point(470, 147);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.Size = new System.Drawing.Size(378, 266);
            this.OutputRichTextBox.TabIndex = 5;
            this.OutputRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Неотсортированный по весу подарок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(465, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(541, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отсортированный подарок по следующим параметрам:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 36);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(74, 32);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Сладость в диапозоне сахара от";
            // 
            // FromSugarWeightTextBox
            // 
            this.FromSugarWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromSugarWeightTextBox.Location = new System.Drawing.Point(371, 432);
            this.FromSugarWeightTextBox.Name = "FromSugarWeightTextBox";
            this.FromSugarWeightTextBox.Size = new System.Drawing.Size(52, 30);
            this.FromSugarWeightTextBox.TabIndex = 12;
            this.FromSugarWeightTextBox.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(429, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "до";
            // 
            // ToSugarWeightTextBox
            // 
            this.ToSugarWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToSugarWeightTextBox.Location = new System.Drawing.Point(470, 432);
            this.ToSugarWeightTextBox.Name = "ToSugarWeightTextBox";
            this.ToSugarWeightTextBox.Size = new System.Drawing.Size(59, 30);
            this.ToSugarWeightTextBox.TabIndex = 14;
            this.ToSugarWeightTextBox.Text = "40";
            // 
            // FindSweetTextBox
            // 
            this.FindSweetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindSweetTextBox.Location = new System.Drawing.Point(535, 432);
            this.FindSweetTextBox.Name = "FindSweetTextBox";
            this.FindSweetTextBox.Size = new System.Drawing.Size(313, 30);
            this.FindSweetTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Вес подарка";
            // 
            // WeightGiftTextBox
            // 
            this.WeightGiftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightGiftTextBox.Location = new System.Drawing.Point(182, 474);
            this.WeightGiftTextBox.Name = "WeightGiftTextBox";
            this.WeightGiftTextBox.Size = new System.Drawing.Size(84, 30);
            this.WeightGiftTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(28, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(992, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "_________________________________________________________________________________" +
    "__________________________________________";
            // 
            // WeightCheckBox
            // 
            this.WeightCheckBox.AutoSize = true;
            this.WeightCheckBox.Checked = true;
            this.WeightCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WeightCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightCheckBox.Location = new System.Drawing.Point(854, 184);
            this.WeightCheckBox.Name = "WeightCheckBox";
            this.WeightCheckBox.Size = new System.Drawing.Size(76, 29);
            this.WeightCheckBox.TabIndex = 19;
            this.WeightCheckBox.Text = "Весу";
            this.WeightCheckBox.UseVisualStyleBackColor = true;
            // 
            // SugarCheckBox
            // 
            this.SugarCheckBox.AutoSize = true;
            this.SugarCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SugarCheckBox.Location = new System.Drawing.Point(854, 219);
            this.SugarCheckBox.Name = "SugarCheckBox";
            this.SugarCheckBox.Size = new System.Drawing.Size(222, 29);
            this.SugarCheckBox.TabIndex = 20;
            this.SugarCheckBox.Text = "Содержанию сахара";
            this.SugarCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaterialCheckBox
            // 
            this.MaterialCheckBox.AutoSize = true;
            this.MaterialCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialCheckBox.Location = new System.Drawing.Point(854, 254);
            this.MaterialCheckBox.Name = "MaterialCheckBox";
            this.MaterialCheckBox.Size = new System.Drawing.Size(253, 54);
            this.MaterialCheckBox.TabIndex = 21;
            this.MaterialCheckBox.Text = "Содержанию шоколада\r\nили карамели";
            this.MaterialCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCheckBox.Location = new System.Drawing.Point(854, 149);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(130, 29);
            this.NameCheckBox.TabIndex = 22;
            this.NameCheckBox.Text = "Алфавиту";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(854, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 65);
            this.button1.TabIndex = 23;
            this.button1.Text = "Отсортировать по параметру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SortByParamert);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(854, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 43);
            this.button2.TabIndex = 24;
            this.button2.Text = "Найти сладость";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.FindSweet);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameCheckBox);
            this.Controls.Add(this.MaterialCheckBox);
            this.Controls.Add(this.SugarCheckBox);
            this.Controls.Add(this.WeightCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.WeightGiftTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FindSweetTextBox);
            this.Controls.Add(this.ToSugarWeightTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FromSugarWeightTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputRichTextBox);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.RichTextBox InputRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox OutputRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FromSugarWeightTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ToSugarWeightTextBox;
        private System.Windows.Forms.TextBox FindSweetTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WeightGiftTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox WeightCheckBox;
        private System.Windows.Forms.CheckBox SugarCheckBox;
        private System.Windows.Forms.CheckBox MaterialCheckBox;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

