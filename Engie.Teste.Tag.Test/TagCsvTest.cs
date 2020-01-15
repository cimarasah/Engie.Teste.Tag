using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Engie.Teste.Aplicacao.Service;
using Engie.Teste.Dtos;
using NUnit.Framework;
using Xunit;
using Assert = Xunit.Assert;

namespace Engie.Teste.Tag.Test
{
    public class TagCsvTest
    {
        private ServiceTag service;
        
        public TagCsvTest()
        {
            service = new ServiceTag();
        }

        [Fact(DisplayName = "Import Csv")]
        public void ImportCsv()
        {
            
            var lista = service.ImportCsv();
            Assert.Equal("CNCO_GAS.analog.ACAgFQA-FI.curval", lista.First().NomeTagWebService) ;
        }
        [Fact(DisplayName = "Importar Csv via API")]
        public void ImportarCsvViaApi()
        {
            var date = DateTime.Now.AddDays(-1);
            var param = new ParametrosTranspetroDto()
            {
               
                DataInicial = new DateTime(date.Year,date.Month, date.Day, 14, 00, 00),
                DataFinal = new DateTime(date.Year, date.Month, date.Day, 15, 00, 00),
                IntervaloMedicao = 3600,
                Login = "02709449000159",
                Senha = "t@g45$g",
                Path = "C:/tmp"
            };
            var lista = service.ImportarCsvViaApi(param);
            CollectionAssert.IsNotEmpty(lista);
        }
    }
}