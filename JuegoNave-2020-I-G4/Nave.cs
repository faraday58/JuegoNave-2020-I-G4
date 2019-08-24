using System;
using System.Windows.Forms;
using System.Drawing;

namespace JuegoNave_2020_I_G4
{
    class Nave:Personaje
    {
        public override short PosX {
            get => base.PosX;
            set
            {
                if( value < 0  )
                {
                    PosX = 0;
                }
                else if (value > ConstanteJuego.anchoVentana - Ancho*2 )
                {
                    PosX = (short)(ConstanteJuego.anchoVentana - Ancho*2);
                }
                else
                {
                    base.PosX  = value; 
                }

            }
        }


        public override short PosY
        {
            get => base.PosY;
            set
            {
                if (value < 0)
                {
                    PosY = 0;
                }
                else if (value > ConstanteJuego.altoVentana - (Altura*2))
                {
                    PosY = (short)(ConstanteJuego.altoVentana - ((Altura)* 2));
                }
                else
                {
                    base.PosY = value;
                }

            }
        }


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

        public override void Mover(short xdir, short ydir)
        {
            base.Mover(xdir, ydir);
            SptPersonaje.Location = new Point(PosX, PosY);
        }

    }
}
