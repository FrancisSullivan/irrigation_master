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
        private void buttonBlue_Click(object sender, EventArgs e)
        {
            selectedArea = "Cyan";
            textBoxSelectedSection.Text = selectedArea;
        }
        private void buttonPink_Click(object sender, EventArgs e)
        {
            selectedArea = "Pink";
            textBoxSelectedSection.Text = selectedArea;
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
        private void buttonRed_Click(object sender, EventArgs e)
        {
            selectedArea = "Red";
            textBoxSelectedSection.Text = selectedArea;
        }
        private void buttonOrange_Click(object sender, EventArgs e)
        {
            selectedArea = "Orange";
            textBoxSelectedSection.Text = selectedArea;
        }
        #endregion
        #region Object Lists for each Day
        List<WateringCan> mondaysWateringCans = new List<WateringCan>();
        List<WateringCan> tuesdaysWateringCans = new List<WateringCan>();
        List<WateringCan> wednesdaysWateringCans = new List<WateringCan>();
        List<WateringCan> thursdaysWateringCans = new List<WateringCan>();
        List<WateringCan> fridaysWateringCans = new List<WateringCan>();
        List<WateringCan> saturdaysWateringCans = new List<WateringCan>();
        List<WateringCan> sundaysWateringCans = new List<WateringCan>();
        #endregion
        #region Temp Lists for Selected Day
        private int selectedDay = 0;
        private ListView tempListView;
        List<WateringCan> tempWateringCans = new List<WateringCan>();
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
            float durationHours
                = float.Parse(numericUpDownDurationHours.Text);
            float durationMinutes
                = float.Parse(numericUpDownDurationMinutes.Text);
            float durationDecimal
                = durationHours + durationMinutes / 60;
            int startTimeHoursInteger
                = int.Parse(numericUpDownStartTimeHours.Text);
            float startTimeMinutesDecimal
                = float.Parse(numericUpDownStartTimeMinutes.Text);
            float startTimeDecimal
                = startTimeHoursInteger + startTimeMinutesDecimal / 60;
            WateringCan addWateringCan = new WateringCan
                (selectedArea, durationDecimal, startTimeDecimal);
            tempWateringCans.Add(addWateringCan);
            UpdateListView();
            selectedArea = "";
            textBoxSelectedSection.Text = selectedArea;
            // Set time for next entry textBox.
            float endTimeDecimal
                = startTimeDecimal + durationDecimal;
            int endTimeHoursInteger = (int)endTimeDecimal;
            int endTimeMinutesInteger =
                (int)((endTimeDecimal * 60) - (endTimeHoursInteger * 60));
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
                // Start.
                lvi.SubItems.Add(TimeString(item.GetStartTime()));
                // Finish.
                lvi.SubItems.Add(
                    TimeString(item.GetStartTime() + item.GetDuration()));
                // Duration.
                lvi.SubItems.Add(
                    TimeString(item.GetDuration()).ToString().Remove(2)
                    + " h "
                    + TimeString(
                        item.GetDuration() - ((int)item.GetDuration()))
                        .ToString().Remove(5).Substring(3)
                    + " min");
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
            float tempDuration = tempWateringCans.ElementAt(
            tempListView.SelectedIndices[0]).GetDuration();
            // 1 = 2.
            tempWateringCans.ElementAt(
            tempListView.SelectedIndices[0]).SetDuration(
            tempWateringCans.ElementAt(
            tempListView.SelectedIndices[0] + swapIndex).GetDuration());
            // 2 = temp.
            tempWateringCans.ElementAt(
            tempListView.SelectedIndices[0] + swapIndex).SetDuration(
            tempDuration);
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
