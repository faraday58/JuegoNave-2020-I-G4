using System;


namespace PersonasClases
{
    public class Persona
    {
        #region Atributos 
        private string nickname;
        private string password;
        private string correo;
        private string pregunta;
        #endregion
        //

        #region Encapsulamiento
        public string Nickname { get => nickname; set => nickname = value; }
        public string Password { get => password;
            set
            {
                if( value == "" )
                {
                    password = GenerarPassword();
                }
                else
                {
                    password = value;
                }
                
            }
        }
        public string Correo { get => correo; set => correo = value; }
        public string Pregunta { get => pregunta; set => pregunta = value; }
        #endregion

        #region Métodos

        public string GenerarPassword()
        {
            Random aleatorio = new Random();
            int[] P1 = new int[12];
            for (int i=0; i<12; i++)
            {
                P1[i] = aleatorio.Next(38, 122);
                password = password + (char)P1[i];
            }
            return password;


        }


        #endregion

    }
}
