using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppEstudos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int PositionX;
        int PositionY;
        bool mDown;
        private void label2_Click(object sender, EventArgs e)
        {
            if (label3.ForeColor == Color.Green)
            {
                TopMost = false;
                label3.ForeColor = Color.Red;
                label3.Text = "OFF";
                
            }
            else
            {
                TopMost = true;
                label3.ForeColor = Color.Green;
                label3.Text = "ON";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                timer1.Start();
            }
        }

        private void Fecha()
        {
            if (Opacity <= 0)
                Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity <= 1)
            {
                Opacity -= 0.045;

                lblNum.Text = Opacity.ToString() + "%";

                if (lblNum.Text == "0,955%")
                {
                    lblNum.ForeColor = Color.Green;
                }
                else if (lblNum.Text == "0,73%")
                {
                    lblNum.ForeColor = Color.GreenYellow;
                }
                else if (lblNum.Text == "0,505%")
                {
                    lblNum.ForeColor = Color.Red; ;
                }
            }
            Fecha();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Opacity != 1)
            {
                Opacity += 0.045;
                lblNum.Text = Opacity.ToString() + "%";

                if (lblNum.Text == "1%")
                {
                    lblNum.ForeColor = Color.Green;
                    lblNum.Text = "100%";
                    timer2.Stop();
                }
                else if (lblNum.Text == "0,54%")
                {
                    lblNum.ForeColor = Color.Yellow;
                }
                else if (lblNum.Text == "0,765%")
                {
                    lblNum.ForeColor = Color.GreenYellow;
                }
            }
        }

        #region MoveWithOutBorder
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //PositionX = e.X;
            //PositionY = e.Y;
            //mDown = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (mDown)
            //    SetDesktopLocation(MousePosition.X - PositionX, MousePosition.Y - PositionY);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //mDown = false;
        }
        #endregion
    }
}
