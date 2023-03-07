// See https://aka.ms/new-console-template for more information

//Person p1 =new Person("name",55,100);
//p1.age = 55;
//p1.setSalary(500);
//Console.WriteLine("the salary : "+p1.getSalary());
//Console.WriteLine("the net Salary : "+p1.getSalary(0.2));


//Cube c = new();
//Console.Write("Enter the width of cube : ");
//c.Width = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter the Hieht of cube : ");
//c.Hieght = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"The Area : {c.getArea()}");

//Triangle triangle = new();
//Console.Write("Enter the width of" + triangle.name + " : ");
//triangle.Width = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter the Hieht of" +triangle.name+" : ");
//triangle.Hieght = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"{triangle.name} The Area : {triangle.getArea()}");

var cube = new Cube();
cube.Width = 5;
Console.WriteLine(cube.Width);
