using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Engie.Teste.Aplicacao.Extension;
using Engie.Teste.Dtos;

namespace Engie.Teste.Aplicacao.Service
{
    public class ServiceTag
    {
        public List<TagDto> ImportCsv()
        {
            try
            {
                var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string filePath = Path.Combine(projectPath, "Resources\\RecordExport.csv");
                return MapTagCsv(ImportExtension.ImportCsv(4,new StreamReader(filePath)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<TagDto> MapTagCsv(List<string[]> listRows)
        {
            List<TagDto> listData = new List<TagDto>();
            TagDto importingData;
            listRows.ForEach(
                row =>
                {
                    importingData = new TagDto()
                    {
                        NomeTagWebService = row[0],
                        DataHoraMedicao = DateTime.Parse(row[1]),
                        ValorMedicao = row[2],
                        Qualidade = (QualidadeEnum)Enum.Parse(typeof(QualidadeEnum), row[3])
                    };
                    listData.Add(importingData);
                }
            );
            return listData;
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
