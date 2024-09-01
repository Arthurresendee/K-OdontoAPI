﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DRAKaysaResende.Models
{
    public class Dentista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string? CPF { get; set; }
        public string? Bairro { get; set; }
        public DateTime? DataDeAniversario { get; set; }
        public int? Idade { get; set; }
        public string? Email { get; set; }
        public string? NumeroDeTelefone { get; set; }
        public string? Especializacao { get; set; }
        public string? NumeroDeRegistro { get; set; }
        public int IdEndereco { get; set; }
        public Endereco Endereco { get; set; }
    }
}
