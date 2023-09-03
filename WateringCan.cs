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
    internal class WateringCan : IComparable<WateringCan>
    {
        #region Variables
        private string section;
        private float duration;
        private float startTime;
        private string fix = "";
        #endregion
        #region CompareTo
        public int CompareTo(WateringCan other)
        {
            return fix.CompareTo(other.fix);
        }
        #endregion
        #region Constructor
        public WateringCan
        (
            string section, 
            float duration, 
            float startTime
        )
        {
            this.section = section;
            this.duration = duration;
            this.startTime = startTime;
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
        #endregion
        #region Setters
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
