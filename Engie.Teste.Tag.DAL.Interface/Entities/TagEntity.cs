using System;
using System.Collections.Generic;
using System.Text;

namespace Engie.Teste.DAL.Interface.Entities
{
    public class TagEntity
    {
        public string NomeTagWebService { get; set; }
        public DateTime DataHoraMedicao { get; set; }
        public string ValorMedicao { get; set; }
        public int Qualidade { get; set; }
    }
}
