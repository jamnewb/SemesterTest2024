using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a. Create a Sales object.
            Sales TestSales = new Sales();

            // b. Add batch orders to the Sales object
            Batch TestBatch1 = new Batch("#2024x00001", "CompSci Books");
            Batch TestBatch2 = new Batch("#2024x00001", "CompSci Books");

            TestSales.AddOrder(TestBatch1);
            TestSales.AddOrder(TestBatch2);

            Transaction TestTrans1 = new Transaction("#1", "Deep Learning in Python", 67.90m);
            Transaction TestTrans2 = new Transaction("#2", "C# in Action", 54.10m);
            Transaction TestTrans3 = new Transaction("#3", "Design Patterns", 129.75m);

            TestBatch1.Add(TestTrans1);
            TestBatch1.Add(TestTrans2);
            TestBatch1.Add(TestTrans3);

            Transaction TestTrans4 = new Transaction("#4", "Data Visualisation", 79.50m);
            Transaction TestTrans5 = new Transaction("#5", "Object Oriented Programming", 35.60m);
            Transaction TestTrans6 = new Transaction("#6", "Cloud Computing Architecture", 229.80m);

            TestBatch2.Add(TestTrans4);
            TestBatch2.Add(TestTrans5);
            TestBatch2.Add(TestTrans6);

            // c. Add single transaction orders to the Sales object.
            Transaction TestTrans7 = new Transaction("#00-0001", "Compilers", 134.60m);
            Transaction TestTrans8 = new Transaction("#10-0003", "Hunger Games 1-3", 45.00m);
            Transaction TestTrans9 = new Transaction("#15-0020", "Learning Blender", 56.90m);

            TestSales.AddOrder(TestTrans7);
            TestSales.AddOrder(TestTrans8);
            TestSales.AddOrder(TestTrans9);

            // d. Must create one nested batch order.
            Batch TestBatch3 = new Batch("#2024x00020", "Fiction Books");
            Batch TestBatch4 = new Batch("#2024x00019", "Comic Books");

            Transaction TestTrans10 = new Transaction("#80", "Cool Guys in History", 134.60m);
            Transaction TestTrans11 = new Transaction("#81", "What Happened Next", 45.00m);

            TestBatch3.Add(TestTrans10);
            TestBatch3.Add(TestTrans11);

            Transaction TestTrans12 = new Transaction("#82", "Generic Superhero Comic", 134.60m);
            Transaction TestTrans13 = new Transaction("#83", "The Most Funny Comic Ever", 45.00m);

            TestBatch4.Add(TestTrans12);
            TestBatch4.Add(TestTrans13);

            TestBatch3.Add(TestBatch4);

            TestSales.AddOrder(TestBatch3);

            // e. Add an empty batch order.
            Batch TestBatch5 = new Batch("#2024x00002", "Fantasy Books");
            TestSales.AddOrder(TestBatch5);

            // f. Tell PrintOrders to the Sales object.
            TestSales.PrintOrders();
            Console.ReadLine();
        }
    }
}
