namespace Gungi.Front.Models
{
    public class GastoDetalhadoDto
    {
        public int Id { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public decimal Valor { get; set; }
        public string FormaPagamento { get; set; }
        public bool StatusPagamento { get; set; }
        public string Observacao { get; set; }
    }
}