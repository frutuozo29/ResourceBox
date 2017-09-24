using ResourceBox.Domain.Entities;
using ResourceBox.Infra.Data.Context;
using ResourceBox.Infra.Data.Repositories;
using System;
using System.Data.Entity;

namespace TesteEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            ResourceBoxContext resourceBoxContext = new ResourceBoxContext();
            DbSet<Entrada> DbSet = resourceBoxContext.Set<Entrada>();

            /*
            var entrada = new Entrada();
            entrada.Data = DateTime.Now;
            entrada.ResponsavelId = 1;
            var entradarepository = new EntradaRepository();
            entradarepository.Add(entrada);
            */


            
            var entradarepository = new EntradaRepository();
            var entrada = entradarepository.GetById(2);
            entrada.Data = DateTime.Now;
            foreach (var item in entrada.RecursosEntrada)
            {
                item.Qtde = item.Qtde * 2;
            }
            //entrada.RecursosEntrada.Add(new RecursoEntrada { RecursoId = 1, Qtde = 10 });
            //entrada.RecursosEntrada.Add(new RecursoEntrada { RecursoId = 1, Qtde = 20 });
            entradarepository.Update(entrada);
            Console.WriteLine(entrada.Data);
        }
    }
}
