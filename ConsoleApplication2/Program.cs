using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Conexao();

            Pessoa p = new Pessoa { Nome = Guid.NewGuid().ToString() };
            db.Pessoa.Add(p);
            db.SaveChanges();

            var pessoas = db.Pessoa;

            foreach (var pessoa in pessoas)
                Console.WriteLine(pessoa.Nome);

            Console.Read();
                        
        }
    }
}
