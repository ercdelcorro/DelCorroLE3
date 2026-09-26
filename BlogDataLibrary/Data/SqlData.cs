using BlogDataLibrary.Database;

namespace BlogDataLibrary.Data
{
    public class SqlData
    {
        private ISqlDataAccess _db;
        private const string connectionStringName = "SqlDB";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }
    }
}