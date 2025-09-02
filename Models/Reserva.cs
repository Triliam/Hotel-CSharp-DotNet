using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOTELDOTNET.Models
{
    public class Reserva
    {
        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("Quantidade de hospede excedente");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
          
                Suite = suite;
    
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                decimal valorComDesconto = valor * 0.10M;
                return valorComDesconto;
            }
            return valor;
        }
    }
    
}