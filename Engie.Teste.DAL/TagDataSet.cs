using System;
using System.Collections.Generic;
using System.Text;
using Engie.Teste.DAL.Interface.Entities;

namespace Engie.Teste.DAL.Mock
{
    public class TagDataSet : DataBaseMock<TagEntity>
    {
        private static List<TagEntity> dataSetTag;

        public TagDataSet()
            : base(dataSetTag)
        {
            if (dataSetTag == null) dataSetTag = new List<TagEntity>();
        }

        
    }
}
