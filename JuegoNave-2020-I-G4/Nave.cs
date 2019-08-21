using System;
using System.Windows.Forms;
using System.Drawing;

namespace JuegoNave_2020_I_G4
{
    class Nave:Personaje
    {

        public Nave(short x, short y)
        {
            PosX = x;
            PosY = y;
            SptPersonaje.Image = Properties.Resources.clouds_transparent;

        }

    }
}
