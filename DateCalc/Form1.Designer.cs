
namespace DateCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDate1Day = new System.Windows.Forms.ComboBox();
            this.cmbDate1Month = new System.Windows.Forms.ComboBox();
            this.cmbDate1Year = new System.Windows.Forms.ComboBox();
            this.cmbDate2Year = new System.Windows.Forms.ComboBox();
            this.cmbDate2Month = new System.Windows.Forms.ComboBox();
            this.cmbDate2Day = new System.Windows.Forms.ComboBox();
            this.btnFindDay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дни между двумя датами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата 2";
            // 
            // cmbDate1Day
            // 
            this.cmbDate1Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate1Day.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDate1Day.FormattingEnabled = true;
            this.cmbDate1Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDate1Day.Location = new System.Drawing.Point(69, 105);
            this.cmbDate1Day.Name = "cmbDate1Day";
            this.cmbDate1Day.Size = new System.Drawing.Size(97, 37);
            this.cmbDate1Day.TabIndex = 3;
            // 
            // cmbDate1Month
            // 
            this.cmbDate1Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate1Month.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDate1Month.FormattingEnabled = true;
            this.cmbDate1Month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbDate1Month.Location = new System.Drawing.Point(188, 105);
            this.cmbDate1Month.Name = "cmbDate1Month";
            this.cmbDate1Month.Size = new System.Drawing.Size(99, 37);
            this.cmbDate1Month.TabIndex = 4;
            // 
            // cmbDate1Year
            // 
            this.cmbDate1Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate1Year.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDate1Year.FormattingEnabled = true;
            this.cmbDate1Year.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbDate1Year.Location = new System.Drawing.Point(310, 105);
            this.cmbDate1Year.Name = "cmbDate1Year";
            this.cmbDate1Year.Size = new System.Drawing.Size(108, 37);
            this.cmbDate1Year.TabIndex = 5;
            this.cmbDate1Year.SelectedIndexChanged += new System.EventHandler(this.cmbDate1Year_SelectedIndexChanged);
            // 
            // cmbDate2Year
            // 
            this.cmbDate2Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate2Year.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDate2Year.FormattingEnabled = true;
            this.cmbDate2Year.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbDate2Year.Location = new System.Drawing.Point(310, 194);
            this.cmbDate2Year.Name = "cmbDate2Year";
            this.cmbDate2Year.Size = new System.Drawing.Size(108, 37);
            this.cmbDate2Year.TabIndex = 8;
            // 
            // cmbDate2Month
            // 
            this.cmbDate2Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate2Month.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDate2Month.FormattingEnabled = true;
            this.cmbDate2Month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbDate2Month.Location = new System.Drawing.Point(188, 194);
            this.cmbDate2Month.Name = "cmbDate2Month";
            this.cmbDate2Month.Size = new System.Drawing.Size(99, 37);
            this.cmbDate2Month.TabIndex = 7;
            // 
            // cmbDate2Day
            // 
            this.cmbDate2Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate2Day.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDate2Day.FormattingEnabled = true;
            this.cmbDate2Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDate2Day.Location = new System.Drawing.Point(70, 194);
            this.cmbDate2Day.Name = "cmbDate2Day";
            this.cmbDate2Day.Size = new System.Drawing.Size(96, 37);
            this.cmbDate2Day.TabIndex = 6;
            this.cmbDate2Day.SelectedIndexChanged += new System.EventHandler(this.cmbDate2Day_SelectedIndexChanged);
            // 
            // btnFindDay
            // 
            this.btnFindDay.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindDay.Location = new System.Drawing.Point(160, 249);
            this.btnFindDay.Name = "btnFindDay";
            this.btnFindDay.Size = new System.Drawing.Size(167, 58);
            this.btnFindDay.TabIndex = 9;
            this.btnFindDay.Text = "Рассчитать";
            this.btnFindDay.UseVisualStyleBackColor = true;
            this.btnFindDay.Click += new System.EventHandler(this.btnFindDay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(254, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "4, 54";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(126, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дней";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(124, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "6500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(255, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Лет, дней";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(183, 72);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 26);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "сегодня";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(503, 419);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFindDay);
            this.Controls.Add(this.cmbDate2Year);
            this.Controls.Add(this.cmbDate2Month);
            this.Controls.Add(this.cmbDate2Day);
            this.Controls.Add(this.cmbDate1Year);
            this.Controls.Add(this.cmbDate1Month);
            this.Controls.Add(this.cmbDate1Day);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор дат";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDate1Day;
        private System.Windows.Forms.ComboBox cmbDate1Month;
        private System.Windows.Forms.ComboBox cmbDate1Year;
        private System.Windows.Forms.ComboBox cmbDate2Year;
        private System.Windows.Forms.ComboBox cmbDate2Month;
        private System.Windows.Forms.ComboBox cmbDate2Day;
        private System.Windows.Forms.Button btnFindDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

