using System;

namespace H4RDPonto.LIB.Interfaces
{
    public interface IPonto
    {
        Guid Set_Entrada(DateTime diaHoraAtual);
        Guid Set_SaidaAlmoco(DateTime diaHoraAtual);
        Guid Set_EntradaAlmoco(DateTime diaHoraAtual);
        Guid Set_Saida(DateTime diaHoraAtual);
        Guid Set_QuantidadeHorasTrabalhadas(int horasTrabalhadas);
        DateTime Get_HorariosDoDiaAtual(DateTime DiaAtual);
        DateTime Get_Entrada(Guid guidDiaHoraAtual);
        DateTime Get_SaidaAlmoco(Guid guidDiaHoraAtual);
        DateTime Get_EntradaAlmoco(Guid guidDiaHoraAtual);
        DateTime Get_Saida(Guid guidDiaHoraAtual);
    }
}
