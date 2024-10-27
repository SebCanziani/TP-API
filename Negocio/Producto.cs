using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Negocio
{
    public class Producto
    {




        public int Id { get; set; }

        public string  Title { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }





        public Producto(int id, string title, decimal price, string description, string category) {



            Id = id;
            Title = title;
            Price = price;
            Description = description;
            Category = category;



        }










    }

}
