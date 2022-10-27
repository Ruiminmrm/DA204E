using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upp6
{
    public class Task
    {
        #region Fields
        private DateTime date; //date and time for a task
        private string description; //Task's notes
        private PriorityType priority; //Priority selected from the enum 
        #endregion
        #region Constructor
        public Task()
        {
            priority = PriorityType.Normal;
        }
        public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityType.Normal)
        {
        }
        public  Task(DateTime taskDate, string description, PriorityType priority)
        {
            this.date = taskDate;
            this.description = description;
            this.priority = priority;
        }
        #endregion
        #region Properties
        public string Description
        {
            get { return description; }
            set
            {
                if(!string.IsNullOrEmpty(value))
                    description = value;
            }
        }
        public PriorityType Priority { get; set; }
        public DateTime Date { get; set; }
        #endregion
        #region Methods
        public string GetPriorityString()
        {
            string priorityStr = Enum.GetName(typeof(PriorityType), Priority);
            priorityStr = priorityStr.Replace("_", " ");
            return priorityStr;
        }
        private string GetTimeString()
        {
            string time = string.Format("{0}:{1}", Date.Hour.ToString("00"), date.Minute.ToString("00"));
            return time;
        }
        public override string ToString()
        {
            string testOut = string.Format("{0, -20} {1, 10} {2, 35} {3, 20}", Date.ToLongDateString(), GetTimeString(), GetPriorityString(), Description);
            return testOut;
        }
        #endregion
    }
}
