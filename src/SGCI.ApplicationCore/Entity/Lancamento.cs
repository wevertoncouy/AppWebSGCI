using System;
using System.Collections.Generic;
using System.Text;

namespace SGCI.Infrastructure.Data
{
  public  class Lancamento
    {
        public Lancamento()
        {

        }

        public int LancamentoId { get; set; }
        public DateTime Data { get; set; }
        public int CategoriaId { get; set; }//fk
        public int ContaId { get; set; }

        public decimal Valor { get; set; }
        public Decimal Resultado { get; set; }
        public string Descricao { get; set; }

        // public Categoria Categoria { get; set; }

       // public Conta Conta { get; set; }
    }
}
