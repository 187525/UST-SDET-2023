﻿using Basic_Program;
using Basic_Program.ExceptionMessage;

/*ExcepHandling exe = new ExcepHandling(10, 10);
MyExceptions excep = new MyExceptions();

try
{
    excep.NumCheck();
}
catch(Num1Exception ex)
{
    Console.WriteLine(excep.exmessdict[3]);
}
/*try
{
    exe.Divide();
}

 catch (ArithmeticException ex)
{

    Console.WriteLine(MyExceptions.exmessdict[0]);
}    
catch(IndexOutOfRangeException ex)
      {
    Console.WriteLine(MyExceptions.exmessdict[1]);
}
      catch(Exception ex) 
      {
    Console.WriteLine(MyExceptions.exmessdict[2]);
}
      finally
      {
    Console.WriteLine("done");
}



/*sic_Program.GC gC= new Basic_Program.GC();
gC.ListHandling();
gC.Stackhandling();
gC.Queuehandling();




/*NGC ngc= new NGC();
ngc.ArrayListHandling();
ngc.StackHandling();
ngc.QueueHandling();*/

/*Doctor doc= new Doctor();
doc.AddNewDoctor();
doc.DisplayDoctorDetails();

doc.ModifyDoctor(); 
doc.DisplayDoctorDetails();
doc.BookApp(9876, "XX");
doc.DelApp("XX");*/

/*BankDetails bankDetails = new BankDetails(1234,11234567860L,"Vishnu","InActive");*/
/*BankDetails bankdetailsone = new BankDetails();*/
/*BankDetails bankDetailsNew = new BankDetailsNew(123, 12345677L, "Vishnu", "Active");
bankDetailsNew.WelcomeMessage();
Console.WriteLine("1.CustomerId\n2.AccountNumber\n3.CustomerName");
int choice;
Console.WriteLine("Choose One Option");
choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine("Enter The CustomerId");
        int customerid = Convert.ToInt32(Console.ReadLine());
        bankDetailsNew.GetAccountDetails(customerid);
        bankDetailsNew.ExitMessage();
        break;
    case 2:
        Console.WriteLine("Enter The AccountNumber");
        long accountnumber = Convert.ToInt64(Console.ReadLine());
        bankDetailsNew.GetAccountDetails(accountnumber);
        bankDetailsNew.ExitMessage();
        break;
    case 3:
        Console.WriteLine("Enter the CustomerName Name");
        string? customername = Console.ReadLine();
        bankDetailsNew.GetAccountDetails(customername);
        bankDetailsNew.ExitMessage();
        break;
    default:
        Console.WriteLine("INVALID ENTRY TRY AGAIN LATER!!!");
        break;

}*/






/*Console.WriteLine("1. TS /n 2: NTS \n" );

switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff ts=new TeachingStaff();
        ts.staffid = 111;
        ts.Name = "TS1";
        ts.Dept = "CS";
        ts.Specializations = "OS, DBMS, DS";
        ts.Sem = 4;
        ts.DisplayTStaffDetails();
        ts.DisplayStaffDetails();
        break;
    case 2:
        NonTeachingStaff nts = new NonTeachingStaff();
        nts.staffid = 111;
        nts.Name = "NTS1";
        nts.Dept = "ADMIN";
       // nts.Resposibilities = "Att, sal";
       // nts.Experience = 4;
        //nts.DisplayTStaffDetails();
        //nts.DisplayStaffDetails();
        break;
}
*/
/*
EV ev = new();
ev.Vehnum=444;
ev.Brand = "xx";
ev.Model = "AA";
ev.SetTypeForVehicle();


PV pv = new();
pv.Vehnum = 234567;
pv.Brand = "suzuti";
pv.Model = "bb";
pv.Disp();
Console.WriteLine(pv.SetTypeForVehicle());
*/








/*


/* ADDITION OF TWO NUMBERS
Console.WriteLine("Enter 2 numbers:");
int num1,num2,ans;

num1=Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());

ans = num1 + num2;
Console.WriteLine(ans);

*/

//STRING MANIPULATION
/*
using Basic_Program;

int x;
string s1;
string s2;
string s3;
s1=Console.ReadLine();
s2=Console.ReadLine();
s3 = s1 + " "+s2;
Console.WriteLine(s3);

Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());

Console.WriteLine(s2.Substring(3));

string[] s=s3.Split(' ');
for(int i=0;i<s.Length;i++)
    Console.WriteLine(s[i]);
*/


