using System;
using System.Collections.Generic;
using System.Text;

namespace Engie.Teste.Dtos
{
    public class ParametrosTranspetroDto
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int IntervaloMedicao { get; set; }
        public string Path { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
