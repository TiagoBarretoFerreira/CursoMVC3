﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cursoMVC3.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage = "Valor fora do intervalo")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria categoria { get; set; }
    }
}