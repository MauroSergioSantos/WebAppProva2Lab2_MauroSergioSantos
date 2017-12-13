using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebAppProva2Lab2_MauroSergioSantos.Models
{
    public class Especie
    {
        public int EspecieId { get; set; }
        public string Descricao { get; set; }
        public List<Animal> Animais { get; set; }
    }
}