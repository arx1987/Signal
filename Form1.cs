using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIgnal {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ФИЧИ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      //-ДОПИСАТЬ ПОЛЕ С ЛЮБЫМ ТЕКСТОМ, КОТОРЫЙ БУДЕТ ВЫСВЕЧИВАТЬСЯ КОГДА ВРЕМЯ ИСТЕЧЕТ
      //-как-то влепить туда английский
      //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      AutoCompleteStringCollection source = new AutoCompleteStringCollection()//добавляем функцию автокомплита для поля textBox1
        {
            "5",
            "10",
            "15",
            "30",
            "60"
        };
      textBox1.AutoCompleteCustomSource = source;
      textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
    }
    int timeLeft; //переменная, хранит значнеие оставшегося до сигнала времени
    int buttonState = 0; /*переменная, которая содержит состояние кнопки. Если кнопка нажата впервые, то состояние 1, 
      если кнопка нажата 2-ой раз до сигнала, то состояние 2(и счетчик временно останавливается), если кнопка нажата 
      3-ий раз до сигнала, то состояние 3 и счетчик продолжает работать*/
    bool textBox1Changed = false; //Устанавливаем тру, если значение поля textBox1 было изменено не в первый раз
    int textBox1Changed1 = 0; //переменная, которая отслеживает количество изменений поля textBox1 

    private void Button1_Click(object sender, EventArgs e) {
      /*при нажатии на кнопку, берем значение из textBox1, проверяем, если оно не может быть преобразовано в целое число, очищаем textBox1, ставим в него курсор
       и пишем сообщение в label1 - красным шрифтом, что нужно ввести число. Если в поле введено целое число, то стартуем таймер,
       по окончании которого, должен быть подан звуковой сигнал*/
      someChecks();
      /*в будущем будет добавлена фича с английскими словами и может быть что-то еще*/
    }

    internal void someChecks() {
      int res;//переменная, которая хранит значение введенное в поле textBox1 - если поле целочисленное в минутах
      bool isInt = Int32.TryParse(textBox1.Text, out res);
      if (isInt) {
        label1.ForeColor = Color.Black;
        label1.Text = "Укажите время в минутах";
        if (button1.Text == "Старт") {
          buttonState = 0;
        }
        buttonState++;
        if (buttonState == 1) {
          button1.Text = "Пауза";
          timeLeft = res * 60;
          timer1.Start();
        }
        else if ((buttonState > 1) && (buttonState % 2 == 0)) {
          button1.Text = "Пуск";
          timer1.Stop();
        }
        else if (buttonState > 1 && buttonState % 2 != 0) {
          button1.Text = "Пауза";
          timer1.Start();
        }
      }
      else {
        label1.ForeColor = Color.Red;
        label1.Text = "Ниже введите целое число!";
        textBox1.Text = "";
        textBox1.Focus();
      }
    }

    private void Timer1_Tick(object sender, EventArgs e) {
      if(timeLeft > 0) {
        //Display the new time left by updating the Time Left label.
        timeLeft = timeLeft - 1;
        int hoursLeft = timeLeft / 3600;
        int minutesLeft = (timeLeft - hoursLeft * 3600) / 60;
        int secondsLeft = timeLeft - minutesLeft * 60 - hoursLeft * 3600;
        label2.Text = "Осталось " + hoursLeft + " ч " + minutesLeft + " м " + secondsLeft + " с";
      } else {
        //if the user ran out of time, stop the timer, play signal, clear textBox1, focus it, 
        //and change button's text to Start.
        Console.Beep(5000, 1000);//звуковой сигнал
        timer1.Stop();
        button1.Text = "Старт";
        if (!checkBox1.Checked) {
          label2.Text = "";
        } else {          
          someChecks();
        }
      }
    }

    private void TextBox1_TextChanged(object sender, EventArgs e) {
      if (buttonState > 0) {//Если кнопка button1 была нажата хотя бы 1 раз и были внесены изменения в текстовое поле
        textBox1Changed1++;
        if (textBox1Changed1 > 0) {
          textBox1Changed = true;
        }
        button1.Text = "Старт";
      }
    }
  }
}
