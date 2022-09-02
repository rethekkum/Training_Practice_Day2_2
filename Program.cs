using System;


public class Emp_Video21
{
    public string FirstName;
    public string LastName;
    public string Title;



}

public class FT_Video21 : Emp_Video21
{
    public float monthly_salary;
    public void PrintFullName()
    {
        Console.WriteLine("{1},{0},{2}", this.FirstName, this.LastName,Title); ; ;
    }
}

public class PT_Video21: Emp_Video21 {
    float hourly_salary;
}

public class Video21_parentclass
{
    protected Video21_parentclass()
    {
        Console.WriteLine("Parent initialized without directly instantiating the parent class");
    }
    protected Video21_parentclass(string message)
    {
        Console.WriteLine(message);
    }
}

public class Video21_childclass : Video21_parentclass {
    public Video21_childclass()
    {
        Console.WriteLine("Child class initialised");
    }

    public Video21_childclass(string message) : base("parent class constructor with parameter called")
    {
        Console.WriteLine(message);
    }
}


public class Emp_Video22
{
    public string FirstName;
    public string LastName;
    public void PrintFullName()
    {
        Console.WriteLine("{1},,,,,{0}", this.FirstName, this.LastName); ; ;
    }

}

public class Video22_FT:Emp_Video22
{

}

public class Video22_PT : Emp_Video22
{
    // we can continue without new but its preferred to use new when you want to hide base called field/member
    public new void PrintFullName()
    {
        //even after hiding we need to call the base class function we can do this
        //base.PrintFullName();

        //////////////////
        Console.WriteLine("{1},{0} is a parttime employee", this.FirstName, this.LastName); ; ;
    }
}


public class Video23
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName+LastName);
    }
}

public class Video23_1 : Video23
{
    override public void PrintFullName()
    {
        Console.WriteLine(FirstName + LastName+"  1");
    }
}
public class Video23_2 : Video23
{
     public new void PrintFullName()
    {
        //this is method hiding since this method wont print instead previous one print and if we use override word than method overriding will occur.
        Console.WriteLine(FirstName + LastName+"  2");
    }
}
public class Video23_3 : Video23
{
    override public  void PrintFullName()
    {
        Console.WriteLine(FirstName + LastName+"  3");
    }
}


class program
{
    public static void Video25()
    {
        //overloading mein inputs and outputs different hote hain.

    }

    public static void Video25(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public static void Video25(float a, float b)
    {
        Console.WriteLine("{0}0", a + b);
    }
    // we cannot overload just based on return type
    public static float Video25(int a, float b)
    {
        Console.WriteLine("{0}1",a + b);
        return a+b;
    }
    public static void Video25(int a, float b, out int sum)
    {
        sum = a + (int)b;
        Console.WriteLine("{0},2", a + b);     
    }



    public class Video26
    {
        private int _id;
        private string _name;
        private static int _score=35;

        public void Setname(string name)
        {
            if(name.Length!=0)
            this._name = name;

            new Exception("Null name");
        }
        public string Getname()
        {
            return _name;
        }

        public int Getscore()
        {
            return _score;
        }
        public void SetId(int id)
        {
            if(id <= 0)
            {
                throw new Exception("Student ID cannot be negative");
            }
                this._id = id;

            
        }

        public int Getid()
        {
            return _id;
        }
    }
    public class Video27
    {
        private int id;
        private string name;
        private int score=50;
        
        public int Age { get; set; }


        public int sc
        {
            get
            {
                return score;
            }
        }
        public int ID
        {
            set
            {
                this.id = value;
            }
            get { return id; }
        }
    }

    public struct Video28
    {
        private int _id=1;
        private int _score;

        public int ID
        {
            get { return _id; }
        }
        public int Score
        {
            get { return _score; } 
            set { this._score = value; }
        }

        public Video28(int score) {
            this._score = score;

        }

    }
    static void Main()
    {
        //Console.WriteLine("Part 2 Day 2");
        //Emp_Video21 v21 = new Emp_Video21();
        //v21.FirstName = "rethek";
        //v21.LastName = "SWE";
        //v21.Title = "CFO";


        //FT_Video21 v21_2 = new FT_Video21();
        //v21_2.FirstName = "rethek";
        //v21_2.LastName = "SWE";
        //v21_2.Title = "CTO";
        //v21_2.PrintFullName();
        //v21_2.monthly_salary = 5000.2F;


        //Video21_childclass v21_C = new Video21_childclass("Child class with parameter called");
        
        ////////////////////////////////////////////////////////////////////////////////////////////
        Video22_FT v22_FT = new Video22_FT(); ;
        v22_FT.FirstName = "reth";
        v22_FT.LastName = "ek";
        v22_FT.PrintFullName();
        
        
        Video22_PT v22_PT = new Video22_PT(); ;
        v22_PT.FirstName = "reth";
        v22_PT.LastName = "ek";
        v22_PT.PrintFullName();

        //((Emp_Video22)v22_PT).PrintFullName();
        //we can call hidden method by type casting as done above.


        // or we can make a parent class object whose method is hidden and store reference of child class as done below
        Console.WriteLine("EOL");
        // we cant do it otherway around since child class is specialised and contains more functions than parent class
        Emp_Video22 em22 = new Video22_PT();
        em22.FirstName = "reth";
        em22.LastName = "ek";
        em22.PrintFullName();
        Console.WriteLine("EOL");

        //////////////////////////////////VIDEO23//////////////////////////////////////////////
        Video23[] em23 = new Video23[4];

        em23[0] = new Video23();
        em23[1] = new Video23_1();
        em23[2] = new Video23_2();
        em23[3] = new Video23_3();

        //agar virtual use karte hain and phir child class mein override karte hain tou bhale object type parent ka ho function child class ka use hoga
        //agar override use nahi karte tou function child class ka hai lekin jab object parent class ka hai tou parent class wala version chalega -refer to video23
        foreach(Video23 v in em23)
        {
            v.PrintFullName();
        }

        //int sum = 0;
        Video25(15,2.5F,out int sum);
        Console.WriteLine(sum);

        Console.WriteLine("/////////////////////////Video-26///////////////////////");
        Video26 v26 = new Video26();
        v26.SetId(50);
        Console.WriteLine("ID={0}",v26.Getid());
        v26.Setname("hello");
        Console.WriteLine("Name={0}",v26.Getname());
        Console.WriteLine("Score={0}",v26.Getscore());

        Console.WriteLine("////////////////////////Video-27///////////////////////");
        Video27 v27 = new Video27();
        v27.ID = 100;
        Console.WriteLine("Value of ID: {0}",v27.ID);

        Console.WriteLine(v27.sc);
        // get set properties

        ////////////////////////////Video28///////////////////////
        Video28 v28 = new Video28
        {
            Score = 25
        };
    }
}