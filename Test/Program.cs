using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void RegistrarCliente()
        {
            cliente c = new cliente()
            {
                Nombre = "Carlos",
                ApellidoPaterno = "Salgado",
                ApellidoMaterno = "Almonte",
                Telefono = "7441445678",
                Email="infiel3000@hotmail.com",

            };
            rin r = new rin()
            {
                Diagnostico="Abollado",
                TamañoRin =15,
                TamañoLlanta= 15,
                Subtotal=500,
                IVA=null,
                Total=500,
                FenchEnt=DateTime.Now,
                FechSal=null,
                ClienteID=4,
                

            };

            r.cliente.Add(cliente);
            using (var r = new Repository<cliente>())
            {
                r.Create(r);
            }
        }
    }
}
