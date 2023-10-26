using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Calculadora
    {
        private List<string> historicoOperacoes = new List<string>();

        public Calculadora()
        {
        }

        private string RegistrarOperacao(string operacao)
        {
            string operacaoComData = $"{operacao} - {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
            historicoOperacoes.Add(operacaoComData);
            return operacaoComData;
        }
        public int Somar(int a, int b)
        {
            int resultado = a + b;
            string operacao = $"{a} + {b} = {resultado}";
            historicoOperacoes.Insert(0, "Res: " + resultado); 
            return resultado;
        }

        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            string operacao = $"{a} - {b} = {resultado}";
            historicoOperacoes.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            string operacao = $"{a} * {b} = {resultado}";
            historicoOperacoes.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Divisão por zero não é permitida.");

            int resultado = a / b;
            string operacao = $"{a} / {b} = {resultado}";
            historicoOperacoes.Insert(0, "Res: " + resultado);
            return resultado;
        }

            public List<string> ObterHistoricoOperacoes()
        {
            return historicoOperacoes;
        }
    }
}