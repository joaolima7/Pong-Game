using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            SoundPlayer select = new SoundPlayer(@"C:\Pong Game\Resources\150222__pumodi__menu-select.wav"); 
            if(e.KeyCode == Keys.Down)
            {
                if (pictureBox1.Visible)
                {
                    select.Play();
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    
                }
                else if (pictureBox2.Visible)
                {
                    select.Play();
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                }
                else if (pictureBox3.Visible)
                {
                    select.Play();
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                }
                else if (pictureBox4.Visible)
                {
                    select.Play();
                    pictureBox4.Visible = false;
                    pictureBox1.Visible = true;
                }
            }
            else if(e.KeyCode == Keys.Up)
            {
                if (pictureBox1.Visible)
                {
                    select.Play();
                    pictureBox1.Visible = false;
                    pictureBox4.Visible = true;
                }
                else if (pictureBox2.Visible)
                {
                    select.Play();
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = true;
                }
                else if (pictureBox3.Visible)
                {
                    select.Play();
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = true;
                }
                else if (pictureBox4.Visible)
                {
                    select.Play();
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = true;
                }
            }
            else if(e.KeyCode == Keys.Enter)
            {
                if (pictureBox1.Visible)
                {
                    Tela_Game game = new Tela_Game();
                    game.Show();
                    this.Hide();
                }
                else if (pictureBox2.Visible)
                {

                }
                else if (pictureBox3.Visible)
                {

                }
                else if (pictureBox4.Visible)
                {
                    DialogResult sair = MessageBox.Show("Deseja Sair do Jogo?","SAIR",MessageBoxButtons.YesNo);
                    if(sair == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
