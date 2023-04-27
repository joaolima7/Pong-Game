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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Game_KeyDown(object sender, KeyEventArgs e)
        {
            
             if (e.KeyCode == Keys.Up)
            {
                if (Racket_Az.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    Racket_Az.Location = new Point(Racket_Az.Location.X, Racket_Az.Location.Y );
                }
                else
                {
                    Racket_Az.Location = new Point(Racket_Az.Location.X, Racket_Az.Location.Y - 10);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (Racket_Az.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    Racket_Az.Location = new Point(Racket_Az.Location.X, Racket_Az.Location.Y);
                }
                else
                {
                    Racket_Az.Location = new Point(Racket_Az.Location.X, Racket_Az.Location.Y + 10);
                }
                
            }
            else if (e.KeyCode == Keys.W)
            {
                if (Racket_Vm.Bounds.IntersectsWith(pictureBox2.Bounds))
                {
                    Racket_Vm.Location = new Point(Racket_Vm.Location.X, Racket_Vm.Location.Y);
                }
                else
                {
                    Racket_Vm.Location = new Point(Racket_Vm.Location.X, Racket_Vm.Location.Y - 10);
                }
               
            }
            else if (e.KeyCode == Keys.S)
            {
                if (Racket_Vm.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    Racket_Vm.Location = new Point(Racket_Vm.Location.X, Racket_Vm.Location.Y);
                }
                else
                {
                    Racket_Vm.Location = new Point(Racket_Vm.Location.X, Racket_Vm.Location.Y + 10);
                }
                
            }

        }
    }
}
