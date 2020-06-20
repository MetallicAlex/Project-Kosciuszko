using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kosciuszko
{
    public partial class MainForm : Form
    {
        private bool dragMainForm = false;
        private Point startPositionMainForm = new Point(0, 0);
        public MainForm()
        {
            InitializeComponent();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragMainForm = true;
            startPositionMainForm = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragMainForm)
            {
                Point point = PointToScreen(e.Location);
                this.Location = new Point(point.X - startPositionMainForm.X, point.Y - startPositionMainForm.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragMainForm = false;
        }

        private void pictureClose_MouseMove(object sender, MouseEventArgs e)
        {
            pictureClose.BackColor = Color.FromArgb(150, 70, 70, 70);
        }

        private void pictureClose_MouseLeave(object sender, EventArgs e)
        {
            pictureClose.BackColor = Color.Transparent;
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            pictureMinimize.BackColor = Color.FromArgb(150, 70, 70, 70);
        }

        private void pictureMinimize_MouseLeave(object sender, EventArgs e)
        {
            pictureMinimize.BackColor = Color.Transparent;
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureWindowState_MouseMove(object sender, MouseEventArgs e)
        {
            pictureWindowState.BackColor = Color.FromArgb(150, 70, 70, 70);
        }

        private void pictureWindowState_MouseLeave(object sender, EventArgs e)
        {
            pictureWindowState.BackColor = Color.Transparent;
        }

        private void pictureWindowState_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                pictureWindowState.Image = Image.FromFile(@"../../Resources/ButtonMaximize.png");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                pictureWindowState.Image = Image.FromFile(@"../../Resources/ButtonRestore.png");
            }
        }
    }
}
