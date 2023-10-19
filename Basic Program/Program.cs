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

using Basic_Program;
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

ArrayEx arrayex=new ArrayEx();
//arrayex.Onedim();
//arrayex.TwoDim();
arrayex.Ja();