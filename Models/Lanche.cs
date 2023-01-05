using CursoUdemy.Models.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoUdemy.Models;

[Table("Lanche")]
public class Lanche : IEntity
{
    public long Id { get; set; }
    public long CategoriaId { get; set; }
    public Categoria? Categoria { get; private set; }
    [Required, MaxLength(60)] [Display(Name = "Nome do lanche")] public string? Nome { get; set; }
    [Required, MaxLength(255)] [Display(Name = "Descrição do lanche")] public string? Descricao { get; set; }
    [Display(Name = "Preço")] public decimal Preco { get; set; }
    public string? Foto { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataHoraCriacao { get; set; }

    public Lanche()
    {
        DataHoraCriacao = DateTime.Now;
    }
}
