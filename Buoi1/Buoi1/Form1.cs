using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi1
{
    public partial class Form1 : Form
    {
        string []foods = {"Grain","Bread","Beans","Eggs","Chicken","Mik","Frut","Vegetable","Pasta","Rice","Fish","Beer"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int topPosition = 10;
            foreach(string s in foods)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Left = 10;
                checkBox.Top = topPosition;
                topPosition += 30;
                checkBox.Text = s;
                Controls.Add(checkBox);                
            }
            

        }
        private void taoTextBox()
        {

        }
    }
}
