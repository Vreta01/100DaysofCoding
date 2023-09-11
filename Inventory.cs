using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project.Classes
{
    internal class Inventory
    {
        //properties
        public BindingList<Product> Products
        {  get; set; }
        public BindingList<Part> AllParts
        { get; set; }


        //Create static objects to fill with data
        public static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Part> parts = new BindingList<Part>();

        //static constructor that prefills lists with data
        static Inventory()
        {
            products.Add(
                    new Product { ProductID = products.Count, Name = "Red Bicycle", InStock = 15, Price = 11.44M, Min = 1, Max = 25 }
                );
            products.Add(
                new Product { ProductID = products.Count, Name = "Yellow Bicycle", InStock = 19, Price = 9.66M, Min = 1, Max = 20 }
                );
            products.Add(
                new Product { ProductID = products.Count, Name = "Blue Bicycle", InStock = 5, Price = 12.77M, Min = 1, Max = 25 }
                );
            parts.Add(
                new Inhouse { PartID = parts.Count, Name = "Wheel", InStock = 15, Price = 12.11M, Min = 5, Max = 25 }
                );
            parts.Add(
                new Outsourced { PartID = parts.Count, Name = "Pedal", InStock = 15, Price = 12.11M, Min = 5, Max = 25 }
                );
            parts.Add(
                new Inhouse { PartID = parts.Count, Name = "Chain", InStock = 11, Price = 8.22M, Min = 5, Max = 25 }
                );
            parts.Add(
                new Outsourced { PartID = parts.Count, Name = "Seat", InStock = 8, Price = 4.55M, Min = 2, Max = 15 }
                );
        }

        //methods
        public void addProduct(Product product)
        { Products.Add(product); }
        public bool removeProduct(int id)
        {
            return true;
        }
        public Product lookupProduct(int id)
        {
            return new Product();
        }
        public void updateProduct(int id, Product product)
        {

        }
        public void addPart(Part part)
        {

        }
        public bool deletePart(Part part)
        {
            return true;
        }
        /*
        public Part lookupPart(int id)
        {
            
        }
        */
        public void updatePart(int id, Part part)
        {

        }


    }
}
