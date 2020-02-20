using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BrasilCenter.Business.Models
{
    public class Livro : BaseEntity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        //[StringLength(13, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public int Isbn { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Autor { get; set; }

        [DisplayName("Preço")]
        public decimal? Preco { get; set; }

        [DisplayName("Data da Publicação")]
        public DateTime? DtPublicacao { get; set; }

        public string Capa { get; set; }

        //[Required(ErrorMessage = "O campo {0} é obrigatório")]
        //public string Capa { get; set; }

        public string PrecoFormatted
        {
            get
            {
                return Preco.HasValue ? Preco.Value.ToString("C2") : "--";
            }
        }

        public string DtPublicacaoFormatted
        {
            get
            {
                return DtPublicacao.HasValue ? DtPublicacao.Value.ToString("dd/MM/yyyy") : "--";
            }
        }
    }
}
