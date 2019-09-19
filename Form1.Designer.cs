namespace SIgnal {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.timer3 = new System.Windows.Forms.Timer(this.components);
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label6 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.timer4 = new System.Windows.Forms.Timer(this.components);
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.textBox10 = new System.Windows.Forms.TextBox();
      this.textBox9 = new System.Windows.Forms.TextBox();
      this.button6 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.timer5 = new System.Windows.Forms.Timer(this.components);
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 29);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(64, 20);
      this.textBox1.TabIndex = 0;
      this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(140, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Укажите время в минутах";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.button1.Location = new System.Drawing.Point(131, 94);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(85, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Старт";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 91);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(0, 13);
      this.label2.TabIndex = 3;
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Location = new System.Drawing.Point(82, 31);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(85, 17);
      this.checkBox1.TabIndex = 4;
      this.checkBox1.Text = "зациклить?";
      this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // textBox2
      // 
      this.textBox2.BackColor = System.Drawing.SystemColors.Window;
      this.textBox2.Location = new System.Drawing.Point(12, 68);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(204, 20);
      this.textBox2.TabIndex = 5;
      this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 52);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(108, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Текст напоминания";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Controls.Add(this.textBox4);
      this.groupBox1.Controls.Add(this.checkBox2);
      this.groupBox1.Controls.Add(this.textBox3);
      this.groupBox1.Location = new System.Drawing.Point(-1, 123);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(217, 54);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(7, 32);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(0, 13);
      this.label4.TabIndex = 4;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.button2.Location = new System.Drawing.Point(98, 28);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(113, 26);
      this.button2.TabIndex = 3;
      this.button2.Text = "Cтарт";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.Button2_Click);
      // 
      // textBox4
      // 
      this.textBox4.BackColor = System.Drawing.SystemColors.Window;
      this.textBox4.Location = new System.Drawing.Point(98, 9);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(113, 20);
      this.textBox4.TabIndex = 2;
      this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new System.Drawing.Point(77, 12);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(15, 14);
      this.checkBox2.TabIndex = 1;
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(7, 9);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(64, 20);
      this.textBox3.TabIndex = 0;
      this.textBox3.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
      // 
      // timer2
      // 
      this.timer2.Interval = 1000;
      this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.button3);
      this.groupBox2.Controls.Add(this.textBox6);
      this.groupBox2.Controls.Add(this.checkBox3);
      this.groupBox2.Controls.Add(this.textBox5);
      this.groupBox2.Location = new System.Drawing.Point(-1, 183);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(217, 54);
      this.groupBox2.TabIndex = 8;
      this.groupBox2.TabStop = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(7, 32);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(0, 13);
      this.label5.TabIndex = 4;
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.button3.Location = new System.Drawing.Point(98, 28);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(113, 26);
      this.button3.TabIndex = 3;
      this.button3.Text = "Cтарт";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.Button3_Click);
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(98, 9);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(113, 20);
      this.textBox6.TabIndex = 2;
      this.textBox6.Click += new System.EventHandler(this.textBox6_Click);
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new System.Drawing.Point(77, 12);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(15, 14);
      this.checkBox3.TabIndex = 1;
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(7, 9);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(64, 20);
      this.textBox5.TabIndex = 0;
      this.textBox5.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
      // 
      // timer3
      // 
      this.timer3.Interval = 1000;
      this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label6);
      this.groupBox3.Controls.Add(this.button4);
      this.groupBox3.Controls.Add(this.textBox8);
      this.groupBox3.Controls.Add(this.checkBox4);
      this.groupBox3.Controls.Add(this.textBox7);
      this.groupBox3.Location = new System.Drawing.Point(-1, 243);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(217, 54);
      this.groupBox3.TabIndex = 9;
      this.groupBox3.TabStop = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(7, 32);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(0, 13);
      this.label6.TabIndex = 4;
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.button4.Location = new System.Drawing.Point(98, 28);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(113, 26);
      this.button4.TabIndex = 3;
      this.button4.Text = "Cтарт";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.Button4_Click);
      // 
      // textBox8
      // 
      this.textBox8.Location = new System.Drawing.Point(98, 9);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(113, 20);
      this.textBox8.TabIndex = 2;
      this.textBox8.Click += new System.EventHandler(this.textBox8_Click);
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new System.Drawing.Point(77, 12);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(15, 14);
      this.checkBox4.TabIndex = 1;
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // textBox7
      // 
      this.textBox7.Location = new System.Drawing.Point(7, 9);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(64, 20);
      this.textBox7.TabIndex = 0;
      this.textBox7.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
      // 
      // timer4
      // 
      this.timer4.Interval = 1000;
      this.timer4.Tick += new System.EventHandler(this.Timer4_Tick);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.comboBox1);
      this.groupBox4.Controls.Add(this.textBox10);
      this.groupBox4.Controls.Add(this.textBox9);
      this.groupBox4.Controls.Add(this.button6);
      this.groupBox4.Controls.Add(this.button5);
      this.groupBox4.Controls.Add(this.label7);
      this.groupBox4.Location = new System.Drawing.Point(-1, 304);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(217, 57);
      this.groupBox4.TabIndex = 10;
      this.groupBox4.TabStop = false;
      // 
      // textBox10
      // 
      this.textBox10.Location = new System.Drawing.Point(98, 31);
      this.textBox10.Name = "textBox10";
      this.textBox10.Size = new System.Drawing.Size(112, 20);
      this.textBox10.TabIndex = 9;
      // 
      // textBox9
      // 
      this.textBox9.Location = new System.Drawing.Point(7, 31);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new System.Drawing.Size(39, 20);
      this.textBox9.TabIndex = 7;
      this.textBox9.Text = "0";
      this.textBox9.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
      // 
      // comboBox1
      // 
      this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "с",
            "м",
            "ч"});
      this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "с",
            "м",
            "ч"});
      this.comboBox1.Location = new System.Drawing.Point(53, 31);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(39, 21);
      this.comboBox1.TabIndex = 10;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
      this.comboBox1.SelectedIndex = 0;
      // 
      // button6
      // 
      this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.button6.Location = new System.Drawing.Point(174, 5);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(37, 26);
      this.button6.TabIndex = 6;
      this.button6.Text = ";)";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new System.EventHandler(this.Button6_Click);
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.button5.Location = new System.Drawing.Point(98, 5);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(70, 26);
      this.button5.TabIndex = 5;
      this.button5.Text = "Старт";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new System.EventHandler(this.Button5_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(7, 11);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(0, 13);
      this.label7.TabIndex = 0;
      // 
      // timer5
      // 
      this.timer5.Interval = 1000;
      this.timer5.Tick += new System.EventHandler(this.Timer5_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(224, 409);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Timer timer3;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.Timer timer4;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Timer timer5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.TextBox textBox10;
    private System.Windows.Forms.TextBox textBox9;
    private System.Windows.Forms.ComboBox comboBox1;
  }
}

