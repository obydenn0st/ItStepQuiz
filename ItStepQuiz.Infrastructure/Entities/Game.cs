using System.ComponentModel.DataAnnotations;

namespace ItStepQuiz.Infrastructure.Entities;

public class Game
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty!;
    public string Description { get; set; } = string.Empty!;
}
