// See https://aka.ms/new-console-template for more information

//Person p1 =new Person("name",55,100);
//p1.age = 55;
//p1.setSalary(500);
//Console.WriteLine("the salary : "+p1.getSalary());
//Console.WriteLine("the net Salary : "+p1.getSalary(0.2));


class Triangle : Shape, InterFaceShape
{
    public string name = "Triangle";

    public double getArea()
    {
        return Width* Hieght *.5;
    }
}