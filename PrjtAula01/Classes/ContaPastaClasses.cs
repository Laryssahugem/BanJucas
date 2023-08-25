using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrjtAula01.Classes
{
    public class ContaPastaClasses
    {

        public int IdConta { get; set; }
        public int IdCliente { get; set; }
        public double Saldo { get; set; } = 0;
        public string? Status { get; set; }
        public double Limite { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataEncerramento { get; set; }
        public string? TipoConta { get; set; }
        public static int TotalContas { get; set; }
        public static double TotalSaldo { get; set; }
        public double Saque { get; set; }




        public ContaPastaClasses()
        {
            TotalContas = TotalContas + 1;
            TotalSaldo = TotalSaldo + Saldo;
            Saque = TotalSaldo - Saque;


        }

        public ContaPastaClasses(int idConta, int idCliente, double saldo, string status, double limite,
                      DateTime dataAbertura, DateTime? dataEncerramento, string? tipoConta)
        {
            IdConta = idConta;
            IdCliente = idCliente;
            Saldo = saldo;
            Status = status;
            Limite = limite;
            DataAbertura = dataAbertura;
            DataEncerramento = dataEncerramento;
            TipoConta = tipoConta;
            TotalContas = TotalContas + 1;
            TotalSaldo = TotalSaldo + Saldo;

        }

        //Criando método de depósito

        public double Depositar(double valorDeposito)
        {
            if (valorDeposito <= 0) 
            {

                throw new Exception("Coloque um valor real de depósito!");

            }

            this.Saldo = this.Saldo + valorDeposito;
            TotalSaldo += valorDeposito;
            return this.Saldo;

        }

        public static string RetornarSaldoTodasContas()
        {
            return $"O Saldo de todas as contas é de R$ {TotalSaldo}";
        }

        public double Sacar(double valorSaque)
        {
            if (valorSaque <= 0)
            {
                throw new Exception ("Coloque um valor real de saque!");
            }

            else if (valorSaque > Saldo)
            {
               throw new Exception ("Você não tem saldo suficiente para esse saque!");
            }

            else
            {
                Saldo -= valorSaque;
            }

            return Saldo;

        }


    }
}
