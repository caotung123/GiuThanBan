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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int n = 4;
            int topPosition = 10;
            for (int i = 0; i < n; i++)
            {
                
                TextBox textBox = new TextBox();
                textBox.Left = 10;
                textBox.Top = topPosition;
                topPosition += 40;
                textBox.Text = "textBox" + (i + 1);
                Controls.Add(textBox);
            }
            Button btn = new Button();
            btn.Left = 10;
            btn.Top = topPosition + 50;
            btn.Size = new System.Drawing.Size(100, 20);
            Controls.Add(btn);
            btn.Text = "Process TextBoxs";
                btn.Click += new System.EventHandler(btn_Click);           
            
        }

        

        private void btn_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = "";
                }
            }
        }

        
    }
}
