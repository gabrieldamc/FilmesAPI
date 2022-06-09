using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dto
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "É Obrigatório ter titulo")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "É obrigatório Diretor")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração máxima é de 1 a 600 min")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
