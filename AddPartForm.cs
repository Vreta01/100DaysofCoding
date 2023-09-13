using Software1Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project.Forms
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
            AddIDBox.Text = Classes.Inventory.AllParts.Count.ToString();
        }

         
        //When text is changed in a textbox, check the change against a list of allowed (good) character strings
        private void InHouseAddNameBox_TextChanged(object sender, EventArgs e)
        {

            string checkList = "letters";
            TextChangeCheck(AddNameBox, checkList, PartName);
        }

        private void InHouseAddInvBox_TextChanged(object sender, EventArgs e)
        {
            string checkList = "numbers";
            TextChangeCheck(AddInvBox, checkList, Inventory);
        }

        private void InHouseAddPriceBox_TextChanged(object sender, EventArgs e)
        {
            string checkList = "numbers";
            TextChangeCheck(AddPriceBox, checkList, Price);
            
        }

        private void InHouseAddMaxBox_TextChanged(object sender, EventArgs e)
        {
            string checkList = "numbers";
            TextChangeCheck(AddMaxBox, checkList, Max);
        }

        private void InHouseAddMinBox_TextChanged(object sender, EventArgs e)
        {
            string checkList = "numbers";
            TextChangeCheck(AddMinBox, checkList, Min);
        }
        //When text changes for this textbox, change the checkList based on the state of the radio buttons
        private void InHouseAddMachineIDBox_TextChanged(object sender, EventArgs e)
        {
            string checkList = "numbers";
            if (OutsourcedAddRadio.Checked)
            {
                checkList = "letters";
            }
            TextChangeCheck(AddMachineIDBox, checkList, MachineID);


        }

        //When radio button changes state, make sure Machine ID is changed and the textbox is checked
        private void OutsourcedAddRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (OutsourcedAddRadio.Checked)
            {
                MachineID.Text = "Company Name";
                TextChangeCheck(AddMachineIDBox, "letters", MachineID);
            }
        }

        //When the radio button changes state, make sure Company Name is changed and the textbox is checked
        private void InhouseAddRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (InhouseAddRadio.Checked)
            {
                MachineID.Text = "Machine ID";
                TextChangeCheck(AddMachineIDBox, "numbers", MachineID);
            }
        }

        //Cancel process, close current window, and return to main screen
        private void InHouseCancelButton_Click(object sender, EventArgs e)
        {
            Program.MainScreen.Show();
            this.Close();
            //MessageBox.Show(Application.OpenForms.Count.ToString());
        }


        //Method to check text in a AddPart textbox against a list of acceptable values for that textbox and remove unwanted characters
        private void TextChangeCheck(TextBox textBox, string checkList, Label textBoxLabel)
        {
            //Variables to keep track of indices and groups of bad characters
            int textIndex = 0;
            int arrayIndex = -1;
            bool isContinuous = false;
            int continuousStreak = 1;
            int[] indexOfBadChar = new int[textBox.Text.Length];

            //Initialize a list of good characters to check text against
            List<string> goodChars = Program.StringCheckList(checkList);

            //Assign all initial values in array of bad characters to an invalid index
            for (int i = 0; i < indexOfBadChar.Length; i++)
            { indexOfBadChar[i] = -1; }

            foreach (char c in textBox.Text)
            {
                //Go through each letter in text and see if it is not found in good characters list
                string cString = c.ToString();
                if (!goodChars.Contains(cString))
                {
                    //Assign the next member of the bad character array to the index of the bad character found in text
                    arrayIndex++;
                    indexOfBadChar[arrayIndex] = textIndex;

                    //If the arrayIndex counter has been incremented, check to see if the bad characters are grouped together
                    if (arrayIndex > 0)
                    {
                        if (indexOfBadChar[arrayIndex - 1] == (indexOfBadChar[arrayIndex] - 1))
                        { isContinuous = true; continuousStreak++; }
                        else { isContinuous = false; }
                    }
                }
                //Have index of text increment with loop
                textIndex++;
            }
            //If there are bad characters saved in array, Show a message to the user and remove the bad characters
            if (arrayIndex != -1)
            {
                MessageBox.Show($"{textBoxLabel.Name} can only contain {checkList}!");
                foreach (int number in indexOfBadChar)
                {
                    if (number != -1 && textBox.Text.Length > 0)
                    {
                        if (!isContinuous)
                        {
                            textBox.Text = textBox.Text.Remove(number, 1);
                        }
                        else
                        {
                            //Removes a section of characters instead of one at a time if all bad characters are grouped together
                            textBox.Text = textBox.Text.Remove(number, continuousStreak);
                            break;
                        }
                    }
                }
                //Change selection cursor's location to the end of the good text string
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        //When the save button is clicked, assign values in textboxes to properties of a new Part object
        private void InhouseSaveButton_Click(object sender, EventArgs e)
        {
            Part part = new Inhouse();
            decimal price;
            int intVal;
            part.Name = AddNameBox.Text;
            part.PartID = Classes.Inventory.AllParts.Count;
            Decimal.TryParse(AddPriceBox.Text, out price);
            part.Price = price;
            Int32.TryParse(AddInvBox.Text, out intVal);
            part.InStock = intVal;
            Int32.TryParse(AddMinBox.Text, out intVal);
            part.Min = intVal;
            Int32.TryParse(AddMaxBox.Text, out intVal);
            part.Max = intVal;

            //Add new Part to AllParts list and return to main screen
            Classes.Inventory.addPart(part);
            Program.MainScreen.Show();
            this.Close();
        }

        
    }
}
