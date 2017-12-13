using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2Lab2_MauroSergioSantos.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Nome { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public List<Consulta> Consultas { get; set; }
        public List<Especie> Especies { get; set; }
        public int EspecieId { get; set; }
    }
}