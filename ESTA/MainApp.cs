using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTA
{
    public partial class MainApp : Form
    {

        //Create sample students
        Student S1 = new Student("Perlat", "Kociaj", 23, new string[] { "Albanian", },
                          8, new string[] { "Albanian","Greek", "English" }, "B2",false);
        Student S2 = new Student("John", "Smith", 20, new string[] { "English" },
                          3, new string[] { "English" }, "A1",false);
        Student S3 = new Student("Joao", "Silva", 21, new string[] { "Portuguese" },
                          5, new string[] { "Portuguese", "English" }, "C1", false);
        Student S4 = new Student("Mariana", "Cenoura", 28, new string[] { "Portuguese" }, 
                          2, new string[] { "Portuguese", "English" }, "C2", false);
        Student S5 = new Student("Stergios", "Mavrideros", 17, new string[] { "Greek" }, 
                          1, new string[] { "Greek", "English","Italian" }, "A2", false);
         
          //global variables
        public  bool langLVL_OK = false; 
        public float semesterPercentage = 0;
        public float langPercentage = 0f;
        public int totalStds_approved = 0;
        public int totalStds_denied = 0;

        
        public MainApp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            studentID_CMBO.SelectedIndex = 0; 
           
        }
         
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            stdStatusLBL.ForeColor = Color.Black;
            int studentid = studentID_CMBO.SelectedIndex; 
            switch (studentid)
            {
                case 0:
                    SnameTXT.Text = S1.name; //name
                    SsurnameTXT.Text = S1.surname;  //surname
                    SageTXT.Text = S1.age.ToString();   //age
                    SemesterTXT.Text = S1.semester.ToString(); //semester
                    for (int x = 0; x <= S1.nationality.Length - 1; x++)
                    {
                        NationalityLST.Items.Clear();
                        NationalityLST.Items.Add(S1.nationality[x]);
                    }
                    //languages
                    for (int x = 0; x <= S1.languages.Length - 1; x++)
                    {
                        langList.Items.Clear();
                        langList.Items.Add(S1.languages[x]);
                    }
                    CheckLanguageLevel(S1.languageLevel);

                    if (S1.approved)
                    {
                        stdStatusLBL.Text = "Approved";
                    }
                    else
                    {
                        stdStatusLBL.Text = "Waiting decision";
                    } 
                    break;

                case 1:
                    SnameTXT.Text = S2.name; //name
                    SsurnameTXT.Text = S2.surname;  //surname
                    SageTXT.Text = S2.age.ToString();   //age
                    SemesterTXT.Text = S2.semester.ToString(); //semester

                    for (int x = 0; x <= S2.nationality.Length - 1; x++)
                    {
                        NationalityLST.Items.Clear();
                        NationalityLST.Items.Add(S2.nationality[x]);
                    }
                    //languages
                    for (int x = 0; x <= S2.languages.Length - 1; x++)
                    {
                        langList.Items.Clear();
                        langList.Items.Add(S2.languages[x]);
                    }
                    CheckLanguageLevel(S2.languageLevel);
                    if (S2.approved)
                    {
                        stdStatusLBL.Text = "Approved";
                    }
                    else
                    {
                        stdStatusLBL.Text = "Waiting decision";
                    }
                    break;
                case 2:
                    SnameTXT.Text = S3.name; //name
                    SsurnameTXT.Text = S3.surname;  //surname
                    SageTXT.Text = S3.age.ToString();   //age
                    SemesterTXT.Text = S3.semester.ToString(); //semester
                    for (int x = 0; x <= S3.nationality.Length - 1; x++)
                    {
                        NationalityLST.Items.Clear();
                        NationalityLST.Items.Add(S3.nationality[x]);
                    }
                    //languages
                    for (int x = 0; x <= S3.languages.Length - 1; x++)
                    {
                        langList.Items.Clear();
                        langList.Items.Add(S5.languages[x]);
                    }
                    CheckLanguageLevel(S3.languageLevel);
                    if (S3.approved)
                    {
                        stdStatusLBL.Text = "Approved";
                    }
                    else
                    {
                        stdStatusLBL.Text = "Waiting decision";
                    }
                    break;
                case 3:
                    SnameTXT.Text = S4.name; //name
                    SsurnameTXT.Text = S4.surname;  //surname
                    SageTXT.Text = S4.age.ToString();   //age
                    SemesterTXT.Text = S4.semester.ToString(); //semester
                    for (int x = 0; x <= S4.nationality.Length - 1; x++)
                    {
                        NationalityLST.Items.Clear();
                        NationalityLST.Items.Add(S4.nationality[x]);
                    }
                    //languages
                    for (int x = 0; x <= S4.languages.Length - 1; x++)
                    {
                        langList.Items.Clear();
                        langList.Items.Add(S4.languages[x]);
                    }
                    CheckLanguageLevel(S4.languageLevel);
                    if (S4.approved)
                    {
                        stdStatusLBL.Text = "Approved";
                    }
                    else
                    {
                        stdStatusLBL.Text = "Waiting decision";
                    }
                    break; 
                case 4:
                    SnameTXT.Text = S5.name; //name
                    SsurnameTXT.Text = S5.surname;  //surname
                    SageTXT.Text = S5.age.ToString();   //age 
                    SemesterTXT.Text = S5.semester.ToString(); //semester
                    for (int x = 0; x <= S5.nationality.Length - 1; x++)
                    {
                        NationalityLST.Items.Clear();
                        NationalityLST.Items.Add(S5.nationality[x]);
                    }
                  //languages
                    for (int x = 0; x <= S5.languages.Length - 1; x++)
                    {
                        langList.Items.Clear();
                        langList.Items.Add(S5.languages[x]);
                    }
                    //language Level
                    CheckLanguageLevel(S5.languageLevel);
                   if (S5.approved)
                    {
                        stdStatusLBL.Text = "Approved";
                    }
                    else
                    {
                        stdStatusLBL.Text = "Waiting decision";
                    }
                    break;
                default:
                    break;
            }//switch
        }//combobox item selected
        public void CheckLanguageLevel(string lvl)
        {
            switch (lvl)
            {
                case "A1":
                    langLVL_OK = false;
                    langLEVEL_LBL.Text = lvl;
                    break;
                case "A2":
                    langLVL_OK = false;
                    langLEVEL_LBL.Text = lvl;
                    break;
                case "B1":
                    langLVL_OK = true;
                    langLEVEL_LBL.Text = lvl;
                    break;
                case "B2":
                    langLVL_OK = true;
                    langLEVEL_LBL.Text = lvl;
                    break;
                case "C1":
                    langLVL_OK = true;
                    langLEVEL_LBL.Text = lvl;
                    break;
                case "C2":
                    langLVL_OK = true;
                    langLEVEL_LBL.Text = lvl;
                    break;
                default:

                    break;

            }

        }

        private void CheckEligibleBTN_Click(object sender, EventArgs e)
        {
            int age = int.Parse(SageTXT.Text.ToString());   //gets the age from the "Age.text"
            int semesterNR = 0; //exit variable from the parse int 
            string semester = SemesterTXT.Text.ToString();  //gets the semester from the "Semester.text"
            Int32.TryParse(semester, out semesterNR);   //gets the string from the semester.text and parses it to int 

            

            //is eligible for erasmus
            if (age>=18 && semesterNR >= 2 && semesterNR <= 7  && langLVL_OK )
            {
                IsEligible();
            }

            //if not eligible for erasmus cause : Age
            else if (age < 18)
            {
                 if (Reason_Result())
                 {
                     //reason of age
                     MessageBox.Show("Reason: \t" + SnameTXT.Text + " is not over 18 years old! ", "Reason of denial for " + SnameTXT.Text + " " + SsurnameTXT.Text);
                }
                totalStds_denied += 1;
                totalStds_DeniedLBL.Text = totalStds_denied.ToString();
            }//age<18
            //check the language skills if not enough
            else if (!langLVL_OK)
            {
                if(langLEVEL_LBL.Text == "A1" || langLEVEL_LBL.Text == "A2")
                {
                    if(langPercentage >=50)
                    {
                        IsEligibleDuetoLangPercentage();
                    }
                    else if(Reason_Result())
                    {
                        //reason of language skills
                        MessageBox.Show("Reason: \t" + SnameTXT.Text + "'s language skills are not enough! ", "Reason of denial for " + SnameTXT.Text + " " + SsurnameTXT.Text);
                        if (Ask_For_Approval())
                        {
                            MessageBox.Show("\tYou approved " + SnameTXT.Text + " " + SsurnameTXT.Text + "\n\n Your decision will help us for future approvals!");
                            langPercentage += 10f;
                            lang_percLBL.Text = langPercentage.ToString();
                            stdStatusLBL.ForeColor = Color.Green;
                            stdStatusLBL.Text = "Approved!";
                        }
                        else
                        {
                            stdStatusLBL.ForeColor = Color.Red;
                            stdStatusLBL.Text = "Denied!";
                        }
                    }
                }

            }
            //if not eligible for erasmus cause : Semester
            else if (semesterNR > 7)
            {
                //if many students with higher semester have been approved
                if (semesterPercentage >= 50)
                {
                    IsEligibleDuetoSemesterPercentage();
                }
                else if (Reason_Result())
                {
                    //reason of semester
                    MessageBox.Show("Reason: " + SnameTXT.Text + " is over 7th semester", "Reason of denial for " + SnameTXT.Text + " " + SsurnameTXT.Text);
                    if (Ask_For_Approval())
                    {
                        MessageBox.Show("\tYou approved " + SnameTXT.Text + " " + SsurnameTXT.Text + "\n\n Your decision will help us for future approvals!");
                        semesterPercentage += 10f;
                        sem_percLBL.Text = semesterPercentage.ToString();
                        stdStatusLBL.ForeColor = Color.Green;
                        stdStatusLBL.Text = "Approved!";
                    }
                    else
                    {
                        stdStatusLBL.ForeColor = Color.Red;
                        stdStatusLBL.Text = "Denied!";
                    }
                }

            } //if semester is <2 || >7

            else if (semesterNR < 2)
            {
                if (Reason_Result())
                {
                    //reason of semester
                    MessageBox.Show("Reason: " + SnameTXT.Text + " is lower than 2nd semester!", "Reason of denial for " + SnameTXT.Text + " " + SsurnameTXT.Text);
                }
            }

    }//checkEligibility  BUTTON.click


        //if the semester percentage of students approved is over 40%
        public void IsEligibleDuetoSemesterPercentage()
        {
            MessageBox.Show(SnameTXT.Text + " is over 7th semester, but also students with over 7th semester have been approved.\n\n \t Result : " + SnameTXT.Text + "  has been approved!", "We approved " + SnameTXT.Text + " " + SsurnameTXT.Text);
            totalStds_approved += 1;
            totalStds_ApprovedLBL.Text = totalStds_approved.ToString();
        }

        //if the language percentage of students approved is over 40%
        public void IsEligibleDuetoLangPercentage()
        {
            MessageBox.Show(SnameTXT.Text + "'language skills are not enough, but also students with with these language skills have been approved.\n\n \tResult: " + SnameTXT.Text + "  has been approved!", "We approved " + SnameTXT.Text + " " + SsurnameTXT.Text);
            totalStds_approved += 1;
            totalStds_ApprovedLBL.Text = totalStds_approved.ToString();
        }


        public void IsEligible()
        {
            MessageBox.Show(SnameTXT.Text + " is eligible for Erasmus! \n Please contact " + SnameTXT.Text, "Results for " + SnameTXT.Text + " " + SsurnameTXT.Text);
            totalStds_approved += 1;
            totalStds_ApprovedLBL.Text = totalStds_approved.ToString();
        }

        public bool Ask_For_Approval()
        {
            DialogResult approve = MessageBox.Show(SnameTXT.Text + " is not eligible! \n However you can approve "+ SnameTXT.Text + "\nDo you want to approve " + SnameTXT.Text + " " + SsurnameTXT.Text + " ?", "Approve " + SnameTXT.Text + " " + SsurnameTXT.Text + " ?", MessageBoxButtons.YesNo);
            if (approve == DialogResult.Yes)
            {
                totalStds_approved += 1;
                totalStds_ApprovedLBL.Text = totalStds_approved.ToString();
                return true;
            }
            else
            {
                totalStds_denied += 1;
                totalStds_DeniedLBL.Text = totalStds_denied.ToString();
                return false;
            }
        }

        //show the result and ask to proceed to reason
        public bool Reason_Result( )
        {
            DialogResult result = MessageBox.Show(SnameTXT.Text + " is not eligible for Erasmus \n\n\n\n Proceed to the reason of non aproval ?", "Results for " + SnameTXT.Text + " " + SsurnameTXT.Text, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        } 

        private void debugModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (debugModeToolStripMenuItem.Checked)
            {
                debugPanel.Visible = true;
            }
            else
                debugPanel.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_Form help = new Help_Form();
            help.ShowDialog();
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
