using System;
using System.Collections.Generic;
using System.Text;

namespace Engie.Teste.Dtos
{
    public class TagDto
    {
        public string NomeTagWebService { get; set; }
        public DateTime DataHoraMedicao { get; set; }
        public string ValorMedicao { get; set; }
        public QualidadeEnum Qualidade { get; set; }
    }
}
