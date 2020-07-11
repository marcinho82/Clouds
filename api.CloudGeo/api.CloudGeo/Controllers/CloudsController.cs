using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.CloudGeo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.CloudGeo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CloudsController : ControllerBase
    {
        // POST api/<CloudsController>
        [HttpPost]
        public string Post([FromBody] Weather weather)
        {
            string[,] terreno = new string[10, 10];
            Random numero = new Random();
            int linhaUltima = 0;
            int colunaUltima = 0;

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    terreno[i, j] = "*";
                }
            }

            int aeroportos = Convert.ToInt32(weather.aeroporto);

            for (int i = 0; i <= Convert.ToInt32(weather.nuvem) - 1 ; i++)
            {
                terreno[0, i] = ".";
            }

            for (int i = 0; i < aeroportos - 1; i++)
            {
                var linha = numero.Next(0, 9);
                var coluna = numero.Next(0, 9);

                terreno[linha, coluna] = "A";
                if (i == aeroportos - 1)
                {
                    linhaUltima = linha;
                    colunaUltima = coluna;
                }
            }

            for (int i = 0; i <= 9 ; i++)
            {
                terreno[i, i] = ".";
                for (int j = i+1; j <= 9; j++)
                {
                    terreno[j, i] = ".";
                    if (terreno[i, j] == terreno[linhaUltima,colunaUltima])
                    {
                         break;
                    }
                }
               
            }

            return terreno.ToString();
        }       
    }
}
