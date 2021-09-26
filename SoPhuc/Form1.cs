using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoPhuc
{
    public partial class Complex : Form
    {
        public Complex()
        {
            InitializeComponent();
        }
        private ComplexNumber x = new ComplexNumber(0,0);
        private ComplexNumber y = new ComplexNumber(0,0);






        private void Complex_Load(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

       
        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void realTextbox_TextChanged(object sender, EventArgs e)
        {

        }

                  private void imginaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       

       
        private void btSetNo1_Click_1(object sender, EventArgs e)
        {
            
            x.Real = Int32.Parse(realTextBox.Text);
            x.Imaginary = Int32.Parse(imaginaryTextBox.Text);
            realTextBox.Clear();
            imaginaryTextBox.Clear();
            statusLabel.Text = "First Complex Number is: " + x.ToString();
        }

        private void realTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            statusLabel.Text = x + " + " + y + " = " + (x + y);
        }

        private void subtractBtn_Click_1(object sender, EventArgs e)
        {
            statusLabel.Text = x + " - " + y + " = " + (x - y);
        }

        private void mutiplyBtn_Click_1(object sender, EventArgs e)
        {
            statusLabel.Text = x + " * " + y + " = " + (x * y);
        }

        private void statusLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void btSetNo2_Click(object sender, EventArgs e)
        {
            y.Real = Int32.Parse(realTextBox.Text);
            y.Imaginary = Int32.Parse(imaginaryTextBox.Text);
            realTextBox.Clear();
            imaginaryTextBox.Clear();
            statusLabel.Text = "Seccond Complex Number is: " + y.ToString();
        }
    }
}

    /*
        public Form1()
        {
            throw new System.NotImplementedException();
        }

        public void addButton_Click()
        {
            statusLabel.Text = x + " + " + y + " + " + (x + y);
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

       

        public void Form1_Load()
        {
            throw new System.NotImplementedException();
        }

        public void InitializeComponent()
        {
            throw new System.NotImplementedException();
        }

        public void multiplyButton_Click()
        {
            statusLabel.Text = x+ " - "+ y + " - " + (x - y);
        }

        public void realTextBox_TextChanged()
        {
            throw new System.NotImplementedException();
        }

        public void secondButton_Click()
        {
            x.Real = Int32.Parse(realTextBox.Text);
            x.Imaginary = Int32.Parse(imaginaryTextBox.Text);
            realTextBox.Clear();
            imaginaryTextBox.Clear();
            statusLabel.Text = "First Complex Number is: " + x;
        }

        public void subtractButton_Click()
        {
            statusLabel.Text = x + " * " + y + " * " + (x * y);
        }
    }
}
*/
