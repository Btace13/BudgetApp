using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//ToDO: learn to save to a Database




namespace BudgetApp_Attempt
{
    public partial class Form1 : Form
    {

                
            


        public Form1()
        {
            InitializeComponent();

            // To Get Percentage Formula:
            // multiply "rent" by 100 then divide that by income


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            double income = Convert.ToInt32(incomeTextBox.Text);
            double rent = Convert.ToInt32(rentTextBox.Text);
            double car = Convert.ToInt32(carTextBox.Text);
            double food = Convert.ToInt32(foodTextBox.Text);
            double savings = Convert.ToInt32(savingsTextBox.Text);


            //Test

            rentPerTextBox.Text = Convert.ToString(Math.Round(rent * 12 * 100 / income)+"%");
            carPerTextBox.Text = Convert.ToString(Math.Round(car * 12 * 100 / income) + "%");
            foodPerTextBox.Text = Convert.ToString(Math.Round(food * 12 * 100 / income) + "%");
            anualTextBox.Text = Convert.ToString("$" + savings * 12);





        }
    }
}
