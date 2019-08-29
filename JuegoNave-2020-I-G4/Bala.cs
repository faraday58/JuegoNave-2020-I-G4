using System;
using System.Windows.Forms;
using System.Drawing;

namespace JuegoNave_2020_I_G4
{
    class Bala: Personaje
    {
        //Constructor de bala
        public Bala(short x, short y)
        {
            PosX = (short)(x + (Ancho/2));
            PosY = (short)(y + Altura);
            SptPersonaje.Image = Properties.Resources.laser_boltsm;
            Ancho = (short)Properties.Resources.laser_boltsm.Width;
            Altura = (short)Properties.Resources.laser_boltsm.Height;
            SptPersonaje.Size = new Size(Ancho, Altura);
            SptPersonaje.Location = new Point(PosX, PosY);
            SptPersonaje.SizeMode = PictureBoxSizeMode.AutoSize;

        }
        public override void Mover(short xdir, short ydir)
        {
            base.Mover(0, (short)-ydir);
            SptPersonaje.Location = new Point(PosX, PosY);
        }
    }
}
