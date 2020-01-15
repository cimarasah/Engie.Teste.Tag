using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Engie.Teste.Aplicacao.Extension;
using Engie.Teste.Dtos;

namespace Engie.Teste.Aplicacao.Service
{
    public class ServiceTranspetro
    {
        public List<TagReferenciaDto> ImportCsv()
        {
            try
            {
                return null;// ImportExtension.ImportCsv();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TagDto> ImportarCsvViaApi(ParametrosTranspetroDto param)
        {
            try
            {
                return ImportExtension.ImportarCsvViaApi(param);
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }
    }
}
