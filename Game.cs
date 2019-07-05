using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingAirplane
{
    
    public partial class Game : Form
    {
        Airplane a = new Airplane();
        
        public Game()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            
        }

        private void Game_Load(object sender, EventArgs e)
        {

            this.TransparencyKey = Color.Aqua;

            a = new Airplane(50, pbPlane.Location.X, pbPlane.Location.Y, 15, Color.Red);
            
            pbPlane.BackColor = Color.Transparent;


            pbPlane.Height = 100;
            pbPlane.Width = 100;
           // pbPlane.BackgroundImage = this.BackgroundImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pbPlane_Click(object sender, EventArgs e)
        {
            
        }

        private void pbPlane_MouseClick(object sender, MouseEventArgs e)
        {
            pbPlane.Location=a.Move(e.Location.X, e.Location.Y, this.Left, this.Top, this.Width, this.Height);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbPlane.Location = a.MoveDown(this.Height);
            Invalidate(true);
        }
    }
}
