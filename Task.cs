#region Imports
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
#endregion
namespace irrigation_master
{
    internal class Task : IComparable<Task>
    {
        #region Variables
        private string section;
        private float duration;
        private float startTime;
        private string fix = "";
        private Color color;
        private string pump = "";
        private string scheme = "";
        #endregion
        #region CompareTo
        public int CompareTo(Task other)
        {
            return fix.CompareTo(other.fix);
        }
        #endregion
        #region Constructor
        public Task
        (
            string section, 
            float duration,
            float startTime,
            Color color,
            string pump,
            string scheme
        )
        {
            this.section = section;
            this.duration = duration;
            this.startTime = startTime;
            this.color = color;
            this.pump = pump;
            this.scheme = scheme;
        }
        #endregion
        #region Getters
        public string GetSection()
        {
            return section;
        }
        public float GetDuration()
        {
            return duration;
        }
        public float GetStartTime()
        {
            return startTime;
        }
        public Color GetColor()
        {
            return color;
        }
        public string GetPump()
        {
            return pump;
        }
        public string GetScheme()
        {
            return scheme;
        }
        #endregion
        #region Setters
        public void SetColor(Color newColor)
        {
            color = newColor;
        }
        public void SetSection(string newSection)
        {
            section = newSection;
        }
        public void SetDuration(float newDuration)
        {
            duration = newDuration;
        }
        public void SetStartTime(float newStartTime)
        {
            startTime = newStartTime;
        }
        #endregion
    }
}
