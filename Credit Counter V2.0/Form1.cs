using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;   //added this class in as previously, I didn't use it.


namespace Credit_Counter_V2._0
{
    public partial class Form1 : Form
    {
        int Total_pence = 0;      //This is where the variables I use later are set.
        decimal Total_Pound = 0.00m;
        int count_1p = 0; 
        int count_2p = 0; 
        int count_5p = 0; 
        int count_10p = 0;
        int count_20p = 0;
        int count_50p = 0;
        int count_1pound = 0; // numerical values equal 0
        int count_2pound = 0;
        int creditcost;
        int credit;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 1; // adds 1p to the total pence value
                Total_Pound += 0.01m; // adds 1p to the total pound value 
                count_1p += 1; // adds 1 to the count of the coin
                credit = Total_pence / creditcost; // Divides the total pence by the entered credit cost
                textBox20.Text = credit.ToString(); // displays the varaible in the textbox
            }
            label24.Text = count_1p.ToString(); // displays the count on the label for the coin
            textBox3.Text = Total_pence.ToString(); // displays the total in pence
            textBox6.Text = Total_Pound.ToString(); // displays the total in pounds
             //after created functionality for one coin code copied to others as is the same



        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 1; // adds 1p to the total pence value
                Total_Pound += 0.01m; // adds 1p to the total pound value 
                count_1p += 1; // adds 1 to the count of the coin
                credit = Total_pence / creditcost; // Divides the total pence by the entered credit cost
                textBox20.Text = credit.ToString(); // displays the varaible in the textbox
            }
            label23.Text = count_1p.ToString(); // displays the count on the label for the coin
            textBox3.Text = Total_pence.ToString(); // displays the total in pence
            textBox6.Text = Total_Pound.ToString(); // displays the total in pounds



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1(); //Creates a copy of the blank form
            NewForm.Show(); // Shows the newly created form
            this.Dispose(false); // Deletes the old form
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credits"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 1; // adds 1p to the total pence value
                Total_Pound += 0.01m; // adds 1p to the total pound value 
                count_1p += 1; // adds 1 to the count of the coin
                credit = Total_pence / creditcost; // Divides the total pence by the entered credit cost
                textBox20.Text = credit.ToString(); // displays the varaible in the textbox
            }
            label16.Text = count_1p.ToString(); // displays the count on the label for the coin
            textBox3.Text = Total_pence.ToString(); // displays the total in pence
            textBox6.Text = Total_Pound.ToString(); // displays the total in pounds



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 1; // adds 1p to the total pence value
                Total_Pound += 0.01m; // adds 1p to the total pound value 
                count_1p += 1; // adds 1 to the count of the coin
                credit = Total_pence / creditcost; // Divides the total pence by the entered credit cost
                textBox20.Text = credit.ToString(); // displays the varaible in the textbox
            }
            label20.Text = count_1p.ToString(); // displays the count on the label for the coin
            textBox3.Text = Total_pence.ToString(); // displays the total in pence
            textBox6.Text = Total_Pound.ToString(); // displays the total in pounds





        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 1; // adds 1p to the total pence value
                Total_Pound += 0.01m; // adds 1p to the total pound value 
                count_1p += 1; // adds 1 to the count of the coin
                credit = Total_pence / creditcost; // Divides the total pence by the entered credit cost
                textBox20.Text = credit.ToString(); // displays the varaible in the textbox
            }
            label21.Text = count_1p.ToString(); // displays the count on the label for the coin
            textBox3.Text = Total_pence.ToString(); // displays the total in pence
            textBox6.Text = Total_Pound.ToString(); // displays the total in pounds



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 1; // adds 1p to the total pence value
                Total_Pound += 0.01m; // adds 1p to the total pound value 
                count_1p += 1; // adds 1 to the count of the coin
                credit = Total_pence / creditcost; // Divides the total pence by the entered credit cost
                textBox20.Text = credit.ToString(); // displays the varaible in the textbox
            }
            label15.Text = count_1p.ToString(); // displays the count on the label for the coin
            textBox3.Text = Total_pence.ToString(); // displays the total in pence
            textBox6.Text = Total_Pound.ToString(); // displays the total in pounds



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 1; // adds 1p to the total pence value
                Total_Pound += 0.01m; // adds 1p to the total pound value 
                count_1p += 1; // adds 1 to the count of the coin
                credit = Total_pence / creditcost; // Divides the total pence by the entered credit cost
                textBox20.Text = credit.ToString(); // displays the varaible in the textbox
            }
            label22.Text = count_1p.ToString(); // displays the count on the label for the coin
            textBox3.Text = Total_pence.ToString(); // displays the total in pence
            textBox6.Text = Total_Pound.ToString(); // displays the total in pounds



        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (creditcost == 0) // If statement checking if the credit per cost has been entered
            {
                MessageBox.Show("Please enter the amount of credit"); // If not, shows this message
            }
            else // Otherwise
            {

                Total_pence += 1; // adds 1p to the total pence value
                Total_Pound += 0.01m; // adds 1p to the total pound value 
                count_1p += 1; // adds 1 to the count of the coin
                credit = Total_pence / creditcost; // Divides the total pence by the entered credit cost
                textBox20.Text = credit.ToString(); // displays the varaible in the textbox
            }
            label19.Text = count_1p.ToString(); // displays the count on the label for the coin
            textBox3.Text = Total_pence.ToString(); // displays the total in pence
            textBox6.Text = Total_Pound.ToString(); // displays the total in pounds



        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(My_Dialogs.InputBox("Please enter the credit: "), out creditcost); // Opens a inputbox from the My_Dialogs class asking for the Cost per credit
            textBox1.Text = creditcost.ToString(); //Sets the label to the cost per credit that was inputted
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

// Assignment done by Shakir Shabbir