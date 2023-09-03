namespace irrigation_master
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabMenu = new TabControl();
            tabPage2 = new TabPage();
            listViewMonday = new ListView();
            columnHeaderSection = new ColumnHeader();
            columnHeaderStart = new ColumnHeader();
            columnHeaderFinish = new ColumnHeader();
            columnHeaderDuration = new ColumnHeader();
            tabPage1 = new TabPage();
            listViewTuesday = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            tabPage3 = new TabPage();
            listViewWednesday = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            tabPage4 = new TabPage();
            listViewThursday = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            tabPage5 = new TabPage();
            listViewFriday = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            tabPage6 = new TabPage();
            listViewSaturday = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            tabPage7 = new TabPage();
            listViewSunday = new ListView();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            buttonAdd = new Button();
            textBoxSelectedSection = new TextBox();
            label4 = new Label();
            numericUpDownStartTimeMinutes = new NumericUpDown();
            numericUpDownStartTimeHours = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            numericUpDownDurationMinutes = new NumericUpDown();
            label1 = new Label();
            buttonOrange = new Button();
            buttonRed = new Button();
            buttonPurple1 = new Button();
            buttonPurple0 = new Button();
            buttonGreen2 = new Button();
            buttonGreen1 = new Button();
            buttonGreen0 = new Button();
            buttonPink = new Button();
            buttonYellow = new Button();
            buttonBlue = new Button();
            buttonRemove = new Button();
            button6 = new Button();
            buttonClear = new Button();
            buttonMoveDown = new Button();
            buttonMoveUp = new Button();
            numericUpDownDurationHours = new NumericUpDown();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            TabMenu.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartTimeMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartTimeHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationHours).BeginInit();
            SuspendLayout();
            // 
            // TabMenu
            // 
            TabMenu.Controls.Add(tabPage2);
            TabMenu.Controls.Add(tabPage1);
            TabMenu.Controls.Add(tabPage3);
            TabMenu.Controls.Add(tabPage4);
            TabMenu.Controls.Add(tabPage5);
            TabMenu.Controls.Add(tabPage6);
            TabMenu.Controls.Add(tabPage7);
            TabMenu.Location = new Point(349, 33);
            TabMenu.Name = "TabMenu";
            TabMenu.SelectedIndex = 0;
            TabMenu.Size = new Size(738, 489);
            TabMenu.TabIndex = 0;
            TabMenu.Selecting += TabMenu_Selecting;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listViewMonday);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(722, 435);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Monday";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewMonday
            // 
            listViewMonday.Columns.AddRange(new ColumnHeader[] { columnHeaderSection, columnHeaderStart, columnHeaderFinish, columnHeaderDuration });
            listViewMonday.FullRowSelect = true;
            listViewMonday.Location = new Point(6, 6);
            listViewMonday.Name = "listViewMonday";
            listViewMonday.Size = new Size(711, 423);
            listViewMonday.TabIndex = 23;
            listViewMonday.UseCompatibleStateImageBehavior = false;
            listViewMonday.View = View.Details;
            // 
            // columnHeaderSection
            // 
            columnHeaderSection.Text = "Section";
            columnHeaderSection.Width = 120;
            // 
            // columnHeaderStart
            // 
            columnHeaderStart.Text = "Start";
            columnHeaderStart.Width = 120;
            // 
            // columnHeaderFinish
            // 
            columnHeaderFinish.Text = "Finish";
            columnHeaderFinish.Width = 120;
            // 
            // columnHeaderDuration
            // 
            columnHeaderDuration.Text = "Duration";
            columnHeaderDuration.Width = 140;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listViewTuesday);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(722, 435);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Tuesday";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewTuesday
            // 
            listViewTuesday.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewTuesday.FullRowSelect = true;
            listViewTuesday.Location = new Point(6, 6);
            listViewTuesday.Name = "listViewTuesday";
            listViewTuesday.Size = new Size(711, 423);
            listViewTuesday.TabIndex = 24;
            listViewTuesday.UseCompatibleStateImageBehavior = false;
            listViewTuesday.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Section";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Start";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Finish";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Duration";
            columnHeader4.Width = 140;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listViewWednesday);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(722, 435);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Wednesday";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewWednesday
            // 
            listViewWednesday.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewWednesday.FullRowSelect = true;
            listViewWednesday.Location = new Point(6, 6);
            listViewWednesday.Name = "listViewWednesday";
            listViewWednesday.Size = new Size(711, 423);
            listViewWednesday.TabIndex = 25;
            listViewWednesday.UseCompatibleStateImageBehavior = false;
            listViewWednesday.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Section";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Start";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Finish";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Duration";
            columnHeader8.Width = 140;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listViewThursday);
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(722, 435);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Thursday";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listViewThursday
            // 
            listViewThursday.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listViewThursday.FullRowSelect = true;
            listViewThursday.Location = new Point(6, 6);
            listViewThursday.Name = "listViewThursday";
            listViewThursday.Size = new Size(711, 423);
            listViewThursday.TabIndex = 25;
            listViewThursday.UseCompatibleStateImageBehavior = false;
            listViewThursday.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Section";
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Start";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Finish";
            columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Duration";
            columnHeader12.Width = 140;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(listViewFriday);
            tabPage5.Location = new Point(8, 46);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(722, 435);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "Friday";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // listViewFriday
            // 
            listViewFriday.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            listViewFriday.FullRowSelect = true;
            listViewFriday.Location = new Point(6, 6);
            listViewFriday.Name = "listViewFriday";
            listViewFriday.Size = new Size(711, 423);
            listViewFriday.TabIndex = 25;
            listViewFriday.UseCompatibleStateImageBehavior = false;
            listViewFriday.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Section";
            columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Start";
            columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Finish";
            columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Duration";
            columnHeader16.Width = 140;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(listViewSaturday);
            tabPage6.Location = new Point(8, 46);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(722, 435);
            tabPage6.TabIndex = 6;
            tabPage6.Text = "Saturday";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // listViewSaturday
            // 
            listViewSaturday.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader18, columnHeader19, columnHeader20 });
            listViewSaturday.FullRowSelect = true;
            listViewSaturday.Location = new Point(6, 6);
            listViewSaturday.Name = "listViewSaturday";
            listViewSaturday.Size = new Size(711, 423);
            listViewSaturday.TabIndex = 25;
            listViewSaturday.UseCompatibleStateImageBehavior = false;
            listViewSaturday.View = View.Details;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Section";
            columnHeader17.Width = 120;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Start";
            columnHeader18.Width = 120;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Finish";
            columnHeader19.Width = 120;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Duration";
            columnHeader20.Width = 140;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(listViewSunday);
            tabPage7.Location = new Point(8, 46);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(722, 435);
            tabPage7.TabIndex = 7;
            tabPage7.Text = "Sunday";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // listViewSunday
            // 
            listViewSunday.Columns.AddRange(new ColumnHeader[] { columnHeader21, columnHeader22, columnHeader23, columnHeader24 });
            listViewSunday.FullRowSelect = true;
            listViewSunday.Location = new Point(6, 6);
            listViewSunday.Name = "listViewSunday";
            listViewSunday.Size = new Size(711, 423);
            listViewSunday.TabIndex = 25;
            listViewSunday.UseCompatibleStateImageBehavior = false;
            listViewSunday.View = View.Details;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Section";
            columnHeader21.Width = 120;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Start";
            columnHeader22.Width = 120;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Finish";
            columnHeader23.Width = 120;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "Duration";
            columnHeader24.Width = 140;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(951, 637);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 146);
            buttonAdd.TabIndex = 32;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxSelectedSection
            // 
            textBoxSelectedSection.Location = new Point(568, 640);
            textBoxSelectedSection.Name = "textBoxSelectedSection";
            textBoxSelectedSection.Size = new Size(200, 39);
            textBoxSelectedSection.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 643);
            label4.Name = "label4";
            label4.Size = new Size(81, 32);
            label4.TabIndex = 30;
            label4.Text = "Water:";
            // 
            // numericUpDownStartTimeMinutes
            // 
            numericUpDownStartTimeMinutes.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDownStartTimeMinutes.Location = new Point(665, 741);
            numericUpDownStartTimeMinutes.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            numericUpDownStartTimeMinutes.Name = "numericUpDownStartTimeMinutes";
            numericUpDownStartTimeMinutes.Size = new Size(81, 39);
            numericUpDownStartTimeMinutes.TabIndex = 29;
            // 
            // numericUpDownStartTimeHours
            // 
            numericUpDownStartTimeHours.Location = new Point(565, 741);
            numericUpDownStartTimeHours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownStartTimeHours.Name = "numericUpDownStartTimeHours";
            numericUpDownStartTimeHours.Size = new Size(81, 39);
            numericUpDownStartTimeHours.TabIndex = 28;
            numericUpDownStartTimeHours.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 741);
            label3.Name = "label3";
            label3.Size = new Size(127, 32);
            label3.TabIndex = 27;
            label3.Text = "Start Time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(839, 692);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 26;
            label2.Text = "Minutes.";
            // 
            // numericUpDownDurationMinutes
            // 
            numericUpDownDurationMinutes.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDownDurationMinutes.Location = new Point(752, 690);
            numericUpDownDurationMinutes.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            numericUpDownDurationMinutes.Name = "numericUpDownDurationMinutes";
            numericUpDownDurationMinutes.Size = new Size(81, 39);
            numericUpDownDurationMinutes.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 694);
            label1.Name = "label1";
            label1.Size = new Size(53, 32);
            label1.TabIndex = 24;
            label1.Text = "For:";
            // 
            // buttonOrange
            // 
            buttonOrange.BackColor = Color.FromArgb(255, 192, 128);
            buttonOrange.Font = new Font("Britannic Bold", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOrange.Location = new Point(1250, 355);
            buttonOrange.Name = "buttonOrange";
            buttonOrange.Size = new Size(101, 184);
            buttonOrange.TabIndex = 22;
            buttonOrange.Text = "Mango NE";
            buttonOrange.UseVisualStyleBackColor = false;
            buttonOrange.Click += buttonOrange_Click;
            // 
            // buttonRed
            // 
            buttonRed.BackColor = Color.FromArgb(255, 128, 128);
            buttonRed.Font = new Font("Britannic Bold", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRed.Location = new Point(1135, 355);
            buttonRed.Name = "buttonRed";
            buttonRed.Size = new Size(109, 184);
            buttonRed.TabIndex = 21;
            buttonRed.Text = "Mango NW";
            buttonRed.UseVisualStyleBackColor = false;
            buttonRed.Click += buttonRed_Click;
            // 
            // buttonPurple1
            // 
            buttonPurple1.BackColor = Color.FromArgb(192, 192, 255);
            buttonPurple1.Location = new Point(67, 563);
            buttonPurple1.Name = "buttonPurple1";
            buttonPurple1.Size = new Size(93, 63);
            buttonPurple1.TabIndex = 19;
            buttonPurple1.UseVisualStyleBackColor = false;
            buttonPurple1.Click += buttonPurple1_Click;
            // 
            // buttonPurple0
            // 
            buttonPurple0.BackColor = Color.FromArgb(192, 192, 255);
            buttonPurple0.Location = new Point(67, 483);
            buttonPurple0.Name = "buttonPurple0";
            buttonPurple0.Size = new Size(216, 74);
            buttonPurple0.TabIndex = 18;
            buttonPurple0.UseVisualStyleBackColor = false;
            buttonPurple0.Click += buttonPurple0_Click;
            // 
            // buttonGreen2
            // 
            buttonGreen2.BackColor = Color.FromArgb(192, 255, 192);
            buttonGreen2.Location = new Point(190, 849);
            buttonGreen2.Name = "buttonGreen2";
            buttonGreen2.Size = new Size(93, 49);
            buttonGreen2.TabIndex = 17;
            buttonGreen2.UseVisualStyleBackColor = false;
            buttonGreen2.Click += buttonGreen2_Click;
            // 
            // buttonGreen1
            // 
            buttonGreen1.BackColor = Color.FromArgb(192, 255, 192);
            buttonGreen1.Location = new Point(67, 849);
            buttonGreen1.Name = "buttonGreen1";
            buttonGreen1.Size = new Size(90, 49);
            buttonGreen1.TabIndex = 16;
            buttonGreen1.UseVisualStyleBackColor = false;
            buttonGreen1.Click += buttonGreen1_Click;
            // 
            // buttonGreen0
            // 
            buttonGreen0.BackColor = Color.FromArgb(192, 255, 192);
            buttonGreen0.Location = new Point(190, 563);
            buttonGreen0.Name = "buttonGreen0";
            buttonGreen0.Size = new Size(93, 63);
            buttonGreen0.TabIndex = 15;
            buttonGreen0.UseVisualStyleBackColor = false;
            buttonGreen0.Click += buttonGreen0_Click;
            // 
            // buttonPink
            // 
            buttonPink.BackColor = Color.FromArgb(255, 192, 255);
            buttonPink.Location = new Point(190, 656);
            buttonPink.Name = "buttonPink";
            buttonPink.Size = new Size(93, 174);
            buttonPink.TabIndex = 14;
            buttonPink.UseVisualStyleBackColor = false;
            buttonPink.Click += buttonPink_Click;
            // 
            // buttonYellow
            // 
            buttonYellow.BackColor = Color.FromArgb(255, 255, 192);
            buttonYellow.Location = new Point(67, 347);
            buttonYellow.Name = "buttonYellow";
            buttonYellow.Size = new Size(216, 119);
            buttonYellow.TabIndex = 13;
            buttonYellow.UseVisualStyleBackColor = false;
            buttonYellow.Click += buttonYellow_Click;
            // 
            // buttonBlue
            // 
            buttonBlue.BackColor = Color.FromArgb(192, 255, 255);
            buttonBlue.Location = new Point(67, 656);
            buttonBlue.Name = "buttonBlue";
            buttonBlue.Size = new Size(93, 174);
            buttonBlue.TabIndex = 10;
            buttonBlue.UseVisualStyleBackColor = false;
            buttonBlue.Click += buttonBlue_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(651, 528);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(150, 46);
            buttonRemove.TabIndex = 34;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // button6
            // 
            button6.Location = new Point(495, 528);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 35;
            button6.Text = "Edit";
            button6.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(807, 528);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(150, 46);
            buttonClear.TabIndex = 36;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonMoveDown
            // 
            buttonMoveDown.Location = new Point(1028, 528);
            buttonMoveDown.Name = "buttonMoveDown";
            buttonMoveDown.Size = new Size(59, 46);
            buttonMoveDown.TabIndex = 37;
            buttonMoveDown.Text = "\\/";
            buttonMoveDown.UseVisualStyleBackColor = true;
            buttonMoveDown.Click += buttonMoveDown_Click;
            // 
            // buttonMoveUp
            // 
            buttonMoveUp.Location = new Point(963, 528);
            buttonMoveUp.Name = "buttonMoveUp";
            buttonMoveUp.Size = new Size(59, 46);
            buttonMoveUp.TabIndex = 38;
            buttonMoveUp.Text = "/\\";
            buttonMoveUp.UseVisualStyleBackColor = true;
            buttonMoveUp.Click += buttonMoveUp_Click;
            // 
            // numericUpDownDurationHours
            // 
            numericUpDownDurationHours.Location = new Point(568, 690);
            numericUpDownDurationHours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownDurationHours.Name = "numericUpDownDurationHours";
            numericUpDownDurationHours.Size = new Size(81, 39);
            numericUpDownDurationHours.TabIndex = 39;
            numericUpDownDurationHours.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(655, 692);
            label5.Name = "label5";
            label5.Size = new Size(91, 32);
            label5.TabIndex = 40;
            label5.Text = "Hour(s)";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(99, 110);
            button1.Name = "button1";
            button1.Size = new Size(31, 31);
            button1.TabIndex = 41;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Location = new Point(310, 849);
            button2.Name = "button2";
            button2.Size = new Size(31, 31);
            button2.TabIndex = 42;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 0);
            button3.Font = new Font("Britannic Bold", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1135, 214);
            button3.Name = "button3";
            button3.Size = new Size(216, 135);
            button3.TabIndex = 43;
            button3.Text = "Avocado\r\nS";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.Font = new Font("Britannic Bold", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(1135, 58);
            button4.Name = "button4";
            button4.Size = new Size(216, 150);
            button4.TabIndex = 44;
            button4.Text = "Avocado\r\nN";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 255, 192);
            button5.Location = new Point(200, 239);
            button5.Name = "button5";
            button5.Size = new Size(93, 84);
            button5.TabIndex = 45;
            button5.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 255, 192);
            button7.Location = new Point(200, 66);
            button7.Name = "button7";
            button7.Size = new Size(93, 111);
            button7.TabIndex = 46;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkOrange;
            button8.Location = new Point(147, 146);
            button8.Name = "button8";
            button8.Size = new Size(31, 31);
            button8.TabIndex = 47;
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.IndianRed;
            button9.Location = new Point(147, 95);
            button9.Name = "button9";
            button9.Size = new Size(31, 31);
            button9.TabIndex = 48;
            button9.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 955);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(numericUpDownDurationHours);
            Controls.Add(buttonMoveUp);
            Controls.Add(buttonMoveDown);
            Controls.Add(buttonClear);
            Controls.Add(button6);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxSelectedSection);
            Controls.Add(TabMenu);
            Controls.Add(label4);
            Controls.Add(buttonRed);
            Controls.Add(numericUpDownStartTimeMinutes);
            Controls.Add(buttonOrange);
            Controls.Add(numericUpDownStartTimeHours);
            Controls.Add(label3);
            Controls.Add(buttonBlue);
            Controls.Add(label2);
            Controls.Add(buttonYellow);
            Controls.Add(numericUpDownDurationMinutes);
            Controls.Add(buttonPink);
            Controls.Add(label1);
            Controls.Add(buttonGreen0);
            Controls.Add(buttonGreen1);
            Controls.Add(buttonPurple1);
            Controls.Add(buttonGreen2);
            Controls.Add(buttonPurple0);
            Name = "Form1";
            Text = "Irrigation Master";
            TabMenu.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartTimeMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartTimeHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TabMenu;
        private TabPage tabPage2;
        private Button buttonBlue;
        private Button buttonPink;
        private Button buttonYellow;
        private Button buttonPurple1;
        private Button buttonPurple0;
        private Button buttonGreen2;
        private Button buttonGreen1;
        private Button buttonGreen0;
        private Button buttonOrange;
        private Button buttonRed;
        private ListView listViewMonday;
        private Label label2;
        private NumericUpDown numericUpDownDurationMinutes;
        private Label label1;
        private Label label3;
        private NumericUpDown numericUpDownStartTimeMinutes;
        private NumericUpDown numericUpDownStartTimeHours;
        private TabPage tabPage1;
        private TextBox textBoxSelectedSection;
        private Label label4;
        private Button buttonAdd;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Button buttonRemove;
        private Button button6;
        private Button buttonClear;
        private Button buttonMoveDown;
        private Button buttonMoveUp;
        private NumericUpDown numericUpDownDurationHours;
        private Label label5;
        private ColumnHeader columnHeaderSection;
        private ColumnHeader columnHeaderStart;
        private ColumnHeader columnHeaderFinish;
        private ColumnHeader columnHeaderDuration;
        private ListView listViewTuesday;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listViewWednesday;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView listViewThursday;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListView listViewFriday;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ListView listViewSaturday;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ListView listViewSunday;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}