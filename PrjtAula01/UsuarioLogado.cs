﻿using PrjtAula01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace PrjtAula01
{
    public static class UsuarioLogado
    {
        
        public static int Id { get; set; }
        public static string? NomeCorrentista { get; set; }
        public static DateTime? DataNascimento { get; set; }
        public static string? Logradouro { get; set; }
        public static string? Numero { get; set; }
        public static string? Complemento { get; set; }
        public static string? Cidade { get; set; }
        public static string? Estado { get; set; }
        public static string? Cpf { get; set; }
        public static string? Celular { get; set; }
        public static string? Senha { get; set; }
        public static string? Rg { get; set; }
        public static string? Email { get; set; }
        public static string? Cep { get; set; }
        public static string? Genero { get; set; }
        public static decimal? RendaMensal { get; set; }
        public static int ContaLogada { get; set; }


        public static List<Conta> Contas = new List<Conta>();



        public static void Deslogar()
        {
            UsuarioLogado.Id = 0;
            UsuarioLogado.NomeCorrentista = String.Empty;
            UsuarioLogado.DataNascimento = null;
            UsuarioLogado.Logradouro = String.Empty;
            UsuarioLogado.Numero = String.Empty;
            UsuarioLogado.Complemento = null;
            UsuarioLogado.Cidade = String.Empty;
            UsuarioLogado.Estado = String.Empty;
            UsuarioLogado.Cpf = String.Empty;
            UsuarioLogado.Celular = String.Empty;
            UsuarioLogado.Senha = String.Empty;
            UsuarioLogado.Rg = String.Empty;
            UsuarioLogado.Email = String.Empty;
            UsuarioLogado.Cep = String.Empty;
            UsuarioLogado.Genero = String.Empty;
            UsuarioLogado.RendaMensal = 0;
            UsuarioLogado.Contas.Clear();
        }
    }
}
