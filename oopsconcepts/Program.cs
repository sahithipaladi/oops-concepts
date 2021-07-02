using System;

namespace oopsconcepts
{

    class program
    {
      static void Main(string[] args)
        {
            Student s = new Student();
            s.Display("Raghu", 13);
            Console.WriteLine();
            User u = new User();

            // set accessor will invoke
            u.Name = "Suresh Dasari";
            // set accessor will invoke
            u.Location = "Hyderabad";
            // get accessor will invoke
            Console.WriteLine("Name: " + u.Name);
            // get accessor will invoke
            Console.WriteLine("Location: " + u.Location);
            Console.ReadLine();

            Laptop l = new Laptop();
            l.Brand = "Dell";
            l.Model = "Inspiron 14R";
            l.LaptopDetails();
            Console.ReadLine();

            Calculate c = new Calculate();
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);
            Console.ReadLine();

            DClass d = new DClass();
            d.GetInfo();
            BClass b = new BClass();
            b.GetInfo();
            Console.ReadLine();

        }

    }
}



        
    


    

    
