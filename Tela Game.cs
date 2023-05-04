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
        String direcao;
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
                if (pictureBox5.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y);
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y);
                    pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y);
                }
                else
                {
                    pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y -10);
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y -10);
                    pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y -10);
                }
               
            }
            else if (e.KeyCode == Keys.S)
            {
                if (pictureBox7.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y);
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y);
                    pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y);
                }
                else
                {
                    pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y +10);
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y +10);
                    pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 10);
                }
                
            }
             else if(e.KeyCode == Keys.Escape)
            {

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                sortear();
                timer1.Stop();
                Timer_Pb6.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                sortear();
                timer1.Stop();
                Timer_Pb5.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                sortear();
                timer1.Stop();
                Timer_Pb7.Start();
            }

            else if (numrand == 1)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y - 10);
            }
            else if (numrand == 2)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y);
            }
            else if (numrand == 3)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y -10);
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                sortear();
                timer2.Stop();
                Timer_Pb6.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                sortear();
                timer2.Stop();
                Timer_Pb5.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                sortear();
                timer2.Stop();
                Timer_Pb7.Start();
            }

            else if (numrand == 1)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y );
            }
            else if (numrand == 2)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y );
            }
            else if (numrand == 3)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X -10, pictureBox4.Location.Y );
            }

        }

        private void Tela_Game_Load(object sender, EventArgs e)
        {
            timer_inicio.Start();

        }

        private void timer_inicio_Tick(object sender, EventArgs e)
        {
           
            if (pictureBox4.Bounds.IntersectsWith(pictureBox9.Bounds))
            {

                sortear();
                timer_inicio.Stop();
                timer2.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox8.Bounds))
                {
                sortear();
                timer_inicio.Stop();
                timer1.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                sortear();
                timer_inicio.Stop();
                Timer_Pb10.Start();
            }
            else
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
            }


        }

        private void Timer_Pb10_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                sortear();
                Timer_Pb10.Stop();
                Timer_Pb6.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                sortear();
                Timer_Pb10.Stop();
                Timer_Pb5.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                sortear();
                Timer_Pb10.Stop();
                Timer_Pb7.Start();
            }

            else if (numrand == 1)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y +10);
            }
            else if (numrand == 2)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y);
            }
            else if (numrand == 3)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y + 10);
            }
        }

        private void Timer_Pb6_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                sortear();
                Timer_Pb6.Stop();
                timer1.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                sortear();
                Timer_Pb6.Stop();
                timer2.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                sortear();
                Timer_Pb6.Stop();
                Timer_Pb10.Start();
            }

            else if (numrand == 1)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X +10, pictureBox4.Location.Y );
            }
            else if (numrand == 2)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
            }
            else if (numrand == 3)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X +10, pictureBox4.Location.Y);
            }
        }

        private void Timer_Pb5_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                sortear();
                Timer_Pb5.Stop();
                timer1.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                sortear();
                Timer_Pb5.Stop();
                timer2.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                sortear();
                Timer_Pb5.Stop();
                Timer_Pb10.Start();
            }

            else if (numrand == 1)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y - 10);
            }
            else if (numrand == 2)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
            }
            else if (numrand == 3)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y - 10);
            }
        }

        private void Timer_Pb7_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                sortear();
                Timer_Pb7.Stop();
                timer1.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                sortear();
                Timer_Pb7.Stop();
                timer2.Start();
            }
            else if (pictureBox4.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                sortear();
                Timer_Pb7.Stop();
                Timer_Pb10.Start();
            }

            else if (numrand == 1)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y + 10);
            }
            else if (numrand == 2)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
            }
            else if (numrand == 3)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y + 10);
            }
        }

        private void Timer_Pb2_Tick(object sender, EventArgs e)
        {
            //se a bola tocar em algo
            if (pictureBox4.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                timer2.Stop();
                timer1.Start();
            }

            //direções da bola
            else if (numrand == 1)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y + 3);
            }
            else if (numrand == 2)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y +6);
            }
            else if (numrand == 3)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y + 10);
            }
        }

        private void Timer_Pb3_Tick(object sender, EventArgs e)
        {
            //se a bola tocar em algo
            if (pictureBox4.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                timer2.Stop();
                timer1.Start();
            }

            //direções da bola
            else if (numrand == 1)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y - 3);
            }
            else if (numrand == 2)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y - 6);
            }
            else if (numrand == 3)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y - 10);
            }
        }
    }
}
