using Simple.DatabaseWrapper.Attributes;
using System;

namespace H4RDPonto.LIB.ModelsDB
{
    public class ControleHoras
    {
        [PrimaryKey]
        public Guid GUID { get; set; }
        public DateTime Data { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime AlmocoSaida { get; set; }
        public DateTime AlmocoRetorno { get; set; }
        public DateTime Saida { get; set; }
        public int HorasTrabalhadas { get; set; }
        public int DiaUtil { get; set; }
    }
}
