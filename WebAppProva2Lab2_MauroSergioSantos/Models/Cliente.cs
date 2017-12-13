using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebAppProva2Lab2_MauroSergioSantos.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Animal> Animais { get; set; }
        public Endereco Endereco { get; set; }
        
    }
}