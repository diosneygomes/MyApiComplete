﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevIOApi.ViewModel
{
    public class ProviderViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Document { get; set; }

        public bool Actve { get; set; }

        public int TypeProvider { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
        public AddressViewModel Address { get; set; }
    }
}
