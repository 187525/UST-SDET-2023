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

using Assignment1.Myexception;
using System.Threading.Channels;


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

//--------------------------------------------------------------------------------------
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
//------------------------------------------------------------------------------------
/*Rectangle rectangle = new Rectangle(10, 10);
rectangle.Draw();
rectangle.CalculateArea();
rectangle.CalculatePerimeter();

Circle circle = new Circle(10);
circle.Draw();
circle.CalculateArea();
circle.CalculatePerimeter();*/

//-------------------------------------------------------------------------------------
/*InsurancePolicy IP = new InsurancePolicy(2, "Medical_Insurance", 23000);
IP.RenewPolicy(50000);
IP.RenewPolicy();*/




/*-----------------------------------------------------------------------------
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
Console.WriteLine(car.CalculatePremium());*/
//------------------------------------------------------------------------------------------------
/*Customer customer = new Customer();
Console.Write("Enter the Phone number:");
long number = Convert.ToInt64(Console.ReadLine());
customer.SearchDetails(number);*/
//---------------------------------------------------------------------------------------------------
/*CallRecord record = new CallRecord();
Console.WriteLine("Enter the phone number");
long number = Convert.ToInt64(Console.ReadLine());
CallRecord.CallHistory(number);
CallRecord.CallCounts();*/

//---------------------------------------------------------------------------------------------------
/*Patient patient = new Patient();
Console.Write("Enter the patient Id:");
int id = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Name:");
string? name = Console.ReadLine();
Console.Write("Enter the Age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Diagnosis:");
string? diagnosis = Console.ReadLine();
try
{
    patient.AddPatient(id, name, age, diagnosis);

}
catch (MyExceptions ex)
{
    Console.WriteLine(ex.Message);
}
*/

/*MedicalRecord medicalRecord1= new MedicalRecord();
Console.WriteLine("Enter the RecordID:");
int Rid=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Patient ID:");
int Pid=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Patient Name:");
string? name=Console.ReadLine();
Console.WriteLine("Enter the age:");
int age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Diagonosis:");
string? Diagonosis=Console.ReadLine();
Console.WriteLine("Enter the TreatmentCost:");
double cost=Convert.ToDouble(Console.ReadLine());
try
{
    medicalRecord1.AddMedicalRecord(Rid, Pid, name,age, Diagonosis, cost);
    medicalRecord1.DisplayDetails();

}
catch (InvalidPatientDataException ex)
{
    Console.WriteLine(ex.Message);
}
catch(InvalidMedicalRecordException ex)
{
    Console.WriteLine(ex.Message);
}*/
//---------------------------------------------------------------------
/*Patient p=new Patient();
int option = 1;
do
{
    Console.WriteLine("enter the choice:");
    
    Console.WriteLine("1:Add Patient\n2:View Patient\n3:exit");
    switch(Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("Enter the Patient ID:");
            int Pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Patient Name:");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter the age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Diagonosis:");
            string? Diagonosis = Console.ReadLine();
            p.AddPatientTextfile(Pid,name,age,Diagonosis);
            break;
            case 2:
            p.ReadDeatils();
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
                Console.WriteLine("Invalid choice");
                break;
    }
    Console.WriteLine("Do you wish to continue?\n1.Yes\n2.No");
    option=Convert.ToInt32(Console.ReadLine());


} while (option != 2);*/
//----------------------------------------------------------------------------------

/*Console.WriteLine("Enter the room number");
int r_no = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Room Type:Single/Double");
string? r_type = Console.ReadLine();
RoomReservation<HotelRoom> room_res = new RoomReservation<HotelRoom>();
HotelRoom room = new HotelRoom(r_no, r_type, true);
room_res.BookRoom(room);
Console.WriteLine("Booking Details");

foreach (var item in RoomReservation<HotelRoom>.Room)
{
    Console.WriteLine("Room  Number:" + item.RoomNumber);
    Console.WriteLine("Room Type:" + item.RoomType);
    Console.WriteLine("Status:" + item.IsBooked);
}
Console.WriteLine("Enter the room number");
int roomnumber = Convert.ToInt32(Console.ReadLine());
var data = RoomReservation<HotelRoom>.Room.Find(X => X.RoomNumber == roomnumber);
if (data != null)
{
    room_res.CancelRoom(data);
    Console.WriteLine("Booking canceled successfully");
}
else
{
    Console.WriteLine("No record found");  
}*/
//0---------------------------------------------------------------

