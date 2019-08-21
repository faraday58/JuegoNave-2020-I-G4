using System;
using System.Windows.Forms;
using System.Drawing;

namespace JuegoNave_2020_I_G4
{
    class Nave:Personaje
    {
        /// <summary>
        /// Constructor para dar posición a la Nave
        /// </summary>
        /// <param name="x">Establece la posición inicial de la nave en el Eje X y es controlada por PosX</param>
        /// <param name="y">Establce la posición inicial de la nave en el Eje Y y es controlada por PosY</param>


        public Nave(short x, short y)
        {
            PosX = x;
            PosY = y;
            SptPersonaje.Image = Properties.Resources.shipm;
            SptPersonaje.Size = new Size(Ancho, Altura);
            SptPersonaje.Location = new Point(PosX, PosY);
            SptPersonaje.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        public override void Movimiento(short xdir, short ydir)
        {
            base.Movimiento(xdir, ydir);
            SptPersonaje.Location = new Point(PosX, PosY);
        }

    }
}
