﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIOApi.ViewModel
{
    public class ProductViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Description { get; set; }

        [DisplayName("Imagem do Produto")]
        public string ImageUpload { get; set; }

        public string Image { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Price { get; set; }

        public bool Active { get; set; }

        public Guid ProviderId { get; set; }

        [ScaffoldColumn(false)]
        public string ProviderName { get; set; }


        [ScaffoldColumn(false)]
        public DateTime RegistraionDate { get; set; }
    }
}
