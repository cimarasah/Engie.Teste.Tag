using System;
using System.Collections.Generic;
using System.Text;
using Engie.Teste.DAL.Interface.Entities;

namespace Engie.Teste.DAL.Mock
{
    public class TagReferenciaDataSet : DataBaseMock<TagReferencia>
    {
        private static List<TagReferencia> dataSetTagReferencia;

        public TagReferenciaDataSet()
            : base(dataSetTagReferencia)
        {
            if (dataSetTagReferencia == null) dataSetTagReferencia = new List<TagReferencia>();
        }

        
    }
}
