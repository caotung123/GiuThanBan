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
    public partial class Form3 : Form
    {
        bool fl = true;
        Panel pnTop = new Panel();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pnTop = new Panel();

            int n = 10;
            
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {   
                    Button btn = new Button();                    
                    btn.Left = i * 25;
                    btn.Top = j*25;                    
                    btn.Size = new System.Drawing.Size(25, 25);
                    
                    pnTop.Controls.Add(btn);
                }
            }
            pnTop.Size = new Size(n * 25, n * 25);
            foreach(Control item in pnTop.Controls)
              {
                  if(item.GetType() == typeof(Button))
                      item.Click += item_Click;
              }
            Controls.Add(pnTop);     

        }

        void item_Click(object sender, EventArgs e)
        {
           
            Button btn = (Button)sender;
            if(fl == true)
            {
                btn.Text = "X";
                fl = false;
            }
            else
            {
                btn.Text = "O";
                fl = true;
            }
        }

      
    
        

        
    }
}
