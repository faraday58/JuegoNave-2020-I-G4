using System;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoNave_2020_I_G4
{
    public partial class Form1 : Form
    {
        private Nave miNave;

        public Form1()
        {
            InitializeComponent();
            miNave = new Nave((short)((this.Width / 2)-23), (short)(this.Height - 96));
            AgregarPersonaje();
        }
        public void AgregarPersonaje()
        {
            this.Controls.Add(miNave.SptPersonaje);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode )
            {
                case Keys.Up:
                    miNave.Movimiento(0,-5);
                    break;
                case Keys.Down:

                    break;
                case Keys.Left:

                    break;
                case Keys.Right:

                    break;                
            }
        }
    }
}
