using System;
using PersonasClases;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoNave_2020_I_G4
{
    public partial class FormRegistrar : Form
    {
        private Persona[] personas;
        private byte indPers;
        private Form formpadre;
        private ErrorProvider errorProvider;
        private byte TipoError;

        public FormRegistrar(Form formpadre)
        {
            this.formpadre = formpadre;
            InitializeComponent();
            personas = new Persona[3];
            errorProvider = new ErrorProvider();

        }
        #region Encapsulamiento
        public byte IndPers {
            get => indPers;

            set
            {
                if (value > 2)
                {
                    indPers = 0;
                }

                else
                {
                 indPers = value;
                }
               
            }
        }

        public Persona[] Personas { get => personas; }
        #endregion
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona();
                errorProvider.Clear();
                persona.Nickname = txtbNick.Text;
                if (persona.Nickname == "")
                {
                    string error = "No se puede dejar el campo vacío";
                    TipoError = 0;
                    throw new ApplicationException(error);
                    
                }
                persona.Password = txtbPass.Text;
                if(txtbPass.Text == "" )
                {
                    txtbPass.Text = persona.Password;
                    TipoError = 1;
                }

                persona.Correo = txtbMail.Text;
                if(txtbMail.Text == "")
                {
                    string error = "No se puede quedar el campo vacío";
                    TipoError = 2;
                    throw new ApplicationException(error);
                }else if(  !persona.Correo.Contains("@")   )
                {
                    string error = "Se debe agregar un símbolo '@'";
                    TipoError = 2;
                    throw new ApplicationException(error);
                }else if (!persona.Correo.Contains("."))
                {
                    string error = "Se debe agregar un '.'";
                    TipoError = 2;
                    throw new ApplicationException(error);
                }
                byte pos1 = 0;
                byte pos2 = 0;
                for(int i=0; i < persona.Correo.Length; i++)
                {
                   char caracter= persona.Correo[i];
                    if (caracter == 64)
                    {
                        pos1 = (byte)i;
                    }
                    if (caracter == 46)
                    {
                        pos2 = (byte)i;
                    }
                }
                if (pos1 > pos2)
                {
                    string error = "NO es valido el correo";
                    TipoError = 2;
                    throw new ApplicationException(error);
                }


                persona.Pregunta = cmbPregunta.Items[cmbPregunta.SelectedIndex].ToString();
                persona.Respuesta = txtbAns.Text;
                if (txtbAns.Text == "")
                {
                    string error = "No se puede quedar el campo vacío";
                    TipoError = 3;
                    throw new ApplicationException(error);
                }
                personas[IndPers++] = persona;

                this.Hide();
                formpadre.Show();
            }
            catch (ApplicationException error)
            {
                switch (TipoError)
                {
                    case 0:
                        errorProvider.SetError(txtbNick, error.Message);
                        break;
                    case 1:
                        errorProvider.SetError(txtbPass, error.Message);
                        break;
                    case 2:
                        errorProvider.SetError(txtbMail, error.Message);
                        break;
                    case 3:
                        errorProvider.SetError(txtbAns, error.Message);
                        break;

                }
                
            }
            catch (ArgumentOutOfRangeException)
            {
                errorProvider.SetError(cmbPregunta, "Debes seleccionar una pregunta");

            }
            catch
            {
                MessageBox.Show("Hubo un error");
            }
                   
            
        }

        private void FormRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            formpadre.Show();
        }
    }
}
