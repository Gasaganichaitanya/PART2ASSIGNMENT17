using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17Part2
{
    public class Product
    {
        
            protected int pid;
            protected string pname;
            protected double pprice;

            public virtual void ShowDetails()
            {
                Console.WriteLine($"Product ID: {pid}");
                Console.WriteLine($"Product Name: {pname}");
                Console.WriteLine($"Product Price: {pprice:C}");
            }

            
            public virtual void SetInformation(int id, string name, double price)
            {
                pid = id;
                pname = name;
                pprice = price;
            }
        }
    }

