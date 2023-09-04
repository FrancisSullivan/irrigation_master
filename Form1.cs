// Francis Sullivan Watering_System 2022.11.XX
#region Imports
using System.Collections.Generic;
using System.Globalization;
#endregion
namespace irrigation_master
{
    public partial class Form1 : Form
    {
        #region Initialise Form
        public Form1()
        {
            InitializeComponent();
            SaveDayToTemp();
        }
        #endregion
        #region Selected Area
        private string selectedArea = "";
        private Color color = Color.White;
        private void button3_Click(object sender, EventArgs e)
        {
            color = Color.DarkKhaki;
            selectedArea = "Avocado S";
            textBoxSelectedSection.Text = selectedArea;
            textBoxSelectedSection.BackColor = color;
        }
        private void buttonMangoNW_Click(object sender, EventArgs e)
        {
            color = Color.LightSkyBlue;
            selectedArea = "Mango NW";
            textBoxSelectedSection.Text = selectedArea;
            textBoxSelectedSection.BackColor = color;
        }
        private void buttonOrange_Click(object sender, EventArgs e)
        {
            color = Color.NavajoWhite;
            selectedArea = "Mango NE";
            textBoxSelectedSection.Text = selectedArea;
            textBoxSelectedSection.BackColor = color;
        }
        private void buttonBlue_Click(object sender, EventArgs e)
        {
            selectedArea = "Mango SW";
            textBoxSelectedSection.Text = selectedArea;
        }
        private void buttonPink_Click(object sender, EventArgs e)
        {
            color = Color.Pink;
            selectedArea = "Mango SE";
            textBoxSelectedSection.Text = selectedArea;
            textBoxSelectedSection.BackColor = color;
        }
        private void buttonGreen0_Click(object sender, EventArgs e)
        {
            selectedArea = "Green";
            textBoxSelectedSection.Text = selectedArea;
        }
        private void buttonGreen1_Click(object sender, EventArgs e)
        {
            selectedArea = "Green";
            textBoxSelectedSection.Text = selectedArea;
        }
        private void buttonGreen2_Click(object sender, EventArgs e)
        {
            selectedArea = "Green";
            textBoxSelectedSection.Text = selectedArea;
        }
        private void buttonPurple0_Click(object sender, EventArgs e)
        {
            selectedArea = "Purple";
            textBoxSelectedSection.Text = selectedArea;
        }
        private void buttonPurple1_Click(object sender, EventArgs e)
        {
            selectedArea = "Purple";
            textBoxSelectedSection.Text = selectedArea;
        }
        private void buttonYellow_Click(object sender, EventArgs e)
        {
            selectedArea = "Yellow";
            textBoxSelectedSection.Text = selectedArea;
        }
        #endregion
        #region Object Lists for each Day
        List<Task> mondaysWateringCans = new List<Task>();
        List<Task> tuesdaysWateringCans = new List<Task>();
        List<Task> wednesdaysWateringCans = new List<Task>();
        List<Task> thursdaysWateringCans = new List<Task>();
        List<Task> fridaysWateringCans = new List<Task>();
        List<Task> saturdaysWateringCans = new List<Task>();
        List<Task> sundaysWateringCans = new List<Task>();
        #endregion
        #region Temp Lists for Selected Day
        private int selectedDay = 0;
        private ListView tempListView;
        List<Task> tempWateringCans = new List<Task>();
        private void TabMenu_Selecting(object sender, TabControlCancelEventArgs e)
        {
            selectedDay = e.TabPageIndex;
            SaveDayToTemp();
        }
        private void SaveDayToTemp()
        {
            switch (selectedDay)
            {
                case (0):
                    tempWateringCans = mondaysWateringCans;
                    tempListView = listViewMonday;
                    break;
                case 1:
                    tempWateringCans = tuesdaysWateringCans;
                    tempListView = listViewTuesday;
                    break;
                case (2):
                    tempWateringCans = wednesdaysWateringCans;
                    tempListView = listViewWednesday;
                    break;
                case 3:
                    tempWateringCans = thursdaysWateringCans;
                    tempListView = listViewThursday;
                    break;
                case (4):
                    tempWateringCans = fridaysWateringCans;
                    tempListView = listViewFriday;
                    break;
                case 5:
                    tempWateringCans = saturdaysWateringCans;
                    tempListView = listViewSaturday;
                    break;
                case (6):
                    tempWateringCans = sundaysWateringCans;
                    tempListView = listViewSunday;
                    break;
            }
        }
        #endregion
        #region Add Item
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addItem();
        }
        private void addItem()
        {
            float durationHours = float.Parse(numericUpDownDurationHours.Text);
            float durationMinutes = float.Parse(numericUpDownDurationMinutes.Text);
            float durationDecimal = durationHours + durationMinutes / 60;
            int startTimeHoursInteger = int.Parse(numericUpDownStartTimeHours.Text);
            float startTimeMinutesDecimal = float.Parse(numericUpDownStartTimeMinutes.Text);
            float startTimeDecimal = startTimeHoursInteger + startTimeMinutesDecimal / 60;
            string pump = comboBox1.Text;
            string scheme = comboBox2.Text;
            // Constructor.
            Task addWateringCan = new Task(selectedArea, durationDecimal, startTimeDecimal, color, pump, scheme);
            tempWateringCans.Add(addWateringCan);
            UpdateListView();
            selectedArea = "";
            textBoxSelectedSection.Text = selectedArea;
            // Set time for next entry textBox.
            float endTimeDecimal = startTimeDecimal + durationDecimal;
            int endTimeHoursInteger = (int)endTimeDecimal;
            int endTimeMinutesInteger = (int)((endTimeDecimal * 60) - (endTimeHoursInteger * 60));
            numericUpDownStartTimeHours.Value = endTimeHoursInteger;
            numericUpDownStartTimeMinutes.Value = endTimeMinutesInteger;
        }
        #endregion
        #region Remove Item
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }
        private void RemoveItem()
        {
            tempWateringCans.RemoveAt(
                tempListView.SelectedIndices[0]);
            UpdateListView();
        }
        #endregion
        #region Clear Entire Day
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearDay();
        }
        private void clearDay()
        {
            tempWateringCans.Clear();
            UpdateListView();
        }
        #endregion
        #region Update listView
        private void UpdateListView()
        {
            tempListView.Items.Clear();
            tempWateringCans.Sort();
            foreach (var item in tempWateringCans)
            {
                // Section.
                ListViewItem lvi = new ListViewItem(
                    item.GetSection());
                lvi.BackColor = item.GetColor();
                // Duration.
                lvi.SubItems.Add(
                    TimeString(item.GetDuration()).ToString().Remove(2)
                    + " h "
                    + TimeString(
                        item.GetDuration() - ((int)item.GetDuration()))
                        .ToString().Remove(5).Substring(3)
                    + " min");
                // Start.
                lvi.SubItems.Add(TimeString(item.GetStartTime()));
                // Finish.
                lvi.SubItems.Add(
                    TimeString(item.GetStartTime() + item.GetDuration()));

                lvi.SubItems.Add(item.GetPump());
                lvi.SubItems.Add(item.GetScheme());
                tempListView.Items.Add(lvi);

            }
        }
        private string TimeString(float decimalTimeParam)
        {
            int decimalTimeHours = (int)decimalTimeParam;
            int decimalTimeMinutes =
                (int)((decimalTimeParam * 60) - (decimalTimeHours * 60));

            TimeSpan tsHours = TimeSpan.FromHours(decimalTimeHours);
            TimeSpan tsMinutes = TimeSpan.FromMinutes(decimalTimeMinutes);
            TimeSpan tsFullTime = tsHours + tsMinutes;

            string fullTime = tsFullTime.ToString().Remove(5);
            return fullTime;
        }
        #endregion
        #region Move up or down
        string swapDirection = "";
        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            swapDirection = "up";
            MoveItem();
        }
        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            swapDirection = "down";
            MoveItem();
        }
        private void MoveItem()
        {
            int swapIndex = 0;
            switch (swapDirection)
            {
                case "up":
                    swapIndex = -1;
                    break;
                case "down":
                    swapIndex = 1;
                    break;
            }
            // Swap Section
            // Temp = 1.
            string tempSection = tempWateringCans.ElementAt(
            tempListView.SelectedIndices[0]).GetSection();
            // 1 = 2.
            tempWateringCans.ElementAt(
            tempListView.SelectedIndices[0]).SetSection(
            tempWateringCans.ElementAt(
            tempListView.SelectedIndices[0] + swapIndex).GetSection());
            // 2 = temp.
            tempWateringCans.ElementAt(
            tempListView.SelectedIndices[0] + swapIndex).SetSection(
            tempSection);
            // Swap Duration
            // Temp = 1.
            float tempDuration = tempWateringCans.ElementAt(tempListView.SelectedIndices[0]).GetDuration();
            // 1 = 2.
            tempWateringCans.ElementAt(tempListView.SelectedIndices[0]).SetDuration(
            tempWateringCans.ElementAt(tempListView.SelectedIndices[0] + swapIndex).GetDuration());
            // 2 = temp.
            tempWateringCans.ElementAt(tempListView.SelectedIndices[0] + swapIndex).SetDuration(tempDuration);
            // Swap Colour.
            // Temp = 1.
            Color tempColor = tempWateringCans.ElementAt(tempListView.SelectedIndices[0]).GetColor();
            // 1 = 2.
            tempWateringCans.ElementAt(tempListView.SelectedIndices[0]).SetColor(tempWateringCans.ElementAt(tempListView.SelectedIndices[0] + swapIndex).GetColor());
            // 2 = temp.
            tempWateringCans.ElementAt(tempListView.SelectedIndices[0] + swapIndex).SetColor(tempColor);
            // Update.
            UpdateListView();
        }
        #endregion
    }
}
#region 
#endregion
#region Checklist
/*
[ ] Change system
    [ ] Water mode changed to 'taps on' mode.
    [ ] Multiple taps can be on simultaniously.
    [ ] Add inlets for river and scheme.
    [ ] Add Power on/off for river and tank pumps.
    [ ] Pump won't start when all taps are off.
[-] Remove item.
[-] Clear.
[-] Move place up or down.
[ ] Water overnight.
[ ] Keep moving object selected after each press.
[ ] Edit duration or start time. (st for first entry?)
[ ] Change items stored in class.
[ ] Continue from latest time in current tab.

[ ] Add a way to water over night.

[ ] Progress with timing.
    Must synchronise with real time, or Windows clock.
    Items will have a status, 'queued', 'in-progress', or 'complete'.
    Will peform an action when item reaches its turn,
    perhaps write to a text file with log details.

[ ] Peform logic when item starts 'in-progress'.
    Somehow send signals to all machine controllers,
    opening and closing taps,
    starting and stopping pumps.

[ ] Load and save from file.
    User will be able to open program and easily have previous schedule
    loaded in, (maybe automatic?).
 */
#endregion
