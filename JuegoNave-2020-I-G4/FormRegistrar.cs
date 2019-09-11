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

        public FormRegistrar(Form formpadre)
        {
            this.formpadre = formpadre;
            InitializeComponent();
            personas = new Persona[3];
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
            Persona persona = new Persona();
            persona.Nickname = txtbNick.Text;
            persona.Password = txtbPass.Text;
            persona.Correo = txtbMail.Text;
            persona.Pregunta = cmbPregunta.Items[cmbPregunta.SelectedIndex].ToString();
            persona.Respuesta = txtbAns.Text;
            personas[IndPers++] = persona;

            this.Hide();
            formpadre.Show();

        }

        private void FormRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            formpadre.Show();
        }
    }
}
