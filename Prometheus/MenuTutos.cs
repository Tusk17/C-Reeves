using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LearnKode
{
    public partial class MenuTutos : Form
    {
        int numTuto;
        public MenuTutos()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio abrirPantallaCarga = new Inicio();
            abrirPantallaCarga.Show();
            this.Hide();
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tuto1_Click(object sender, EventArgs e)
        {
            numTuto = 1;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }

        private void tuto2_Click(object sender, EventArgs e)
        {
            numTuto = 2;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }

        private void tuto3_Click(object sender, EventArgs e)
        {
            numTuto = 3;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }

        private void tuto4_Click(object sender, EventArgs e)
        {
            numTuto = 4;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }

        private void tuto5_Click(object sender, EventArgs e)
        {
            numTuto = 5;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }

        private void tuto6_Click(object sender, EventArgs e)
        {
            numTuto = 6;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }

        private void tuto7_Click(object sender, EventArgs e)
        {
            numTuto = 7;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }

        private void tuto8_Click(object sender, EventArgs e)
        {
            numTuto = 8;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }

        private void tuto9_Click(object sender, EventArgs e)
        {
            numTuto = 9;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }

        private void tuto10_Click(object sender, EventArgs e)
        {
            numTuto = 10;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }

        private void tuto11_Click(object sender, EventArgs e)
        {
            numTuto = 11;
            TutorialTEA tuto = new TutorialTEA(numTuto);
            tuto.Show();
            this.Hide();
        }
    }
}
