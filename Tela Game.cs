using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class Tela_Game : Form
    {
        public Tela_Game()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int numrand=0;
        public int sortear()
        {   
            numrand = rand.Next(1, 4);
            return numrand;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Game_KeyDown(object sender, KeyEventArgs e)
        {
            
             if (e.KeyCode == Keys.Up)
            {
                if (pictureBox8.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y );
                    pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y);
                    pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y);
                }
                else
                {
                    pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y -10);
                    pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y -10);
                    pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y -10);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (pictureBox10.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y);
                    pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y);
                    pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y);
                }
                else
                {
                    pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y +10);
                    pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y +10);
                    pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + 10);
                }
                
            }
            else if (e.KeyCode == Keys.W)
            {
                if (panel1.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y);
                }
                else
                {
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 10);
                }
               
            }
            else if (e.KeyCode == Keys.S)
            {
                if (panel1.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y);
                }
                else
                {
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 10);
                }
                
            }
             else if(e.KeyCode == Keys.Escape)
            {

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (numrand == 1)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y - 10);
            }
            else if (numrand == 2)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y );
            }
            else if (numrand == 3)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X -
                    10, pictureBox4.Location.Y + 10);
            }


            //if (pictureBox4.Bounds.IntersectsWith(panel1.Bounds))
            //{  
            //    timer2.Stop();
            //    timer1.Start();
            //}
        }

        private void Tela_Game_Load(object sender, EventArgs e)
        {
            timer_inicio.Start();

        }

        private void timer_inicio_Tick(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
            if (pictureBox4.Bounds.IntersectsWith(pictureBox9.Bounds))
            {

                sortear();
                if (pictureBox4.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    
                }
                timer_inicio.Stop();
                timer2.Start();
            }
        }
    }
}
