using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2Lab2_MauroSergioSantos.Models
{
    public class Consulta
    {
        public int ConsultaId { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Observacao { get; set; }
        public List<Animal> Animais { get; set; }
    }
}