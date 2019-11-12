using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class Client
    {
        public cliente create(cliente newCliente)
        {
            cliente Result = null;
            using (var r = new Repository<cliente>())
            {
                cliente bc = r.Retrieve(c => c.Nombre == newCliente.Nombre);
                if (bc == null)
                {
                    Result = r.Create(newCliente);
                }
                else
                {
                    throw (
                        new Exception(
                            "El  cliente ya existe"));
                }
            }
            return Result;
        }
        public rin Create2(rin newRin)
        {
            rin Result = null;
            using (var n = new Repository<rin>())
            {
                rin br = n.Retrieve(i => i.ID == newRin.ID);
                if (br == null)
                {
                    Result = n.Create(newRin);
                }
                else
                {
                    throw (
                        new Exception(
                            "El rin ya existe"));
                }
            }
            return Result;

        }
        public cliente RetrieveByID(int ID)
        {
            cliente Result = null;
            using (var r = new Repository<cliente>())
            {
                Result = r.Retrieve(c => c.ID == ID);
            }
            return Result;
        }

        public bool Update(cliente ClienteToUpdate)
        {
            bool Result = false;
            using (var r = new Repository<cliente>())
            {
                cliente bc = r.Retrieve(c => c.Nombre == ClienteToUpdate.Nombre);
                if (bc == null)
                {
                    Result = r.Update(ClienteToUpdate);
                }
                else
                {
                    throw (
                        new Exception(
                            "El  cliente ya existe"));

                }

                return Result;
            }
        }
          

     }

    }

}
