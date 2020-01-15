using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engie.Teste.DAL.Mock
{
    public class DataBaseMock<T> where T : class
    {
        private readonly List<T> dataSet;


        public DataBaseMock(List<T> dataSet)
        {
            this.dataSet = dataSet;

        }
        public bool insert(T entity)
        {
            dataSet.Add(entity);
            return true;
        }       
        public List<T> GetList()
        {
            return dataSet;
        }


    }
}
