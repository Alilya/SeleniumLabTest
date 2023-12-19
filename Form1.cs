﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumLab {
    public partial class Form1 : Form {
        private IWebDriver firefox;
        private string site = String.Empty;
        private string savePath = String.Empty;
        public Form1() {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, EventArgs e) {
            firefox = new FirefoxDriver();
            firefox.Url = "https://programforyou.ru/calculators/number-systems";
            IWebElement textBox = firefox.FindElement(By.XPath("//*[@id=\"num-from\"]"));
            textBox.Clear();

            textBox.SendKeys(textBoxValue.Text);
            IWebElement button = firefox.FindElement(By.ClassName("calc-btn"));
            button.Click();
            IWebElement result = firefox.FindElement(By.ClassName("calc-result"));

            string resSite = result.Text;
            string res = "";
            for (int i = 0; i < resSite.Length; i++) {
                if (resSite[i] == '=') {
                    for (int j = i + 1; j < resSite.Length - 1; j++) {
                        res += resSite[j];
                    }
                }
            }
            MessageBox.Show(res);

            if (savePath == String.Empty) {
                MessageBox.Show("Выберите папку сохранения");
                return;
            }

            try {
                StreamWriter sw = new StreamWriter(savePath + @"\Test.txt");               
                sw.WriteLine("Полученное значение: "+res);

                string myRes = ConvertTo2(textBoxValue.Text);
                sw.WriteLine("Ожидаемое значение: "+ myRes);
                sw.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally {
                Console.WriteLine("Executing finally block.");
            }

            MessageBox.Show("Тестирование завершено");
        }
        public string ConvertTo2(string num, int round = 5) {
            string result = ""; //Результат
            int left = 0; //Целая часть
            int right = 0; //Дробная часть
            string[] temp1 = num.Split(new char[] { '.', ',' }); //Нужна для разделения целой и дробной частей
            left = Convert.ToInt32(temp1[0]);
            //Проверяем имеется ли у нас дробная часть
            if (temp1.Count() > 1) {
                right = Convert.ToInt32(num.Split(new char[] { '.', ',' })[1]); //Дробная часть
            }
            //Алгоритм перевода целой части в двоичную систему
            while (true) {
                result += left % 2; //В ответ помещаем остаток от деления. В конце программы мы перевернём строку, так как в обратном порядке записываются остатки
                left = left / 2; //Так как Left целое число, то при делении например числа 2359 на 2, мы получим не 1179,5 а 1179
                if (left == 0)
                    break;
            }
            result = new string(result.ToCharArray().Reverse().ToArray()); //Реверсирование строки
            /*Не углублялся в ситуацию, но вдруг при реверсе появятся первые символы нули, а ведь их мы не пишем!
            Не знаю есть ли необходимость в этом цикле */
            while (true) {
                int i = 0;
                if (result[i] == '0')
                    result = result.Remove(i, 1);
                else
                    break;
            }
            //Прокеряем есть ли у нас дробная часть, можно было бы проверить и так if(temp1.count()>1)
            if (right == 0)
                return result;

            //Добавляем разделить целой части от дробной
            result += '.';

            int count = right.ToString().Count(); // Нам нужно знать кол-во цифр, при превышении которого дописывается единичка

            for (int i = 0; i < round; i++) {
                /*Умножаем число на 2 и проверяем, стало ли оно больше по количеству цифр, если да,
                то в результат идёт "1" и первая цифра у right удаляется */
                right = right * 2;
                if (right.ToString().Count() > count) {
                    string buf = right.ToString();
                    buf = buf.Remove(0, 1);
                    right = Convert.ToInt32(buf);

                    result += '1';
                }
                else {
                    result += '0';
                }
            }
            return result;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (firefox != null) {
                firefox.Quit();
            }

        }
        private void buttonPath_Click(object sender, EventArgs e) {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                savePath = folderBrowserDialog1.SelectedPath;
                folderLabel.Text = savePath.Split('\\')[0] + @"\...\" + savePath.Split('\\')[savePath.Split('\\').Count() - 1];
                var test = savePath.Split('\\');
            }
        }

    }
}