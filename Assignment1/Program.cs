//18-10-2023

//using Assignment_18_10_23;

/*Student student1 = new (80,80,80,"XX");
Console.WriteLine(student1.studentname);
student1.CalculateAverage();*/

/*Product[] product = new Product[3];
product[0] = new Product("FRIDGE", 25000, 1);
product[1] = new Product("PEN", 5, 20);
product[2] = new Product("Glass", 50, 5);
Console.WriteLine("PRODUCT DETAILS");
Console.WriteLine("\n");
foreach (var item in product)
{
    Console.WriteLine("Product_Name:" +item.Productname);
    Console.WriteLine("Product_Price:" + item.Price);
    Console.WriteLine("Product_Quantity:" + item.Quantity);
    Console.WriteLine("\n");
    Console.WriteLine("Total_Price:" + item.ProductValue());
    Console.WriteLine("\n");

}*/

/*
Students[] students = new Students[]
{

 new("ARYA", new double[] {80,80,80}, 'A'),
 new("ASWATHY", new double[] {90,90,90}, 'B'),
 new("AYISHA", new double[] {70,70,70}, 'C'),



};
foreach (Students item in students)
{
    Console.WriteLine($"Student Name is :{item.Name}");
    Console.WriteLine($"Student Grade is: {item.Grade}");
    double[] marks = new double[3];
    double total = 0;
    Console.WriteLine("Marks of student is:\t");
    for (int i = 0; i < marks.Length; i++)
    {
        marks[i] = student.Marks[i];
        total = total + marks[i];
        Console.WriteLine(marks[i]);
    }
    Console.WriteLine($"Total Marks is:{total}");
    Console.WriteLine($"Average Marks is: {item.CalculateAverage()}");
    Console.WriteLine(item.GetMarksSummary());
}
*/

using Assignment1;

/*ElectronicProduct EP = new ElectronicProduct("PEN",10,5,2);
Console.WriteLine("***Electronics ProductDetails***\n");
EP.DisplayWarrantyPeriod();
Console.WriteLine($"Product Name:{EP.Productname}\nPrice:{EP.Price}\nQuantity:{EP.Quantity}");
Console.WriteLine($"Product Value:{EP.ProductValue()}");

Console.WriteLine("\n\n");
Console.WriteLine("***Digital ProductDetails***\n");

DigitalElectronics DP = new DigitalElectronics("Fridge", 50000, 1, 5,"Full-option");
Console.WriteLine($"Product Name:{DP.Productname}\nPrice:{DP.Price}\nQuantity:{DP.Quantity}");
Console.WriteLine(DP.ProductValue());
DP.DisplayWarrantyPeriod();
DP.DisplayFileformat();


Console.WriteLine("\n\n");



Console.WriteLine("***Clothing ProductDetails***\n");
ClothingProduct clothingProduct = new ClothingProduct("Tshirt", "XXL", 700, 3);
Console.WriteLine($"Product Name:{clothingProduct.Productname}\nPrice:{clothingProduct.Price}\nQuantity:{clothingProduct.Quantity}");
clothingProduct.DisplayClothingProductSize();
Console.WriteLine($"Total Value Of Product:{clothingProduct.ProductValue()}");*/


//Console.WriteLine("Enter the Employee_ID:");
//int eid=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the First name:");
//string? firstname=Console.ReadLine();
//Console.WriteLine("Enter the Last name:");
//string? lastname = Console.ReadLine();
//Console.WriteLine("Enter the age:");
//int age=Convert.ToInt32(Console.ReadLine());

//Employee emp = new Employee(age,firstname,lastname,eid);
//emp.DispayInfo(age);

/*Rectangle rectangle = new Rectangle(10, 10);
rectangle.Draw();
rectangle.CalculateArea();
rectangle.CalculatePerimeter();

Circle circle = new Circle(10);
circle.Draw();
circle.CalculateArea();
circle.CalculatePerimeter();*/


/*InsurancePolicy IP = new InsurancePolicy(2, "Medical_Insurance", 23000);
IP.RenewPolicy(50000);
IP.RenewPolicy();*/





Console.WriteLine("enter the policy ID:");
int PolicyId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Policy Name:");
string? PolicyName = Console.ReadLine();
Console.WriteLine(" Enter the premmium amount:");
double PremiumAmount = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("enter the age:");
int age = Convert.ToInt32(Console.ReadLine());
LifeInsurance life = new LifeInsurance(PolicyId,PolicyName,PremiumAmount,age);
Console.WriteLine(life.CalculatePremium());
Console.WriteLine("enter the policy ID:");
int Policy1Id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Policy Name:");
string? PolicyName1 = Console.ReadLine();
Console.WriteLine(" Enter the premmium amount:");
double PremiumAmount1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("enter the Car Type:");
string? cartype = Console.ReadLine();
CarInsurance car = new CarInsurance(PolicyId, PolicyName1, PremiumAmount1, cartype);
Console.WriteLine(car.CalculatePremium());


