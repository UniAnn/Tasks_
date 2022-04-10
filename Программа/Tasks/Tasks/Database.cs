using Npgsql;

namespace Tasks
{
    class Database
    {
        private static Database instance;
        static private string parameters;
        public NpgsqlConnection connection;
        private Database()
        {

        }
        public static Database GetInstance()
        {
            if (instance is null)
            {
                instance = new Database();
            }
            return instance;
        }
        static public void SetParameters(string login, string password)
        {

        }
        public void Clear()
        {

        }
    }
}
