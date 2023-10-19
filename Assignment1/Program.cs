//18-10-2023

using Assignment_18_10_23;
using Assignment1;

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