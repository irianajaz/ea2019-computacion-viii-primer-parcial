using System;
using DAO.Models;

namespace DAO
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MySqlContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
