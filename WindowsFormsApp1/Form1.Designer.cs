
namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.razLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pingLabel = new System.Windows.Forms.Label();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rubbishLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteProgressBar = new System.Windows.Forms.ProgressBar();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxFromD = new System.Windows.Forms.TextBox();
            this.textBoxToC = new System.Windows.Forms.TextBox();
            this.textBoxToD = new System.Windows.Forms.TextBox();
            this.textBoxFromC = new System.Windows.Forms.TextBox();
            this.buttonToD = new System.Windows.Forms.Button();
            this.buttonToС = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userlabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.razLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.osLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операционная система";
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(181, 75);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(0, 13);
            this.userlabel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Текущий пользователь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // razLabel
            // 
            this.razLabel.AutoSize = true;
            this.razLabel.Location = new System.Drawing.Point(181, 51);
            this.razLabel.Name = "razLabel";
            this.razLabel.Size = new System.Drawing.Size(0, 13);
            this.razLabel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Разрядность:";
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Location = new System.Drawing.Point(181, 27);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(0, 13);
            this.osLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Операционная система:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pingLabel);
            this.groupBox2.Controls.Add(this.connectionLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Интернет";
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.Location = new System.Drawing.Point(172, 50);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(0, 13);
            this.pingLabel.TabIndex = 3;
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Location = new System.Drawing.Point(172, 26);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(0, 13);
            this.connectionLabel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Пинг (google.com):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Состояние интернета:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultLabel);
            this.groupBox3.Controls.Add(this.deleteLabel);
            this.groupBox3.Controls.Add(this.rubbishLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.deleteProgressBar);
            this.groupBox3.Controls.Add(this.analyzeButton);
            this.groupBox3.Controls.Add(this.clearButton);
            this.groupBox3.Location = new System.Drawing.Point(22, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(758, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Количество мусора";
            // 
            // rubbishLabel
            // 
            this.rubbishLabel.AutoSize = true;
            this.rubbishLabel.Location = new System.Drawing.Point(90, 31);
            this.rubbishLabel.Name = "rubbishLabel";
            this.rubbishLabel.Size = new System.Drawing.Size(0, 13);
            this.rubbishLabel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Мусора";
            // 
            // deleteProgressBar
            // 
            this.deleteProgressBar.Location = new System.Drawing.Point(309, 67);
            this.deleteProgressBar.Name = "deleteProgressBar";
            this.deleteProgressBar.Size = new System.Drawing.Size(432, 35);
            this.deleteProgressBar.Step = 1;
            this.deleteProgressBar.TabIndex = 4;
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(7, 67);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(129, 35);
            this.analyzeButton.TabIndex = 0;
            this.analyzeButton.Text = "Анализирвать";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.AnalyzeButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(157, 67);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(129, 35);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Location = new System.Drawing.Point(306, 14);
            this.deleteLabel.MaximumSize = new System.Drawing.Size(435, 0);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(62, 13);
            this.deleteLabel.TabIndex = 7;
            this.deleteLabel.Text = "Удаляется";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(306, 36);
            this.resultLabel.MaximumSize = new System.Drawing.Size(435, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(59, 13);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Результат";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.buttonToD);
            this.groupBox4.Controls.Add(this.textBoxToC);
            this.groupBox4.Controls.Add(this.textBoxFromD);
            this.groupBox4.Location = new System.Drawing.Point(29, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 60);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Перевод в двоичную систему";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.buttonToС);
            this.groupBox5.Controls.Add(this.textBoxToD);
            this.groupBox5.Controls.Add(this.textBoxFromC);
            this.groupBox5.Location = new System.Drawing.Point(408, 371);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(372, 60);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Перевод в десятичную систему";
            // 
            // textBoxFromD
            // 
            this.textBoxFromD.Location = new System.Drawing.Point(6, 34);
            this.textBoxFromD.Name = "textBoxFromD";
            this.textBoxFromD.Size = new System.Drawing.Size(120, 20);
            this.textBoxFromD.TabIndex = 0;
            // 
            // textBoxToC
            // 
            this.textBoxToC.Location = new System.Drawing.Point(232, 34);
            this.textBoxToC.Name = "textBoxToC";
            this.textBoxToC.Size = new System.Drawing.Size(120, 20);
            this.textBoxToC.TabIndex = 1;
            // 
            // textBoxToD
            // 
            this.textBoxToD.Location = new System.Drawing.Point(246, 34);
            this.textBoxToD.Name = "textBoxToD";
            this.textBoxToD.Size = new System.Drawing.Size(120, 20);
            this.textBoxToD.TabIndex = 3;
            // 
            // textBoxFromC
            // 
            this.textBoxFromC.Location = new System.Drawing.Point(6, 34);
            this.textBoxFromC.Name = "textBoxFromC";
            this.textBoxFromC.Size = new System.Drawing.Size(120, 20);
            this.textBoxFromC.TabIndex = 2;
            // 
            // buttonToD
            // 
            this.buttonToD.Location = new System.Drawing.Point(141, 31);
            this.buttonToD.Name = "buttonToD";
            this.buttonToD.Size = new System.Drawing.Size(75, 23);
            this.buttonToD.TabIndex = 9;
            this.buttonToD.Text = "Перевести";
            this.buttonToD.UseVisualStyleBackColor = true;
            this.buttonToD.Click += new System.EventHandler(this.ButtonToDClick);
            // 
            // buttonToС
            // 
            this.buttonToС.Location = new System.Drawing.Point(149, 32);
            this.buttonToС.Name = "buttonToС";
            this.buttonToС.Size = new System.Drawing.Size(75, 23);
            this.buttonToС.TabIndex = 10;
            this.buttonToС.Text = "Перевести";
            this.buttonToС.UseVisualStyleBackColor = true;
            this.buttonToС.Click += new System.EventHandler(this.ButtonToСClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "В десятичной системе";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "В двоичной системе";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "В десятичной системе";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "В двоичной системе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Тестовое задание";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label razLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label pingLabel;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label rubbishLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar deleteProgressBar;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonToD;
        private System.Windows.Forms.TextBox textBoxToC;
        private System.Windows.Forms.TextBox textBoxFromD;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonToС;
        private System.Windows.Forms.TextBox textBoxToD;
        private System.Windows.Forms.TextBox textBoxFromC;
    }
}

