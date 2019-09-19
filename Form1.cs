using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //Для создания пауз в мелодии

namespace SIgnal {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ФИЧИ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      //+ДОПИСАТЬ ПОЛЕ С ЛЮБЫМ ТЕКСТОМ, КОТОРЫЙ БУДЕТ ВЫСВЕЧИВАТЬСЯ КОГДА ВРЕМЯ ИСТЕЧЕТ
      //-как-то влепить туда английский
      //+сделать много полей для задания времени, чтобы каждый таймер работал отдельно и 
      //-когда прозвучал сигнал, надпись под этим таймером должна подсвечиваться пока по ней не кликнешь
      //+установить другой сигнал
      //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      comboBox1.SelectedIndex = 0;
      comboBox2.SelectedIndex = 0;
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
    int timeLeft1, timeLeft2, timeLeft3, timeLeft4; //переменная, хранит значнеие оставшегося до сигнала времени
    int timeSec5 = 0, timeSec6 = 0; //переменная, которая хранит значение секундомера
    int buttonState1 = 0; /*переменная, которая содержит состояние кнопки. Если кнопка нажата впервые, то состояние 1, 
      если кнопка нажата 2-ой раз до сигнала, то состояние 2(и счетчик временно останавливается), если кнопка нажата 
      3-ий раз до сигнала, то состояние 3 и счетчик продолжает работать*/
    int buttonState2 = 0, buttonState3 = 0, buttonState4 = 0;
    bool textBox1Changed = false; //Устанавливаем тру, если значение поля textBox1 было изменено не в первый раз
    bool textBox2Changed = false, textBox3Changed = false, textBox4Changed = false;
    int textBox1Changed1 = 0; //переменная, которая отслеживает количество изменений поля textBox1
    int textBox2Changed2 = 0, textBox3Changed3 = 0, textBox4Changed4 = 0;



    private void Button1_Click(object sender, EventArgs e) {
      /*при нажатии на кнопку, берем значение из textBox1, проверяем, если оно не может быть преобразовано в целое число, очищаем textBox1, ставим в него курсор
       и пишем сообщение в label1 - красным шрифтом, что нужно ввести число. Если в поле введено целое число, то стартуем таймер,
       по окончании которого, должен быть подан звуковой сигнал*/
      someChecks(1);
      /*в будущем будет добавлена фича с английскими словами и может быть что-то еще*/
    }

    private void Button2_Click(object sender, EventArgs e) {
      someChecks(2);
    }

    private void Button3_Click(object sender, EventArgs e) {
      someChecks(3);
    }

    private void Button4_Click(object sender, EventArgs e) {
      someChecks(4);
    }

    /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~СЕКУНДОМЕРЫ + ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
    /* +добавить кнопку сброс таймера,
     * +текстовое поле
     * +чтобы через определенное время подать звуковой сигнал(замигало окошко(мигание окошка - лучше сделать отдельный метод) */
    int reminderTime5 = 0, reminderTime6 = 0;//время напоминания секундомера с таймером5 и 6
    private void Button5_Click(object sender, EventArgs e) {//Старт/Пауза секундомера
      if (button5.Text == "Старт") {
        timer5.Start();
        button5.Text = "Пауза";
      } else if(button5.Text == "Пауза") {
        timer5.Stop();
        button5.Text = "Старт";
      }
    }

    private void Button6_Click(object sender, EventArgs e) {//Сброс секундомера 
      timeSec5 = 0;
      label7.Text = 0 + " ч " + 0 + " м " + 0 + " с";
    }

    private void Button7_Click(object sender, EventArgs e) {//Старт/Пауза секундомера
      if (button7.Text == "Старт") {
        timer6.Start();
        button7.Text = "Пауза";
      }
      else if (button5.Text == "Пауза") {
        timer6.Stop();
        button7.Text = "Старт";
      }
    }

    private void Button8_Click(object sender, EventArgs e) {//Сброс секундомера 
      timeSec6 = 0;
      label8.Text = 0 + " ч " + 0 + " м " + 0 + " с";
    }

    private void TextBox9_TextChanged(object sender, EventArgs e) {
      int numberSec9;
      bool isIntSec = Int32.TryParse(textBox9.Text, out numberSec9);
      if (isIntSec) {
        textBox9.BackColor = Color.White;
        reminderTime5 = reminderSecMinHour(numberSec9, comboBox1.SelectedItem.ToString());
      }
      else {
        textBox9.BackColor = Color.Red;
      }
    }

    //textBox11, 12; buttons 7 8
    private void TextBox11_TextChanged(object sender, EventArgs e) {
      int numberSec11;
      bool isIntSec = Int32.TryParse(textBox11.Text, out numberSec11);
      if (isIntSec) {
        textBox9.BackColor = Color.White;
        reminderTime6 = reminderSecMinHour(numberSec11, comboBox2.SelectedItem.ToString());
      }
      else {
        textBox11.BackColor = Color.Red;
      }
    }

