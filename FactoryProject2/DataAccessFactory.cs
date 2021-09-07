using System;
namespace FactoryProject2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string dataBaseType)
        {
            switch (dataBaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();

                case "sql":
                    return new SQLDataAccess();

                case "mongo":
                    return new MongoDataAccess();

                default:
                    return new ListDataAccess();
            }
        }
    }
}
