using System.Diagnostics;
using System.IO;

namespace Upp6
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager;
        //working with onlyone file located in the same directory as the application's EXE file 
        private string fileName = Application.StartupPath + "\\Tasks.txt";
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            this.Text = "ToDo Reminder by <Ruimin Ma>";
            
            taskManager = new TaskManager();

            cmbPriority.Items.Clear();
            cmbPriority.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
            cmbPriority.SelectedIndex = (int)PriorityType.Normal;

            lstToDo.Items.Clear();
            lblTime.Text = String.Empty;
            clockTimer.Start();

            txtDescription.Text = String.Empty;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy - MM - dd    HH : mm";

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(dateTimePicker1, "Click to open calender for date, write in time here.");
            toolTip1.SetToolTip(cmbPriority, "Select the priority.");

            string desTips = "Write your sins here!";
            toolTip1.SetToolTip(txtDescription, desTips);

            menuFileOpen.Enabled = true;
            menuFileSave.Enabled = true;
        }
        private void UpdateGUI()
        {
            lstToDo.Items.Clear();
            string[] infostring = taskManager.GetInfoStringsList();
            if (infostring != null)
                lstToDo.Items.AddRange(infostring);
        }
        private Task ReadInput()
        {
            Task task = new Task();
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Give some description please.");
                return null;
            }
            task.Description = txtDescription.Text;
            task.Date = dateTimePicker1.Value;
            task.Priority = (PriorityType)cmbPriority.SelectedIndex;

            return task;
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            bool ok = taskManager.WriteDataToFile(fileName);
            if (ok == false)
                MessageBox.Show("Something went wrong while saving data to file.");
            else
                MessageBox.Show("Data saved: " + Environment.NewLine + fileName);
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            bool ok = taskManager.ReadDataFrFile(fileName);
            if (ok == false)
                MessageBox.Show("Something went wrong when opening the file.");
            else
                UpdateGUI();
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Sure to exit program?", "Think Twice", MessageBoxButtons.OKCancel);
            if (dlgResult == DialogResult.OK)
                Application.Exit();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task task = ReadInput();
            if (taskManager.AddNewTask( task ))
                UpdateGUI();
        }
    }
}