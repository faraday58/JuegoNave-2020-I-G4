using System;
using System.Windows.Forms;
using System.Drawing;

namespace JuegoNave_2020_I_G4
{
    class Enemigo: Personaje
    {
        bool left;

        public Enemigo()
        {
            PosX = ConstanteJuego.anchoVentana/2;
            PosY = ConstanteJuego.altoVentana / 3;
            SptPersonaje.Image = Properties.Resources.enemy_small;
            SptPersonaje.Size = new Size(Ancho, Altura);
            SptPersonaje.Location = new Point(PosX,PosY);
            SptPersonaje.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        public override void Mover(short xdir, short ydir)
        {
            if (PosX >= ConstanteJuego.anchoVentana - 2 * (Properties.Resources.enemy_small.Width))
            {
                left = true;
            }
            if (PosX == 0)
            {
                left = false;
            }
            if (left == true)
            {
                xdir = -10;
            }
            base.Mover(xdir, 0);
            SptPersonaje.Location = new Point(PosX, PosY);
        }
    }
}
