using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace LearnKode
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MainForm abrirPantallaCarga = new MainForm();
            abrirPantallaCarga.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Empezar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Empezar_Click(object sender, EventArgs e)
        {
            MainForm abrirPantallaCarga = new MainForm();
            abrirPantallaCarga.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            MainForm abrirPantallaCarga = new MainForm();
            abrirPantallaCarga.Show();
            this.Hide();
        }

        private void xx_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            TutorialLearnKode AbrirTuto = new TutorialLearnKode();
            AbrirTuto.Show();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MenuTutos AbrirTutoTEA = new MenuTutos();
            AbrirTutoTEA.Show();
            this.Dispose();
        }
    }
}
