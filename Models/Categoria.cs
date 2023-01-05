using CursoUdemy.Models.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoUdemy.Models;

[Table("Categoria")]
public class Categoria : IEntity
{
    [Key] public long Id { get; set; }    
    [Required] [MaxLength(60)] public string? Nome { get; set; }
    [MaxLength(255)] public string? Descricao { get; set; }
    public DateTime DataHoraCriacao { get; set; }

    public IList<Lanche> Lanches { get; set; }

    public Categoria()
    {
        DataHoraCriacao = DateTime.Now;
        Lanches = new List<Lanche>();
    }
}
