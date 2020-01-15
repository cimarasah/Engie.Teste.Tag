using System;
using System.Collections.Generic;
using System.Text;

namespace Engie.Teste.Dtos
{
    public class TagReferenciaDto
    {
        public string NomeTagWebService { get; set; }
        public string NomeTag { get; set; }
        public string DescricaoTag { get; set; }
        public LocalidadeDto Localidade { get; set; }
    }
}
