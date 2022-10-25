using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upp5CD
{
    class EventManager
    {
        // instance variables
        private double costPerPerson;
        private double feePerPerson;
        private string title;

        private ParticipantManager participantManager;
        #region properties
        public double CostPerPerson
        {
            get { return costPerPerson; }
            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
        }
        public double FeePerPerson
        {
            get { return feePerPerson; }
            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }
        public ParticipantManager Participant 
        {
            get { return participantManager; }
        }
        public string Title 
        {
            get { return title; }
            set
            {
                if(!string.IsNullOrEmpty(value))
                    title = value;
            } 
        }
        #endregion
        #region contructor
        public EventManager()
        {
            participantManager = new ParticipantManager();
        }
        #endregion
        #region methods
        public double CalcTotalCost()
        {
            return Participant.Count * costPerPerson;
        }
        public double CalcTotalFees()
        {
            return Participant.Count * feePerPerson;
        }
        #endregion 
    }
}
