using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAula.Models
{
    public class CarroViewModel
    {
        public CarroViewModel()
        {

        }
        public CarroViewModel(string modelo, string cor, int? anoFabricacao, int? anoModelo, DateTime? dataCompra)
        {
            Modelo = modelo;
            Cor = cor;
            AnoFabricacao = anoFabricacao;
            AnoModelo = anoModelo;
            DataCompra = dataCompra;
        }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Modelo { get; set; }
        public string Cor { get; set; }
        
        [Range(2000,2021,ErrorMessage = "O valor deve estár entre 2000 a 2021")]
        public int? AnoFabricacao { get; set; }
        public int? AnoModelo { get; set; }
        public DateTime? DataCompra { get; set; }
    }
}