/*Calculation calculator = new Calculation();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
double res = calculator.add(num1,num2);
Console.WriteLine(res);
*/


/*
Electricity electricity1=new (12345,9000,9300,"XX");
Console.WriteLine(electricity1.consumernumber);
Console.WriteLine(electricity1.consumername);

Console.WriteLine(electricity1.CalculateBill());

Electricity electricity2 = new(12345, 9000, 9300, "XX");
Console.WriteLine(electricity2.consumernumber);
Console.WriteLine(electricity2.consumername);
*/
/*
Employee employee = new(111, "AA", "IT", 10000);
Console.WriteLine("EMPLOYEE ID :{0} \n Employee_NAME : {1} \n " + "Employee_DEPT : {2} \n BASIC_PAY: {3}",
    employee.Eid,
    employee.Ename,
    employee.Dept,
    employee.Basicpay);

Console.WriteLine("Netsalary : {0} ", employee.CalculateSalary());
*/

/*ArrayEx arrayex=new ArrayEx();
//arrayex.Onedim();
//arrayex.TwoDim();
arrayex.Ja();*/


//StudentMarks marks = new();

/*StudentGrade grade = new();
grade.RollNo = 200;
grade.StudName = "Arya";
grade.Mark1 = 300;
grade.Mark2 = 400;
grade.Mark3 = 200;
grade.DisplayStudentDetails();
Console.WriteLine("Total " + grade.CalculateTotal());
Console.WriteLine("Average " +grade.CalculateAverage());
Console.WriteLine("Grade " + grade.CalculateGrade());

/*StudentGrade mark = new();
mark.RollNo = 200;
mark.StudName = "Arya";
mark.City = "Trivandrum";
mark.Mark1 = 300;
mark.Mark2 = 400;
mark.Mark3 = 200;
mark.DisplayStudentDetails();
Console.WriteLine("Total " + mark.CalculateTotal());
Console.WriteLine("Average " + mark.CalculateAverage());*/

using Basic_Program.ExceptionMessage;
using Basic_Program;
/*
 * 
ExceptionHandling exceptionHandling = new(3, 5);
//try
//{
//    exceptionHandling.NumberCheck();
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    exceptionHandling.Divide();
//}
//catch (ArithmeticException ex)
//{
//    Console.WriteLine(MyExceptions.exceptionmessage[0]);
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Source);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(MyExceptions.exceptionmessage[1]);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(MyExceptions.exceptionmessage[2]);
//}
try
{
    exceptionHandling.NumberCheck1();
}
catch (Number1Exception ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    exceptionHandling.NumberCheck2();

}
catch (Number2Exception ex)
{
    Console.WriteLine(ex.Message);
}                       */


//FileOperations FO=new FileOperations();
//FO.CreateFile();
////FO.WriteData();
//FO.ReadData();
//FO.CopyMoveFile();
//FO.DeleteFile();
//FO.FileProperties();


/*GenEx<int> g1 = new GenEx<int>(10, 20);
Console.WriteLine(g1.Val1 + "   " + g1.Val2);


GenEx<double> g2 = new GenEx<double>(10.45676, 20.687897);
Console.WriteLine(g2.Val1 + "   " + g2.Val2);



GenEx<string> g3 = new GenEx<string>("AAA", "BBB");
Console.WriteLine(g3.Val1 + "   " + g3.Val2);


GenEx<bool> g4 = new GenEx<bool>(true, false);
Console.WriteLine(g4.Val1 + "   " + g4.Val2);*/


/*GenEx<int>  ga=new GenEx<int>(new int[3] {10,20,30});
ga.Disp();*/



/public delegate void DelegateOne(string msg);
public delegate void DelegateTwo(int n1,int n2);
public delegate int DelegateThree(int n1,int n2);   
class Program
{
    public static void Main(string[] args)
    {
        DelegateOne delegateOne = DelegateExamples.MethodDisplay;
        delegateOne("Helloooo aswin!!!");
        DelegateExamples delegateExamples = new();
        DelegateTwo delegateTwo = delegateExamples.Add;
       
        DelegateTwo delegateThree = delegateExamples.Sub;
        DelegateThree delegateThree1 = delegateExamples.Addr;
        Console.WriteLine(delegateThree1(20, 20));
        DelegateTwo delegateobj = delegateTwo + delegateThree-delegateThree;//MultiCasting symbol of delegate is +.
        delegateobj(10, 20);
       

    }
}








