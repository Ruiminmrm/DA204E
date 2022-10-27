using Aardvark.Base.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Upp6
{
    class TaskManager
    {
        //declare a list<T> object where T is a Task type
        List<Task> taskList;

        #region Constructor
        public TaskManager()
        {
            taskList = new List<Task>();
        }
        #endregion
        #region Methods
        public Task GetTask(int index)
        {
            if (CheckIndex(index))
                return taskList[index];
            else
                return null;
        }
        //add a new task at the end of the list 
        public bool AddNewTask(Task newTask)
        {
            bool ok = true;
            if (newTask == null)
                ok = false;
            else
                taskList.Add(newTask);
            return ok;
        }
        public bool AddNewTask(DateTime newTime, string description, PriorityType priority)
        {
            bool ok = true;
            Task newTask = new Task(newTime, description, priority);
            if (newTask != null)
                taskList.Add(newTask);
            else
                ok = false;
            return ok;
        }
        public string[] GetInfoStringsList()
        {
            string[] infostr = new string[taskList.Count];
            for (int i = 0; i < infostr.Length; i++)
                infostr[i] = taskList[i].ToString();
            return infostr;
        }
        //handle saving and reading data to and from a text file.
        //Send the tasklist from which data is read and saved to the file fileName
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }
        //send the tasklist object declared in above to which data from the filename is saved.
        //As tasklist is an object, it will have the change made in the Filemanager when the method ReadTaskListFrFile returns
        public bool ReadDataFrFile(string fileName)
        {
            FileManager fileManager = new FileManager();

            //objects are passed by ref so tasklist will be updated.
            return fileManager.ReadTaskListFrFile(taskList, fileName);
        }

        private bool CheckIndex(int index)
        {
            return index >= 0 && index < taskList.Count;
        }
        #endregion
    }
}