    ///*метод, который будет устанавливать значения reminderTime5 или reminderTime6, 
    // * аргументами будет принимать строки sec1 or sec2*/
    //private void reminderTime(string stopWatch) {
    //  int numberSec;
    //  bool isIntSec;
    //  string cmbBxVal;
    //  if (stopWatch == "sec1") {
    //    isIntSec = Int32.TryParse(textBox9.Text, out numberSec);
    //    if (isIntSec) {
    //      cmbBxVal = comboBox1.SelectedItem.ToString();
    //      reminderTime5 = reminderSecMinHour(numberSec, cmbBxVal);
    //    } else {
    //      textBox9.BackColor = Color.Red;
    //    }
    //  } else if(stopWatch == "sec2") {
    //    //isIntSec = Int32.TryParse(textBox11.Text, out numberSec);
    //    //if (isIntSec) {
    //    //  cmbBxVal = comboBox2.SelectedItem.ToString();
    //    //  reminderTime6 = reminderSecMinHour(numberSec, cmbBxVal);
    //    //}
    //    //else {
    //    //  textBox11.BackColor = Color.Red;
    //    //}
    //  }
    //}

    private int reminderSecMinHour(int tBV, string comboVal) {//подсчет количества секунд, которое нужно будет сравинить с секундомером
      switch (comboVal) {
        case "с":
          return tBV;
          break;
        case "м":
          return tBV * 60;
          break;
        case "ч":
          return tBV * 3600;
          break;
        default:
          return 0;
      }
    }
    //bool isInt1 = Int32.TryParse(textBox1.Text, out res1);
    //if (isInt1) {
    //  label1.ForeColor = Color.Black;
    //  textBox9.Text = "Укажите целое число";
    //int reminderTime5 = reminderTime(textBox9.Text.ToInt32(), comboBox1.SelectedItem.ToString());
    //textBox 9 10 comboBox1
    /*private int reminderTime(int txtBxVal, string cmbBxItm) {
      if(txtBxVal == 9) { }
      return 10;
    }*/
    /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~СЕКУНДОМЕРЫ - ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

    private void textBox2_Click(object sender, EventArgs e) {//timer1
      textBox2.BackColor = Color.White;
    }

    private void textBox4_Click(object sender, EventArgs e) {//timer2
      textBox4.BackColor = Color.White;
    }

    private void textBox6_Click(object sender, EventArgs e) {//timer3
      textBox6.BackColor = Color.White;
    }

    private void textBox8_Click(object sender, EventArgs e) {//timer4
      textBox8.BackColor = Color.White;
    }

