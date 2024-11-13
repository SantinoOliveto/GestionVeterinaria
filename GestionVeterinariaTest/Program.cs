using GestionVeterinariaServices.Models;
using GestionVeterinariaServices.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionVeterinariaTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            PruebaDAO2();
        }

        static void PruebaDAO()
        {
            EspeciesDAO DAO = new EspeciesDAO();

            Especie especie1 = new Especie("perro", 10, 110);
            Especie especie2 = new Especie("foca", 20, 70);

            DAO.GetConexion();
            DAO.InsertEspecie(especie1);
            DAO.InsertEspecie(especie2);
            DAO.GetAllEspecies();

        }
        static void PruebaDAO2()
        {
            AnimalesDAO DAO = new AnimalesDAO();

            Animal animal1 = new Animal(1, 1,"Jose", 11, 8);
            //Animal animal2 = new Animal(4, 2, "Pepe", 5, 18);

            DAO.GetConexion();
            DAO.InsertAnimal(animal1);
            DAO.InsertAnimal(animal1);
            DAO.GetAllAnimales();

        }
    }
}
