using api.CloudGeo.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace api.CloudGeo.Calculate
{
    public class Calculate
    {
        public Array[] Dias(Weather weather)
        {
            string[,] terreno = new string[10, 10];
            Random numero = new Random();
            int linhaUltima = 0;
            int colunaUltima = 0;
            bool boolean = false;
            Array[] result = new Array[0];

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    terreno[i, j] = "*";
                }
            }

            int aeroportos = Convert.ToInt32(weather.aeroporto);

            for (int i = 0; i <= Convert.ToInt32(weather.nuvem) - 1; i++)
            {
                terreno[0, i] = ".";
            }

            for (int i = 0; i < aeroportos - 1; i++)
            {
                var linha = numero.Next(0, 9);
                var coluna = numero.Next(0, 9);

                terreno[linha, coluna] = "A";
            }

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (terreno[i, j] == "A")
                    {
                        linhaUltima = i;
                        colunaUltima = j;
                    }
                }
            }


            for (int i = 0; i <= 9; i++)
            {
                
                for (int j = 0; j <= 9; j++)
                {
                    terreno[i, j] = ".";
                    terreno[j, j] = ".";
                    System.Array.Resize(ref result, j + 1);
                    result[j] = terreno;
                    if (terreno[i, j] == terreno[linhaUltima, colunaUltima])
                    {
                        boolean = true;
                        break;
                    }                   
                }               

                if (boolean)
                    break;

            }
            return result;
        }
    }
}
