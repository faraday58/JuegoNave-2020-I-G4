using System;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoNave_2020_I_G4
{
    public partial class Form1 : Form
    {
        private Nave miNave;
        private sbyte desplazamiento;
        private Enemigo miEnemigo;

        public Form1()
        {
            InitializeComponent();
            this.Width = ConstanteJuego.anchoVentana;
            this.Height = ConstanteJuego.altoVentana;
            desplazamiento = 10;
            miNave = new Nave((short)((this.Width / 2)-23), (short)(this.Height - 96));
            miEnemigo = new Enemigo();
            AgregarPersonaje();
            TemporizadorLoop.Start();
        }
        public void AgregarPersonaje()
        {
            this.Controls.Add(miNave.SptPersonaje);
            this.Controls.Add(miEnemigo.SptPersonaje);
        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode )
            {
                case Keys.Up:
                    miNave.Mover(0,(short)-desplazamiento);
                    break;
                case Keys.Down:
                    miNave.Mover(0, desplazamiento);
                    break;
                case Keys.Left:
                    miNave.Mover((short)-desplazamiento, 0);
                    break;
                case Keys.Right:
                    miNave.Mover(desplazamiento, 0);
                    break;                
            }
        }

        private void TemporizadorLoop_Tick(object sender, EventArgs e)
        {
            miEnemigo.Mover(desplazamiento, 0);
        }
    }
}
