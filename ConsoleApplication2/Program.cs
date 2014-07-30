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

           /* Pessoa p = new Pessoa { Nome = Guid.NewGuid().ToString() };
            db.Pessoa.Add(p);
            db.SaveChanges();

            var pessoas = db.Pessoa;

            foreach (var pessoa in pessoas)
                Console.WriteLine(pessoa.Nome);*/

            DateTime inicio = DateTime.Now;
            
           /* for (int i = 0; i < 500; i++)
            {
                Person p = new Person
                {
                    FirstName = "Nome" + i.ToString(),
                    LastName = "Last",
                    Address1 = "Address1",
                    Address2 = "Address2"
                };

                db.Person.Add(p);
            }

            db.SaveChanges();*/

            var pessoas = db.Person.ToList();

            DateTime fim = DateTime.Now;

            TimeSpan r = fim - inicio;

            System.Console.Write(pessoas.Count.ToString() + " - " + r.TotalMilliseconds);

            Console.Read();
                        
        }
    }
}
