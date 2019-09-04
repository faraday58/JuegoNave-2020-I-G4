using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoNave_2020_I_G4
{
    public partial class FormAcceso : Form
    {
        private Form1 formJuego;
        string[] usuarios;
        string[] contraseñas;
        ErrorProvider mierror;
        public FormAcceso()
        {
            InitializeComponent();
            mierror = new ErrorProvider();
            usuarios = new string[]
            {
                "usuario1",
                "antonioEstrella",
                "NoobMaster69"
            };

            contraseñas = new string[]
            {
                "pass123",
                "destroyer",
                "wrongpass"

            };

            txtbContraseña.PasswordChar ='*';

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtbUsuario.Text;
            string contraseña = txtbContraseña.Text;
               
            if(usuario== usuarios[0] && contraseña == contraseñas[0] || usuario == usuarios[1] && contraseña == contraseñas[1] || usuario == usuarios[2] && contraseña == contraseñas[2])
            {
                if ( formJuego == null   )
                 {
              

                         formJuego = new Form1(this);
                         formJuego.Show();
                         this.Hide();
                          formJuego = null;
                }
                mierror.Clear();
                
            }
            else
            {
                mierror.SetError(txtbContraseña, "Contraseña incorrecta");
            }




        }
    }
}
