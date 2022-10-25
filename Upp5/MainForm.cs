using System.Runtime.CompilerServices;

namespace Upp5CD
{
    public partial class MainForm : Form
    {
        EventManager eventManager;
        private bool btnClicked = false;
        private int changeIndex = -1;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry.SelectedIndex = (int) Countries.Sverige;

            
            EmptyTextBoxes(grpNewEvent);
            EmptyTextBoxes(grpAddParticipant);
            
            //clear output controls
            lblResultNumParticipant.Text = "0";
            lblresTotalCost.Text = "0.00";
            lblresTotalFees.Text = "0.00"; 
            lblresSurplus.Text = "0.00";
            lstParticipant.Items.Clear();

            //disable the add participant grpbox
            grpAddParticipant.Enabled = false;

            //enable the create new Event grpbox
            grpNewEvent.Enabled = true;


        }
        private void CreateEvent()
        {
            eventManager = new EventManager();

            if (string.IsNullOrEmpty(txtEventTitle.Text))
                txtEventTitle.Text = "Untitled Event";

            eventManager.Title = txtEventTitle.Text + " By programmer <Ruimin Ma>";
            this.Text = eventManager.Title;

            bool costAmountOK = ReadCostPerPerson();
            bool feeAmountOK = ReadFeePerPerson();

            if(costAmountOK && feeAmountOK)
            {
                grpAddParticipant.Enabled = true;
                MessageBox.Show($"Event created!");
                UpdateGUI();
            }
        }
        private void EmptyTextBoxes(GroupBox groupBox)
        {
            foreach(Control crt in groupBox.Controls)
            {
                if (crt is TextBox)
                    crt.Text = "";
            }
        }
        private Address ReadAddress()
        {
            Address address = new Address();

            address.Street = txtStreet.Text;
            address.City = txtCity.Text;
            address.Zipcode = txtZipCode.Text;
            address.Countries = (Countries)cmbCountry.SelectedIndex; 

            return address;
        }
        private bool ReadCostPerPerson()
        {
            double amount = 0.0;
            bool ok = true;

            if(double.TryParse(txtCosstPerParticipant.Text, out amount) && amount >= 0)
                eventManager.CostPerPerson = amount;
            else
            {
                MessageBox.Show("Invalid cost per person. Please try again!");
                ok = false;
            }
            return ok;
        }
        private bool ReadFeePerPerson()
        {
            double amount = 0.0;
            bool ok = true;

            if (double.TryParse(txtFeePerParticipant.Text, out amount) && amount >= 0)
                eventManager.FeePerPerson = amount;
            else
            {
                MessageBox.Show("Invalid fee per person. Please try again!");
                ok = false;
            }
            return ok;
        }
        private bool ReadInput(ref Participant participant)
        {
            bool ok = ReadParticipantData(ref participant);
            if (ok)
            {   
                eventManager.Participant.AddParticipant(participant);
            }
            else
                MessageBox.Show("Firstname, lastname and city are required inputs. Please try again!");
            return ok;
        }
        private bool ReadParticipantData(ref Participant participant)
        {
            participant.FirstName = txtFirstName.Text;
            participant.LastName = txtLastName.Text;

            //connect address to the participant object
            Address address = ReadAddress();
            participant.Address = address;

            bool ok = address.Validate();
            return ok;
        }
        private void UpdateGUI()
        {
            string[] infoStr = eventManager.Participant.GetParticipantsInfo();

            if (infoStr != null)
            {
                lblResultNumParticipant.Text = lstParticipant.Items.Count.ToString();
            }
            double totalCost = eventManager.CalcTotalCost();
            lblresTotalCost.Text = totalCost.ToString("0.00");
            lblResultNumParticipant.Text = eventManager.Participant.Count.ToString();

            double totalFee = eventManager.CalcTotalFees();
            lblresTotalFees.Text = totalFee.ToString("0.00");
            lblresSurplus.Text = (totalFee - totalCost).ToString("0.00");

            EmptyTextBoxes(grpAddParticipant);
        }
        private void UpdateGUI(ref Participant participant)
        {
            string[] infoStr = eventManager.Participant.GetParticipantsInfo();

            if(infoStr != null)
            {
                if (btnClicked && changeIndex >= 0)
                {
                    lstParticipant.Items.RemoveAt(changeIndex);
                    lstParticipant.Items.Insert(changeIndex, participant.FullName + "       ,       " + participant.Address.ToString());
                    changeIndex = -1;
                }
                else
                {
                    lstParticipant.Items.Add(participant.FullName + "      ,       " + participant.Address.ToString());
                    lblResultNumParticipant.Text = lstParticipant.Items.Count.ToString();
                }
            }
            EmptyTextBoxes(grpAddParticipant);
            double totalCost = eventManager.CalcTotalCost();
            lblresTotalCost.Text = totalCost.ToString("0.00");
            lblResultNumParticipant.Text = eventManager.Participant.Count.ToString();

            double totalFee = eventManager.CalcTotalFees();
            lblresTotalFees.Text = totalFee.ToString("0.00");
            lblresSurplus.Text = (totalFee - totalCost).ToString("0.00");
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            //the event must be created before reading the cost or any other work
            lstParticipant.Items.Clear();
            CreateEvent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();
            if(ReadInput(ref participant))
            {
                UpdateGUI(ref participant);
            }  
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            changeIndex = lstParticipant.SelectedIndex;
            if (changeIndex < 0)
            {
                MessageBox.Show("Please select an item before you click change !");
                return;
            }
            Participant participant = eventManager.Participant.GetParticipantAt(changeIndex);
            if(ReadParticipantData(ref participant))
            {
                eventManager.Participant.ChangeParticipantAt(participant, changeIndex);
                btnClicked = true;
                UpdateGUI(ref participant);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstParticipant.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select an item before you click delete !");
                return;
            }
            eventManager.Participant.DeleteParticipantAt(index);
            lstParticipant.Items.RemoveAt(index);
            UpdateGUI();
        }
        private void lstParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstParticipant.SelectedIndex;
            if (index >= 0)
            {
                Participant participant = eventManager.Participant.GetParticipantAt(index);

                txtFirstName.Text = participant.FirstName;
                txtLastName.Text = participant.LastName;
                txtStreet.Text = participant.Address.Street;
                txtCity.Text = participant.Address.City;
                txtZipCode.Text = participant.Address.Zipcode;

                cmbCountry.SelectedIndex = (int)participant.Address.Countries;
            }
            else if(btnClicked == false)
                MessageBox.Show("Please select an item. ");
        }
    }
}