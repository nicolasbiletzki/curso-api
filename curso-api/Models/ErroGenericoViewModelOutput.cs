using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_api.Models
{
    public class ErroGenericoViewModelOutput
    {
        public IEnumerable<string> Erros { get; private set; }

        public ErroGenericoViewModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        } 
    }
}
