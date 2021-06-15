// Programmer: Meredith Odell
// Project: Odell_1
// Date: 09/30/2019
// Description: Individual Assignment #1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odell_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Perform calculations and display results
        private void TotalButton_Click(object sender, EventArgs e)
        {
            // Use try-catch to handle any data exceptions
            try
            {
                // Declare local constants
                const decimal TAX_RATE = 0.07m;

                // Allowing a null value in inputs
                decimal miniBar;           // Mini bar charges
                decimal telephone;         // Telephone charges
                decimal miscellaneous;     // Miscellaneous charges
                decimal roomCharge;        // Total room charge
                decimal additionalCharge;  // Total additional charges
                decimal subtotal;          // Subtotal for charges
                decimal tax;               // Tax amount
                decimal totalCharge;       // Total charge for stay
                decimal nightsStayed;      // Nights stayed
                decimal roomRate;          // Room rate

                // Get values from textboxes and assign to variables
                nightsStayed = decimal.Parse(nightsTextBox.Text);
                roomRate = decimal.Parse(roomRateTextBox.Text);
                miniBar = decimal.Parse(miniBarTextBox.Text);
                telephone = decimal.Parse(telephoneTextBox.Text);
                miscellaneous = decimal.Parse(miscellaneousTextBox.Text);

                // Calculate and display the room charge
                roomCharge = roomRate * nightsStayed;
                roomChargesLabel.Text = roomCharge.ToString("c");

                // Calculate and display the additional charges
                additionalCharge = miniBar + telephone + miscellaneous;
                additionalChargesLabel.Text = additionalCharge.ToString("c");

                // Calculate and display the subtotal
                subtotal = roomCharge + additionalCharge;
                subtotalLabel.Text = subtotal.ToString("c");

                // Calculate and display the tax amount
                tax = subtotal * TAX_RATE;
                taxLabel.Text = tax.ToString("c");

                // Calculate and display the total charges
                totalCharge = subtotal + tax;
                totalChargesLabel.Text = totalCharge.ToString("c");

            }
            catch (Exception ex)
            {
                // Display the default directions message for when a data value is entered incorrectly
                MessageBox.Show(ex.Message);
            }
        }

        // Clear all input and output controls
        private void ClearButton_Click(object sender, EventArgs e)
        {
            dateTextBox.Text = "00/00/0000";
            firstNameTextBox.Text = "Ex. John";
            lastNameTextBox.Text = "Ex. Doe";
            roomNumberTextBox.Text = "Ex. 201";
            nightsTextBox.Text = "Ex. 2";
            roomRateTextBox.Text = "Ex. 2.12";
            miniBarTextBox.Text = "Ex. 2.12";
            telephoneTextBox.Text = "Ex. 2.12";
            miscellaneousTextBox.Text = "Ex. 2.12";
            roomChargesLabel.Text = "";
            additionalChargesLabel.Text = "";
            subtotalLabel.Text = "";
            taxLabel.Text = "";
            totalChargesLabel.Text = "";

            // Set focus to first input control on the form
            dateTextBox.Focus();
        }

        // Shows a general help message when the help button is pressed
        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a value that corresponds with the format mentioned in the box.");
        }

        // Closes the program when the exit button is closed
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
