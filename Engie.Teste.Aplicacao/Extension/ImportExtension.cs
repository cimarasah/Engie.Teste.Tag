using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using Engie.Teste.Dtos;

namespace Engie.Teste.Aplicacao.Extension
{
    public static class ImportExtension
    {
        public static List<string[]> ImportCsv(int qtdRow, StreamReader streamReader)
        {
            string line;
            string[] row = new string[qtdRow];
            List<string[]> listResult = new List<string[]>();
            using (streamReader)
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    row = line.Split(',');
                    listResult.Add(row);
                }
            }
            return listResult;
        }

        const string UrlWS = "https://ceteh.transpetro.com.br/medicao.api/medicao/listar-medicao-tags-tempo";
       
        

        public static List<TagDto> ImportarCsvViaApi(ParametrosTranspetroDto param)
        {
            var url = MontarUrl(param);
            var request = (HttpWebRequest)WebRequest.Create(url);

            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            request.ContentType = "text/html";
            request.Method = "GET";

            var basicEncoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{param.Login}:{param.Senha}"));
            request.Headers.Add($"Authorization: Basic {basicEncoded}");

            WebResponse response = null;
            Stream streamResponse = null;

            try
            {
                using (response = request.GetResponse())
                {
                    streamResponse = response.GetResponseStream();
                    return ImportCsvByStream(new StreamReader(streamResponse));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        private static List<TagDto> ImportCsvByStream(StreamReader streamReader)
        {
            List<TagDto> listData = new List<TagDto>();
            TagDto importingData;
            string line;
            string[] row = new string[4];
            using (streamReader)
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    importingData = new TagDto();
                    row = line.Split(',');

                    importingData = new TagDto()
                    {
                        NomeTagWebService = row[0],
                        DataHoraMedicao = DateTime.Parse(row[1]),
                        ValorMedicao = row[2],
                        Qualidade = (QualidadeEnum)Enum.Parse(typeof(QualidadeEnum), row[3])
                    };
                    listData.Add(importingData);
                }
                return listData;
            }
        }
        private static string MontarUrl(ParametrosTranspetroDto param)
        {
            return UrlWS + "/" + DateFormat(param.DataInicial) + "/" + DateFormat(param.DataFinal) + "/" + param.IntervaloMedicao;
        }
        public static string DateFormat(DateTime date)
        {
            return date.ToString("ddMMyyyy-HHmm");
        }
       
    }
}
