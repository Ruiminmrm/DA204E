using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Upp6
{
    class FileManager
    {
        #region field
        //Write this token as the first line in the textfile as a simple to mark that the file is saved by this application
        private const string fileVersionToken = "ToDoRe_21";
        //help to make the old file compatible
        private const double fileVersionNr = 1.0;
        #endregion
        #region methods
        public bool SaveTaskListToFile(List<Task> tasklist, string filename)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filename);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(tasklist.Count);

                for(int i = 0; i < tasklist.Count; i++)
                {
                    writer.WriteLine(tasklist[i].Description);
                    writer.WriteLine(tasklist[i].Priority.ToString());
                    writer.WriteLine(tasklist[i].Date.Year);
                    writer.WriteLine(tasklist[i].Date.Month);
                    writer.WriteLine(tasklist[i].Date.Day);
                    writer.WriteLine(tasklist[i].Date.Hour);
                    writer.WriteLine(tasklist[i].Date.Minute);
                    writer.WriteLine(tasklist[i].Date.Second);
                }
            }
            catch
            {
                //if any error occurs in the above try-block, the execution will jump to this block
                //avoiding crash
                ok = false;
            }
            finally
            {
                //this block will always executed
                if(writer != null)
                    writer.Close();
            }
            return ok;
        }
        public bool ReadTaskListFrFile(List<Task>tasklist, string filename)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                //clear the contents of tasklist
                if (tasklist != null)
                    tasklist.Clear();
                else
                    tasklist = new List<Task>();

                reader = new StreamReader(filename);

                //ensure that it is the correct file
                string versionTest = reader.ReadLine();
                //ensure that it has the correct version.nr
                double version = double.Parse(reader.ReadLine());

                if((versionTest == fileVersionToken) && (version == fileVersionNr))
                {
                    //read num of the items(tasks) to read
                    int count = int.Parse(reader.ReadLine());
                    for(int i = 0; i < count; i++)
                    {
                        Task task = new Task();
                        task.Description = reader.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());

                        //DateTime
                        int year = 0, month = 0, day = 0, hour = 0, minute = 0, second = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());

                        task.Date = new DateTime(year, month, day, hour, minute, second);

                        tasklist.Add(task);
                    }
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if(reader != null)
                    reader.Close();
            }
            return ok;
        }
        #endregion
    }
}
