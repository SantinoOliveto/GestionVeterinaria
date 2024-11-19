using GestionVeterinariaServices.Models;
using GestionVeterinariaServices.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GestionVeterinariaTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            PruebaDAOClientes();
        }

        static void PruebaDAOEspecies()
        {
            EspeciesDAO DAO = new EspeciesDAO();

            Especie especie1 = new Especie("perro", 10, 110);
            Especie especie2 = new Especie("foca", 20, 70);

            DAO.GetConexion();
            DAO.InsertEspecie(especie1);
            DAO.InsertEspecie(especie2);
            DAO.GetAllEspecies();

        }
        static void PruebaDAOAnimales()
        {
            AnimalesDAO DAO = new AnimalesDAO();

            Animal animal1 = new Animal(44641045, 1,"Jose", 11, 8);
            //Animal animal2 = new Animal(4, 2, "Pepe", 5, 18);

            DAO.GetConexion();
            DAO.InsertAnimal(animal1);
            DAO.InsertAnimal(animal1);
            DAO.GetAllAnimales();

        }

        static void PruebaDAOUsuarios()
        {
            UsuariosDAO DAO = new UsuariosDAO();

            Usuario usuario1 = new Usuario("Jose", "asdasd23");

            DAO.GetConexion();
            //DAO.InsertUsuario(usuario1);
            DAO.GetAllUsuarios();
            DAO.GetLoginUsuario("Jose", "asdasd23");
        }

        static void PruebaDAOClientes()
        {
            ClientesDAO DAO = new ClientesDAO();

            Cliente cliente1 = new Cliente(12345, "Roberto Carlos");
            DAO.GetConexion();
            DAO.InsertCliente(cliente1);
            DAO.GetAllClientes();
        }
    }
}
