using System;
using System.Collections.Generic;

namespace FactoryProject2
{
    public interface IDataAccess
    {
        public List<Product> LoadData();

        public void SaveData();
    }
}
