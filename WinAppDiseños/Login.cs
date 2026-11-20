using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace WinAppDiseños
{
    public partial class Login : Form
    {
        private SoundPlayer soundPlayer;
        String usuario4 = "usuario_demo_4";
        String usuario1 = "usuario_demo_1";
        String usuario2 = "usuario_demo_2";
        String usuario3 = "usuario_demo_3";
        String usuario5 = "usuario_demo_5";
        String usuario6 = "usuario_demo_6";
        String usuario7 = "usuario_demo_7";
        string contra = "CONFIGURAR_CLAVE_DEMO_LOCALMENTE";

        public Login()
        {
            InitializeComponent();
            //soundPlayer = new SoundPlayer("Directorio del sonido que quiere que haga");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox4.Location.X;
            int y = pictureBox4.Location.Y;
            x = x + 5;
            if (x >= 360)
            {
                x = 10;
            }
            Point punto = new Point(x, y);
            pictureBox4.Location = punto;

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //soundPlayer.Play();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //soundPlayer.Play();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //soundPlayer.Play();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(width: 34, height: 35);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(width: 29, height: 30);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(width: 34, height: 35);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(width: 29, height: 30);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(width: 34, height: 35);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(width: 29, height: 30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {

                btnregistrar_Click_1(sender, e);
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 145, height: 109);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(width: 137, height: 101);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == usuario1 || textBox1.Text == usuario2 || textBox1.Text == usuario3 || textBox1.Text == usuario4 || textBox1.Text == usuario5 || textBox1.Text == usuario6 || textBox1.Text == usuario7 || textBox2.Text == contra)
                {
                    Pagina_principal objetopin = new Pagina_principal();

                    string informacion = textBox1.Text; // Obtener el texto del TextBox

                    // Pasar la información al segundo formulario
                    objetopin.RecibirInformacion(informacion);
                    objetopin.ShowDialog();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroUsuario llmarform = new RegistroUsuario();
            llmarform.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        { 
            /*
            // bypass para no estar ingresando usuario y contrasenia durante las pruebas
            Pagina_principal objetopin = new Pagina_principal();
            objetopin.ShowDialog();*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
