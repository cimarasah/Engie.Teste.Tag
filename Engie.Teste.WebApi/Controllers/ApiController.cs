using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Engie.Teste.Aplicacao.Service;
using Engie.Teste.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Engie.Teste.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private ServiceTag service;

        public ApiController()
        {
            service = new ServiceTag();
        }
        [HttpGet("ImportViaPath/{path}")]
        public ActionResult<IEnumerable<TagDto>> ImportCsvToPath(string path)
        {
            return Ok(service.ImportCsv());
        }

        [HttpGet("ImportViaApi/{path}")]
        public ActionResult<IEnumerable<TagDto>> ImportarCsvViaApi(ParametrosTranspetroDto param)
        {
            return Ok(service.ImportarCsvViaApi(param));
        }

    }
}
