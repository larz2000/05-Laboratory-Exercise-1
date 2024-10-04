using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplicationRegistration
{
    public partial class Form1 : Form
    {
        string name = "";// store name
        string gender = "";// store gender if radio button is checked
        string dateOfBirth = "";// store date of birth
        string program = "";// store program data
        int year = 0;
        public Form1()
        {
            InitializeComponent();
            addYear();
            DayTXT.Enabled = false;
            MonthTXT.Enabled = false;
        }

        void displayInfo(string in1, string in2, string in3, string in4)
        {
            MessageBox.Show("Student name: " + in1 + "\n" + in2 + "\n" + in3 + "\n" + in4, "Registration Complete");
        }

        void displayInfo(string in1, string in2, string in3)
        {
            MessageBox.Show("Student name: " + in1 + "\n" + in2 + "\n" + in3, "Registration Complete");
        }

        void displayInfo(string in1, string in2)
        {
            MessageBox.Show("Student name: " + in1 + "\n" + in2,"Registration Complete");
        }
        // store day and year in combo box
        void addYear()
        {
            for (int i = 1948; i <= DateTime.Now.Year; i++) {
                YearTXT.Items.Add(i.ToString());
            }
        }
        //check if user input equals to the following month
        bool monthsWith31()
        {
            bool a = false;
            string[] monthsWith31days = { "January", "March", "May", "July", "August", "October", "December" };
            for (int i=0;i<monthsWith31days.Length;i++) 
            {
                if (MonthTXT.Text.Equals(monthsWith31days[i])) 
                {
                    a = true;
                    break;
                }
            }
            return a;
        }
        bool monthsWith30()
        {
            bool a = false;
            string[] monthsWith30days = { "April", "June", "September", "November"};
            for (int i = 0; i < monthsWith30days.Length; i++)
            {
                if (MonthTXT.Text.Equals(monthsWith30days[i]))
                {
                    a = true;
                    break;
                }
            }
            return a;
        }
        //add days to specific month
        void addDay() 
        {
            if (monthsWith31())
            {
                for (int i = 1; i <= 31; i++)
                {
                    DayTXT.Items.Add(i.ToString());
                }
            }
            else if (monthsWith30())
            {
                for (int i = 1; i < 31; i++)
                {
                    DayTXT.Items.Add(i.ToString());
                }
            }
            else if (MonthTXT.Text == "February") 
            {
                if ((year % 4 == 0 && year % 100 != 0 || year % 400 == 0))
                {
                    for (int i = 1; i <= 29; i++)
                    {
                        DayTXT.Items.Add(i.ToString());
                    }
                }
                else
                {
                    for (int i = 1; i < 29; i++)
                    {
                        DayTXT.Items.Add(i.ToString());
                    }
                }
            }
        }

        //check if date of birth is valid then store its data
        void checkDate() {

            if (DayTXT.Text != "" && MonthTXT.Text != "" && YearTXT.Text != "")
            {
                dateOfBirth = "Date Of Birth: "+DayTXT.Text + " " + MonthTXT.Text + " " + YearTXT.Text;
            }
            
        }
        //create a name based on the inputted data.
        void nameBuilder() 
        {
            if (MiddlenameTXT.Text == "") {
                name = FirstnameTXT.Text + " " + LastNameTXT.Text;
            }
            else if (FirstnameTXT.Text != "" && MiddlenameTXT.Text != "" && LastNameTXT.Text != "") {
                name = FirstnameTXT.Text + " " + MiddlenameTXT.Text + " " + LastNameTXT.Text;
            }
        }
        //reset inputs
        void reset() 
        {
            FirstnameTXT.Text = "";
            MiddlenameTXT.Text = "";
            LastNameTXT.Text = "";
            MaleRDB.Checked = false;
            FemaleRDB.Checked = false;
            gender = "";
            DayTXT.SelectedIndex = -1;
            MonthTXT.SelectedIndex = -1;
            YearTXT.SelectedIndex = -1;
            ProgramTXT.SelectedIndex = -1;
            DayTXT.Enabled = false;
            MonthTXT.Enabled = false;
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check condition if first, last name and program is filled
            if (FirstnameTXT.Text != "" && LastNameTXT.Text != "" && ProgramTXT.Text != "")
            {
                nameBuilder(); // call to store inputted name on name variable to evaluate
                program = "Program: " + ProgramTXT.Text;// store data on program variable
                checkDate();// call to store day and year on combo box

                if (pictureBox1.Image != null) 
                {
                    // check condition if the only inputted are name and program
                    if ((name != "" && program != "") && (gender == "" && (DayTXT.Text == "" && MonthTXT.Text == "" && YearTXT.Text == "")))
                    {
                        displayInfo(name, program);
                        reset();
                    }
                    //check if the input is filled
                    else if (gender != "" || dateOfBirth != "")
                    {
                        //check if date is complete
                        if (dateOfBirth != "" || (DayTXT.Text == "" && MonthTXT.Text == "" && YearTXT.Text == ""))
                        {
                            //check if only gender is inputted
                            if (gender != "" && dateOfBirth == "")
                            {
                                displayInfo(name, gender, program);
                                reset();
                            }
                            //check if only date of birth is inputted
                            else if (dateOfBirth != "" && gender == "")
                            {
                                displayInfo(name, dateOfBirth, program);
                                reset();
                            }
                            //check if both gender and date of birth is inputted
                            else if (gender != "" && dateOfBirth != "")
                            {
                                displayInfo(name, gender, dateOfBirth, program);
                                reset();
                            }
                        }
                        //check if date of birth is incomplete
                        else if (DayTXT.Text == "" || MonthTXT.Text == "" || YearTXT.Text == "")
                        {
                            MessageBox.Show("Incorrect Date Format!", "ERROR");
                        }
                    }
                    //since gender choices is radio button it will only check if the date input is complete otherwise false
                    else
                    {
                        MessageBox.Show("Incorrect Date Format!", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("ENTER PICTURE!", "ERROR");
                }

            }
            else
            {
                //will check if name and program are empty
                if (FirstnameTXT.Text == "" && LastNameTXT.Text == "" && ProgramTXT.Text == "")
                {
                    MessageBox.Show("STUDENT NAME AND PROGRAM SHOULD NOT BE EMPTY!", "ERROR");
                }
                else 
                {
                    //check if first and last name are empty
                    if ((FirstnameTXT.Text == "" && LastNameTXT.Text != "") || (FirstnameTXT.Text != "" && LastNameTXT.Text == ""))
                    {
                        MessageBox.Show("COMPLETE YOUR NAME!\nATLEAST FIRST AND LAST NAME.","ERROR");
                    }
                    //check if program is empty
                    else if (ProgramTXT.Text == "")
                    {
                        MessageBox.Show("SELECT PROGRAM!", "ERROR");
                    }
                    //check if name is not empty but program is empty
                    else if (ProgramTXT.Text != "" && FirstnameTXT.Text == "" && LastNameTXT.Text == "") 
                    {
                        MessageBox.Show("ENTER YOUR NAME!", "ERROR");
                    }
                }
                
            }
        }

        private void MaleRDB_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Gender: Male";
        }

        private void FemaleRDB_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Gender: Female";
        }

        private void MonthTXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayTXT.Items.Clear();
            DayTXT.SelectedIndex = -1;

            addDay();
        }

        private void YearTXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DayTXT.Enabled == false && MonthTXT.Enabled == false) 
            {
                DayTXT.Enabled = true;
                MonthTXT.Enabled = true;
            }
            year = YearTXT.SelectedIndex;
            DayTXT.SelectedIndex = -1;
            MonthTXT.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG|*.jpeg;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            
        }
    }
}
