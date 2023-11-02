using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618
namespace EncuestaValidacion.Models;
public class Survey
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [MinLength(2, ErrorMessage = "El nombre debe tener al menos 2 caracteres.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "La ubicación es obligatoria.")]
    public string Location { get; set; }

    [Required(ErrorMessage = "El lenguaje favorito es obligatorio.")]
    public string FavoriteLanguage { get; set; }

    [MinLength(20, ErrorMessage = "El comentario debe tener al menos 20 caracteres.")]
    public string Comment { get; set; }

    public Survey(){}
}