/*Inventory<string> inventory = new Inventory<string>();

do
{
    Console.WriteLine("Enter the choice\n1.Add Product\n2.Update Product\n3.Remove Product\n4.Search By Id\n5.Search By Name");
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("Enter the product Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter the price:");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the product quantity:");
            double quantity = Convert.ToDouble(Console.ReadLine());
            inventory.AddProduct(new GProduct<string>(id, name, price, quantity));
            break;
        case 2:
            Console.WriteLine("Enter the product id to update:");
            int p_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the product name");
            string? u_name = Console.ReadLine();
            Console.WriteLine("Enter the price:");
            double u_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity:");
            double u_quantity = Convert.ToDouble(Console.ReadLine());
            inventory.UpdateProduct(p_id, u_name, u_price, u_quantity);
            break;
        case 3:
            Console.WriteLine("Enter the product id");
            int d_id = Convert.ToInt32(Console.ReadLine());
            inventory.DeleteProduct(d_id);
            break;
        case 4:
            Console.WriteLine("Enter the Product id");
            int s_id = Convert.ToInt32(Console.ReadLine());
            GProduct<string> proList = inventory.SearchProductById(s_id);
            if (proList != null)
            {
                Console.WriteLine("Product Id:" + proList.ProductId);
                Console.WriteLine("Name:" + proList.Price);
                Console.WriteLine("Price:" + proList.QuantityInStock);

            }
            else
            {
                Console.WriteLine("List is empty");
            }
            break;
    
    }
}while (true);*/
/*
class Program
{
    public delegate double DelegateOne(Employees employee);
    public delegate double DelegateTwo(Employees employeeone);

    public static void Main(String[] args)
    {
        DelegateExample delegateExample = new DelegateExample();
        Employees employee = new(1, "Arya", 4);
        Employees employeeone = new(2, "Jaya", 5);
        DelegateOne delegateOne = Employees.BonusCalculation;
        DelegateTwo delegateTwo = Employees.BonusCalculation;
        Console.WriteLine($"Employee Name:{employee.EmployeeName}\nPerformance Rating:{employee.PerformanceRange}\nBonus Amount:{delegateOne(employee)}");
        Console.WriteLine($"Employee Name:{employeeone.EmployeeName}\nPerformance Rating:{employeeone.PerformanceRange}\nBonus Amount:{delegateTwo(employeeone)}");

    }
}*/

/*
class Program
{
    public delegate string DelegateMessageOne(string msg);
    public delegate string DelegateMessageTwo(string msg);
    public static void Main(string[] args)
    {
        HotelEvent hotelEvent = new("Dj", "Trivandrum", "12.00:12-10-2023", 4);
        DelegateMessageOne delegateMessageOne = HotelEvent.EventRegistration;
        if (hotelEvent != null)
        {
            Console.WriteLine(delegateMessageOne($"Hai {hotelEvent.EventName} is Successfully Registered the event on {hotelEvent.EventDate}"));
        }
        else
        {
            Console.WriteLine(delegateMessageOne("Unsuccessfully registered"));
        }
        HotelEvent hotelEventone = new("Hallowing", "Kollam", "12.0013-10-2023", 6);

        DelegateMessageTwo delegateMessageTwo = HotelEvent.EventRegistration;
        if (hotelEventone != null)
        {
            Console.WriteLine(delegateMessageTwo($"Hai {hotelEventone.EventName} is Successfully Registered the event on {hotelEventone.EventDate}"));
        }
        else
        {
            Console.WriteLine(delegateMessageTwo("Unsuccessfully registered"));
        }
    }
}
*/
/*
TourismDestination t1 = new("munnar","India",4);
TourismDestination t2 = new("Ooty", "India", 2);
TourismDestination t3 = new("Manali", "India", 5);
TourismDestination.tourismDestination.Add(t1);
TourismDestination.tourismDestination.Add(t2);
TourismDestination.tourismDestination.Add(t3);

TourismDestination.TourismDestSort();*/

/*TourismDestination1 t1 = new("munnar", "India", 4, 5000);
TourismDestination1 t2 = new("Ooty", "India", 2,3000);
TourismDestination1 t3 = new("Manali", "India", 5, 4000);
TourismDestination1.tourismDestination1.Add(t1);
TourismDestination1.tourismDestination1.Add(t2);
TourismDestination1.tourismDestination1.Add(t3);

TourismDestination1.DisplayTopRated();
TourismDestination1.SortedDestination();
TourismDestination1.FilterDestination();*/


class program
{
    static async Task Main(string[] args)
    {
        Hotel hotel1 = new Hotel("Trivandrum", "India", 4, 9875, "Flamingo", 40);
        Hotel hotel2 = new Hotel("Ponmudi", "India", 3, 3500, "DreamLand", 29);
        Hotel hotel3 = new Hotel("Idukki", "India", 3, 7450, "Parakatt", 10);

        await hotel1.BookRooms("Flamingo", 41);
        await hotel2.BookRooms("DreamLand", 2);
        await hotel3.BookRooms("Parakatt", 1);

    }

}










