using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upp5CD
{
    class ParticipantManager
    {
        // field 
        // list of participant 
        private List<Participant> participants;

        #region contructor
        public ParticipantManager()
        {
            participants = new List<Participant>();
            //TestValues();
        }
        #endregion
        #region methods to handle the list
        public int Count 
        {
            get { return participants.Count; }
        }
        public bool AddParticipant(Participant participantIn)
        {
            if (participantIn == null)
                return false;
            participants.Add(participantIn);
            return true;
        }
        public bool ChangeParticipantAt(Participant participantIn, int index)
        {
            if ((participantIn != null) && Checkindex(index))
            {
                participants[index] = participantIn;
                return true;
            }
            return false;
        }
        private bool Checkindex(int index)
        {
            if (index < 0 || index >= participants.Count)
                return false;
            return true;
        }
        public bool DeleteParticipantAt(int index)
        {
            if (Checkindex(index))
            {
                participants.RemoveAt(index);
                return true;
            }
            return false;
        }
        //first check if the index is valid
        //if the index is valid , return participant at index 
        //if the index is not valid, return null
        public Participant GetParticipantAt(int index)
        {
            if (!Checkindex(index))
                return null;
            return participants[index];
        }
        //return a array of strings where every element represents a participant 
        public string[] GetParticipantsInfo()
        {
            string[] info = new string[participants.Count];

            for (int i = 0; i < participants.Count; i++)
            {
                if (participants[i] != null)
                    info[i] = participants[i].ToString();
            }
            return info;
        }
        #endregion
    }
}
