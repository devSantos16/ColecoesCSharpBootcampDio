using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecoesCSharpBootcampDio.Models
{
    public class LeituraArquivo
    {
        public LeituraArquivo()
        {
        }

        public static (bool sucesso, string[] linhas, int quantidadeLinhas) LerArquivo(string arquivo)
        {
            try
            {
                string[] linhas = File.ReadAllLines(arquivo);
                return (true, linhas, linhas.Count());
            }
            catch (FileNotFoundException)
            {
                return (false, new String[0], 0);
            }
        }
    }
}