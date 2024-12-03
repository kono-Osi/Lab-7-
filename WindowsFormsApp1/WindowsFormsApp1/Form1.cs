using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }
        Graphics g;
        ParamOneCar p1 = new ParamOneCar();
        ParamTwoCar p2 = new ParamTwoCar();
        Car[] t = new Car[1500];
        Random r = new Random();
        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            g.Clear(this.BackColor);

            
            if (count < t.Length)
            {
                Param param = (r.Next(0, 10) % 2 == 0) ? (Param)p1 : (Param)p2;
                string direction = r.Next(0, 2) == 0 ? "right" : "left"; 

                t[count] = new Car(r.Next(10, 100), r.Next(10, this.ClientSize.Height - 50), param, direction);
                count++;
            }

        
            for (int i = 0; i < count; i++)
            {
                if (t[i] != null)
                {
                    t[i].Move(); 
                    g.DrawImage(t[i].p.pic, new Rectangle(t[i].x, t[i].y, t[i].p.h, 20));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