    internal void someChecks(int timerNum) {
      int res1, res2, res3, res4;//переменная, которая хранит значение введенное в поле textBox1, 3, 5, 7 - если поле целочисленное в минутах
      if (timerNum == 1) {
        bool isInt1 = Int32.TryParse(textBox1.Text, out res1);
        if (isInt1) {
          label1.ForeColor = Color.Black;
          label1.Text = "Укажите время в минутах";
          if (button1.Text == "Старт") {
            buttonState1 = 0;
          }
          buttonState1++;
          if (buttonState1 == 1) {
            button1.Text = "Пауза";
            timeLeft1 = res1 * 60;//время в минутах
            timer1.Start();
          }
          else if ((buttonState1 > 1) && (buttonState1 % 2 == 0)) {
            button1.Text = "Пуск";
            timer1.Stop();
          }
          else if (buttonState1 > 1 && buttonState1 % 2 != 0) {
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
      else if (timerNum == 2) {
        bool isInt2 = Int32.TryParse(textBox3.Text, out res2);//проверяем целое число введено, если да, записываем его в res2 и isInt2 = true, иначе не записываем и isInt2 = false;
        if (isInt2) {
          if (button2.Text == "Старт") {
            buttonState2 = 0;
          }
          buttonState2++;
          if (buttonState2 == 1) {
            button2.Text = "Пауза";
            timeLeft2 = res2 * 60;//время в минутах
            timer2.Start();
          }
          else if ((buttonState2 > 1) && (buttonState2 % 2 == 0)) {
            button2.Text = "Пуск";
            timer2.Stop();
          }
          else if (buttonState2 > 1 && buttonState2 % 2 != 0) {
            button2.Text = "Пауза";
            timer2.Start();
          }
        }
        else {
          label4.ForeColor = Color.Red;
          label4.Text = "Введите целое число!";
          textBox3.Text = "";
          textBox3.Focus();
        }
      }
      else if (timerNum == 3) {
        bool isInt3 = Int32.TryParse(textBox5.Text, out res3);//проверяем целое число введено, если да, записываем его в res2 и isInt2 = true, иначе не записываем и isInt2 = false;
        if (isInt3) {
          if (button3.Text == "Старт") {
            buttonState3 = 0;
          }
          buttonState3++;
          if (buttonState3 == 1) {
            button3.Text = "Пауза";
            timeLeft3 = res3 * 60;//время в минутах
            timer3.Start();
          }
          else if ((buttonState3 > 1) && (buttonState3 % 2 == 0)) {
            button3.Text = "Пуск";
            timer3.Stop();
          }
          else if (buttonState3 > 1 && buttonState3 % 2 != 0) {
            button3.Text = "Пауза";
            timer3.Start();
          }
        }
        else {
          label5.ForeColor = Color.Red;
          label5.Text = "Введите целое число!";
          textBox5.Text = "";
          textBox5.Focus();
        }
      }
      else if (timerNum == 4) {
        bool isInt4 = Int32.TryParse(textBox7.Text, out res4);//проверяем целое число введено, если да, записываем его в res2 и isInt2 = true, иначе не записываем и isInt2 = false;
        if (isInt4) {
          if (button4.Text == "Старт") {
            buttonState4 = 0;
          }
          buttonState4++;
          if (buttonState4 == 1) {
            button4.Text = "Пауза";
            timeLeft4 = res4 * 60;//время в минутах
            timer4.Start();
          }
          else if ((buttonState4 > 1) && (buttonState4 % 2 == 0)) {
            button4.Text = "Пуск";
            timer4.Stop();
          }
          else if (buttonState4 > 1 && buttonState4 % 2 != 0) {
            button4.Text = "Пауза";
            timer4.Start();
          }
        }
        else {
          label6.ForeColor = Color.Red;
          label6.Text = "Введите целое число!";
          textBox7.Text = "";
          textBox7.Focus();
        }
      }

    }

    //добавить один параметр(с каким таймером будет работать этот метод) в зависимости от этого параметра внутри метода будут соответствующие временные переменные,  или нужно все это выносить в отдельный метод.... который будет с общими временными параметрами
    private void Timer1_Tick(object sender, EventArgs e) {
      if (timeLeft1 > 0) {
        //Display the new time left by updating the Time Left label.
        timeLeft1 = timeLeft1 - 1;
        int hoursLeft = timeLeft1 / 3600;
        int minutesLeft = (timeLeft1 - hoursLeft * 3600) / 60;
        int secondsLeft = timeLeft1 - minutesLeft * 60 - hoursLeft * 3600;
        label2.Text = hoursLeft + " ч " + minutesLeft + " м " + secondsLeft + " с";
      }
      else {
        //if the user ran out of time, stop the timer, play signal, clear textBox1, focus it, 
        //and change button's text to Start.
        textBox2.BackColor = Color.MediumSeaGreen;//MediumSeaGreen
        //groupBox1.BackColor = SystemColors.Control;
        //groupBox1.BackColor = SystemColors.Info;
        Console.Beep(300, 500);//звуковой сигнал  было Console.Beep(5000, 1000);
        Thread.Sleep(300);
        Console.Beep(300, 500);
        Thread.Sleep(300);
        Console.Beep(300, 500);
        timer1.Stop();
        button1.Text = "Старт";
        if (!checkBox1.Checked) {
          label2.Text = "";
        }
        else {
          someChecks(1);
        }
      }
    }

    private void Timer2_Tick(object sender, EventArgs e) {
      string label2 = "";
      Timer_Tick(sender, e, 2, ref timeLeft2, ref label2);
      label4.Text = label2;
    }

    private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
      int numberSec09;
      bool isIntSec = Int32.TryParse(textBox9.Text, out numberSec09);
      if (isIntSec) {
        reminderTime5 = reminderSecMinHour(numberSec09, comboBox1.SelectedItem.ToString());
      }
      else {
        textBox9.BackColor = Color.Red;
      }
    }

    private void Timer3_Tick(object sender, EventArgs e) {
      string label3 = "";
      Timer_Tick(sender, e, 3, ref timeLeft3, ref label3);
      label5.Text = label3;
    }

    private void Timer4_Tick(object sender, EventArgs e) {
      string label4 = "";
      Timer_Tick(sender, e, 4, ref timeLeft4, ref label4);
      label6.Text = label4;
    }

    /*в параметрах ниже передаем:
     * int timer - номер таймера 1, 2, 3, 4 по порядку в окошке
     * ref int timeLeft - это timeLeft1, timeLeft2...timeLeft4 время оставшееся у таймера до 0
     * ref string labelText - текст, который будет передан соответствующему лейблу, например label4.Text = labelText;
     */
    private void Timer_Tick(object sender, EventArgs e, int timer, ref int timeLeft, ref string labelText) {
      /*string labelText;*/
      if (timeLeft > 0) {
        //Display the new time left by updating the Time Left label.
        timeLeft = timeLeft - 1;
        int hoursLeft = timeLeft / 3600;
        int minutesLeft = (timeLeft - hoursLeft * 3600) / 60;
        int secondsLeft = timeLeft - minutesLeft * 60 - hoursLeft * 3600;
        labelText = hoursLeft + " ч " + minutesLeft + " м " + secondsLeft + " с";//label4.Text= //labelText
      }
      else {
        //if the user ran out of time, stop the timer, play signal, clear textBox1, focus it, 
        //and change button's text to Start.
        Console.Beep(300, 500);//звуковой сигнал  было Console.Beep(5000, 1000);
        Thread.Sleep(300);
        Console.Beep(300, 500);
        Thread.Sleep(300);
        Console.Beep(300, 500);
        switch (timer) {
          case 1://этот блок кода по идее не должен выполняться - case 1:
            timer1.Stop();
            button1.Text = "Старт";
            if (checkBox1.Checked) {
              someChecks(timer);
            }
            break;
          case 2:
            textBox4.BackColor = Color.MediumSeaGreen;
            timer2.Stop();
            button2.Text = "Старт";
            if (checkBox2.Checked) {
              someChecks(timer);
            }
            break;
          case 3:
            textBox6.BackColor = Color.MediumSeaGreen;
            timer3.Stop();
            button3.Text = "Старт";
            if (checkBox3.Checked) {
              someChecks(timer);
            }
            break;
          case 4:
            textBox8.BackColor = Color.MediumSeaGreen;
            timer4.Stop();
            button4.Text = "Старт";
            if (checkBox4.Checked) {
              someChecks(timer);
            }
            break;
          default:
            break;
        }
      }
    }

    /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~СЕКУНДОМЕРЫ + ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
    private void Timer5_Tick(object sender, EventArgs e) {
      if(timeSec5 == reminderTime5 && reminderTime5 != 0) {
        Console.Beep(500, 700);//звуковой сигнал  было Console.Beep(5000, 1000);
        Thread.Sleep(300);
        Console.Beep(500, 700);
        Thread.Sleep(300);
        Console.Beep(500, 700);
      }
      timeSec5++;
      int hoursLeft = timeSec5 / 3600;
      int minutesLeft = (timeSec5 - hoursLeft * 3600) / 60;
      int secondsLeft = timeSec5 - minutesLeft * 60 - hoursLeft * 3600;
      label7.Text = hoursLeft + " ч " + minutesLeft + " м " + secondsLeft + " с";
    }

    private void Timer6_Tick(object sender, EventArgs e) {
      if (timeSec6 == reminderTime6 && reminderTime6 != 0) {
        Console.Beep(500, 700);//звуковой сигнал  было Console.Beep(5000, 1000);
        Thread.Sleep(300);
        Console.Beep(500, 700);
        Thread.Sleep(300);
        Console.Beep(500, 700);
      }
      timeSec6++;
      int hoursLeft = timeSec6 / 3600;
      int minutesLeft = (timeSec6 - hoursLeft * 3600) / 60;
      int secondsLeft = timeSec6 - minutesLeft * 60 - hoursLeft * 3600;
      label8.Text = hoursLeft + " ч " + minutesLeft + " м " + secondsLeft + " с";
    }
    /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~СЕКУНДОМЕРЫ - ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

    private void TextBox1_TextChanged(object sender, EventArgs e) {
      if (buttonState1 > 0) {//Если кнопка button1 была нажата хотя бы 1 раз и были внесены изменения в текстовое поле
        textBox1Changed1++;
        if (textBox1Changed1 > 0) {
          textBox1Changed = true;
        }
        button1.Text = "Старт";
      }
    }

    private void TextBox2_TextChanged(object sender, EventArgs e) {
      if (buttonState2 > 0) {//Если кнопка button1 была нажата хотя бы 1 раз и были внесены изменения в текстовое поле
        textBox2Changed2++;
        if (textBox2Changed2 > 0) {
          textBox2Changed = true;
        }
        button2.Text = "Старт";
      }
    }
    private void TextBox3_TextChanged(object sender, EventArgs e) {
      if (buttonState3 > 0) {//Если кнопка button1 была нажата хотя бы 1 раз и были внесены изменения в текстовое поле
        textBox3Changed3++;
        if (textBox3Changed3 > 0) {
          textBox3Changed = true;
        }
        button3.Text = "Старт";
      }
    }

    private void TextBox4_TextChanged(object sender, EventArgs e) {
      if (buttonState4 > 0) {//Если кнопка button1 была нажата хотя бы 1 раз и были внесены изменения в текстовое поле
        textBox4Changed4++;
        if (textBox4Changed4 > 0) {
          textBox4Changed = true;
        }
        button4.Text = "Старт";
      }
    }

    private void Form1_Load(object sender, EventArgs e) {

    }
  }
}
