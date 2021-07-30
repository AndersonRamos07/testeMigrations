using aros_hi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aros_hi.Controllers
{
    [ApiController]
    [Route("v1/TodoApi/")]
    public class TodoApiController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<List<TodoApi>> Listar([FromServices] Context dados) 
        {
            return await dados.TodoApis.ToListAsync();
        }

        [HttpGet]
        [Route("NovaTabelasECampos")]
        public async void NovasTabelasECampos([FromServices] Context dados) 
        {
            dados.Database.Migrate();
        }
    }
}
