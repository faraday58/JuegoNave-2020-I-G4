using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoNave_2020_I_G4
{
    public partial class FormAcceso : Form
    {
        private Form1 formJuego;
        private FormRegistrar formRegistrar1;
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

            txtbUsuario.Text = formRegistrar1.Personas[0].Nickname;
            txtbContraseña.Text = formRegistrar1.Personas[0].Password;
               
            if(usuario== formRegistrar1.Personas[0].Nickname && contraseña == formRegistrar1.Personas[0].Password || usuario == usuarios[1] && contraseña == contraseñas[1] || usuario == usuarios[2] && contraseña == contraseñas[2])
            {
                if ( formJuego == null   )
                 {
              

                         formJuego = new Form1(this);
                         formJuego.Show();
                         this.Hide();
                          formJuego = null;
                    txtbContraseña.Text = null;
                    txtbUsuario.Text = null;
                }
                mierror.Clear();
               
            }
            else
            {
                mierror.SetError(txtbContraseña, "Contraseña incorrecta");
            }

       


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            formRegistrar1 = new FormRegistrar(this);
            formRegistrar1.Show();
            this.Hide(); 
            
            


        }
    }
}
