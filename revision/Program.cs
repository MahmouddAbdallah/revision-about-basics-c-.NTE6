// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//string fristName=string.Empty;

//Console.Write("Enter Name : ");

//fristName = Console.ReadLine();

//Console.WriteLine(fristName);
//int age =0;
//Console.Write("Enter Age : ");

//age = int.Parse(Console.ReadLine());
//Console.WriteLine(age);

//int Id = 0;
//Console.Write("Enter Id : ");

//Id = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Id);

//Console.WriteLine($"name : {fristName}" +
//    $"Age : {age}" + 
//    $"Id : {Id}");
//Console.WriteLine("Name : {0} ",fristName);

//int num = 15;
//int num2 = 2;
//Console.WriteLine(num% num2);
//Console.WriteLine(num / num2);


//condition 

//string working;
//Console.Write("Enter (true , false) : ");
//working = Console.ReadLine();
//if (working == "true")
//{
//    Console.WriteLine("yes");

//}else if (working == "T")
//{
//    Console.WriteLine("yes");
//}else if (working == "t")
//{
//    Console.WriteLine("yes");
//}else if (working!=null)
//    { Console.WriteLine("this not {0}", working); }
//else
//{
//    Console.WriteLine("no");
//}
////switch 
//switch (working)
//{
//    case "true":
//    case "T":
//    case "t":
//        Console.WriteLine("yes");    
//        break;
//    case "false":
//    case "F":
//    case "f": 
//          Console.WriteLine("no");
//        break;
//    case string w when (w != null):
//        Console.WriteLine("this not {0}",w);
//        break;
//   default: Console.WriteLine("No value");
//        break;

//}

//string work = working == "true" ? "valid" : "value : "+working;
//Console.WriteLine(work);

//repetition
//int sum=0;
//for (int i = 0; i < 10; i++)
//{
//    sum = sum + i;
//}
//Console.WriteLine(sum);

//sum = 0;
//int ine=0;
//while (ine < 10)
//{
//    sum += ine;
//    ine++;
//}
//Console.WriteLine(sum);

//sum=0;
//ine=0;
//do
//{
//    sum += ine;
//    ine++;
//} while (ine < 10);
//Console.WriteLine(sum);

//Motheds

//void HelloWorld()
//{
//    Console.WriteLine("HelloWorld");
//}
//HelloWorld();


//string Print(string value){
//    return value;
//}
//Console.WriteLine(Print("hello"));

//void Print(string message)
//{
//    Console.WriteLine(message);
//}
//Print("hello");

//function take three numbers and give the greatest

//int Comparing(int num1, int num2, int num3)
//{
//    int num;
//    if (num1 > num2 && num1 > num3)
//    {
//        num = num1;
//    }
//    else if (num2 > num1 && num2 > num3)
//    {
//        num = num2;
//    }
//    else
//    {
//        num = num3;
//    }
//    return num;
//}

//Console.WriteLine("enter 1");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter 2");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter 3");
//int num3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("The greatest Number is : {0}", Comparing(num1, num2, num3));

//DateTime time = DateTime.Now;
//Console.WriteLine(time);
//string fristName = "Mahmoud";
//Console.WriteLine(fristName.Length);
//Console.WriteLine(fristName.IndexOf("M"));
//Console.WriteLine(fristName.Replace('h','H'));
//Console.WriteLine(fristName.Replace("Mahmoud","Mohamed"));
//string sName = fristName.Replace("Mahmoud", "Mohamed");
//Console.WriteLine(sName.ToUpper().ToLower());

//int number = 1234567;
//string str = number.ToString();
//Console.WriteLine(str);


// Array
//int [] arr1=new int[] {1,2,3,4,5} ;
//for (int i = 0; i < arr1.Length; i++)
//{
//    Console.WriteLine(arr1[i]);
//}
//int [] arr2=new int[5] ;
//for (int i = 0; i < arr2.Length; i++)
//{
//    arr2 [i] = i ;
//    Console.WriteLine(arr2[i]);
//}

//lists

//List<string> Name = new List<string>();

//Name.Add("MAhmoud");
//Name.Add( "Mohamed");
//Name.Add( "Abdallah");
//Name.Add("mahmoud");


//foreach (string s in Name)
//{
//    Console.WriteLine(s);
//}

List <string>Names=new List<string>();

string name = "";

while (name!="-1")
{
    Console.WriteLine("Enter Name");
    name = Console.ReadLine();
    if (!(name=="") && name!="-1") { 
        Names.Add(name);
    }
}

Console.WriteLine("---------------For Loop--------");

for (int i = 0; i < Names.Count; i++)
{
    Console.WriteLine(Names[i]);
}
Console.WriteLine("----------------ForEach------------------");
foreach (string n in Names)
{
    Console.WriteLine(n);
}