internal class Person
{
    public int id { get; set; }
    public string name;
    public int age;
    public string description;

    //private ==> feilds
    private double _salary{get;set;}

    public Person( string name, int age,double salary)
    {
        this.name = name;
        this.age = age;
        this._salary = salary;

    }

    bool isWork(bool work)
    {
        return work;
    }
    public void printEveryThing()
    {
        Console.WriteLine($"The Id : {id}\nThe Name : {name}\nThe Age : {age}\nThe Salary {_salary}");
    }
    public void setSalary(double salary)
    {
        this._salary = salary;
    }

    //overloading
    public int getSalary()
    {
        return (Convert.ToInt32(_salary));
    }
    public double getSalary(double r)
    {
        return  _salary*r;
    }
}

