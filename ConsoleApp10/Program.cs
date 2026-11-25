namespace ConsoleApp10
{
    class Student
    {
        public Student()
        {
            
        }
        public Student(string? name, int age)
        {
            Id=new Random().Next(100,1000);
            Name = name;
            Age = age;
        }

        public Student(int id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }


        public override string ToString() //obyekte muraciet edende ne qaytarsin onun ucun yazilir
        {
            return $@"Id: {Id}
                      Name: {Name}
                      Age: {Age}";
        }

        public override bool Equals(object? obj)  //default veziyyetde value typelari muqayise edir
        {
            if(obj is Student student)
            {
                return  this.Age== student.Age && this.Name== student.Name;
            }
            return false;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student(109,"Aydan",25);
            //Student student2 = new Student("Leyla",34);
            //Student student3 = new Student     //default constructor isledir
            //{
            //    Id=306,
            //    Name= "Eldar",
            //    Age=23
            //};

            //Console.WriteLine(student);
            //Console.WriteLine(student2);
            //Console.WriteLine(student3.ToString());


            ///////////////////////////////////////////////////////////////
            Point p1 = new Point
            {
                X = 13,
                Y = 9
            };

            Point p2 = new Point
            {
                X = 10,
                Y = 0
            };

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            //Console.WriteLine(p1>p2);
            //Console.WriteLine(p1<p2);
            //Console.WriteLine(p1==p2);

            //if (p1)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            //p1++;
            //Console.WriteLine(p1);

            //var point = new Point();
            //point = p1 + p2;
            //Console.WriteLine(point);

            var point = new Point();
            point = p1 / p2;
            Console.WriteLine(point);

        }
    }
}
