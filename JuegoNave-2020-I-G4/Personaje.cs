using System;
using System.Windows.Forms;
namespace JuegoNave_2020_I_G4
{
    class Personaje
    {

        #region Atributos
        private short ancho;
        private short altura;
        private short posX;
        private short posY;
        private PictureBox sptPersonaje;


        #endregion

        #region Propiedades
        public short Ancho { get => ancho; set => ancho = value; }
        public short Altura { get => altura; set => altura = value; }
        public short PosX { get => posX; set => posX = value; }
        public short PosY { get => posY; set => posY = value; }
        public PictureBox SptPersonaje { get => sptPersonaje; set => sptPersonaje = value; }
        #endregion

        #region Constructor
        public Personaje()
        {
            Ancho = 23;
            Altura = 48;
            SptPersonaje = new PictureBox();
        }
        #endregion

        #region Métodos
        public bool Interseccion(Personaje personaje)
        {
            short difx = Convert.ToInt16(Math.Abs(this.PosX - personaje.PosX));
            short dify = Convert.ToInt16(Math.Abs(PosY - personaje.PosY));

            if (difx >= 0 && difx < Ancho && dify >= 0 && dify < Altura)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Establece el movimiento del personaje en los ejes X y Y
        /// </summary>
        /// <param name="xdir">desplazamiento en X</param>
        /// <param name="ydir">desplazamiento en Y</param>

        public virtual void Movimiento(short xdir, short ydir)
        {
            PosX += xdir;
            PosY += ydir;
        }
        #endregion
    }
}
