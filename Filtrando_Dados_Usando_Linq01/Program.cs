using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace Filtrando_Dados_Usando_Linq01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoas> _pessoas = new List<Pessoas>();

            #region Adicionando dados
            //Adicionando dados na lista
            _pessoas.Add(new Pessoas { Nome = "Santos", Pendente = 3, Salario = 50000, Aumento = 0 });
            _pessoas.Add(new Pessoas { Nome = "Pedro", Pendente = 1, Salario = 20000, Aumento = 0 });
            _pessoas.Add(new Pessoas { Nome = "Alberto", Pendente = 5, Salario = 24000, Aumento = 0 });
            _pessoas.Add(new Pessoas { Nome = "Tiago", Pendente = 8, Salario = 10000, Aumento = 0 });
            _pessoas.Add(new Pessoas { Nome = "Mateus", Pendente = 7, Salario = 90000, Aumento = 0 });
            _pessoas.Add(new Pessoas { Nome = "Candido", Pendente = 9, Salario = 50000, Aumento = 0 });
            _pessoas.Add(new Pessoas { Nome = "Domingos", Pendente = 6, Salario = 50000, Aumento = 0 });
            #endregion

            //Filtrando dados
            var fitrar = _pessoas.Where(p => p.Pendente >= 5 && p.Salario <= 60000);
            foreach(var item in fitrar)
            {
               //Fazendo aumento
                item.Aumento = item.Salario * 5 /3;
                WriteLine($"Nome: {item.Nome}    Novo salario: {item.Aumento}");
            }
            ReadKey(false);
        }
    }
}
