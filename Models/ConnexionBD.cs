using MySql.Data.MySqlClient;
namespace Models
{
    public class ConnexionBD
    {
        private readonly string chaineConnexion;

        // constructeur de la classe
        public ConnexionBD()
        {
            chaineConnexion = "SERVER=127.0.0.1;DATABASE=laundry;UID=root";
        }

        //methode d'acces a la connexion
        protected MySqlConnection getConnection()
        {
            return new MySqlConnection(chaineConnexion);
        }
    }
}
