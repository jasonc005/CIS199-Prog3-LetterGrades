using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Group 6 - Jason Chandler, William Benedict
 * Calculate letter grades as P for Pass and F for Fail based on the marks obtained.
 * Find the number of instances with the given grades.
 */
namespace Ex1
{
    public partial class LetterGrade : Form
    {
        
        public LetterGrade()
        {
            InitializeComponent();
        }

        //List to store letter grades
        List<string> letterGrades = new List<string>();

        //Convert number in marksTextbox to P or F and save to the list
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Saving the number in the text box as a double
            double marks = double.Parse(marksTextbox.Text);

            //Convert number to P or F, add to list
            if (marks > 0 && marks <= 60)
                letterGrades.Add("F");
            else if (marks > 60 && marks <= 100)
                letterGrades.Add("P");
            else //if marks <= 0 || marks > 100
                MessageBox.Show("Not valid marks.");

            marksTextbox.Clear(); //Clear the marksTextbox
        }

        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Save letterGradeTextbox as uppercase
            string grade = letterGradeTextbox.Text.ToUpper();            

            //Declare var to count 
            int noOfGrades = 0;

            //Iterates through the List
            for (int x = 0; x < letterGrades.Count; x++)
            {
                //if letter grade is found in the list add 1 to the count
                if (letterGrades[x] == grade)
                    noOfGrades += 1;
            }

            letterGradeTextbox.Clear(); //Clear letterGradeTextbox

            //Display message with the total count 
            MessageBox.Show("Number of instances with given letter grade: " + noOfGrades);
        }
    }
}
