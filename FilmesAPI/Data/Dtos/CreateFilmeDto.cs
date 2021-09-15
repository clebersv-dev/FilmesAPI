using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "Campo titulo e obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo diretor e obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Genero nao pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter entre 1 e 600")]
        public int Duracao { get; set; }
    }
}
