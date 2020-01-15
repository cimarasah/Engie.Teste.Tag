using System;
using System.Collections.Generic;
using System.Text;

namespace Engie.Teste.DAL.Interface.Entities
{
    public class TagReferencia
    {
        public string NomeTagWebService { get; set; }
        public string NomeTag { get; set; }
        public string DescricaoTag { get; set; }
        public Localidade Localidade { get; set; }
    }
}
