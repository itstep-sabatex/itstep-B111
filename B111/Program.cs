// See https://aka.ms/new-console-template for more information
using System.Text;
using MyModels =  B111.Models; //alias
using static System.Console;

B111.MyInt nystruct;
//nystruct.PublicField = 10;

int rrr;
//int rrrr = rrr;

B111.MyInt nystruct2 = new B111.MyInt();
nystruct.PublicField = 10;

var aClass = new B111.A();
var bClass = new B111.B(5);
Console.WriteLine(bClass.ToString());
bClass.PublicField = 1;
aClass.PublicField = 1;
Console.WriteLine(aClass.VitrualMethod());
Console.WriteLine(bClass.VitrualMethod());
var aClassFromB = (B111.A)bClass;
aClassFromB.PublicField = 1;
aClassFromB.VitrualMethod();



int unb = 10;
int cun = unb;

object ob = (object)unb;
int ob2 = (int)ob;


showValue(unb);
showValue(ob);
showValueInt(unb);

var ac = (B111.AbstractClass)bClass;

uint arg2 = 2;
uint hi = 0;// старший 64 біт
uint lo = 0;// молодший 64

var person = new MyModels.Person();

Console.WriteLine(person.Name);
WriteLine(person.Name);
uint maxb= uint.MaxValue;
checked
{
    lo = maxb + arg2;
}
unchecked
{
    lo = maxb + arg2;//ad
}

try
{
    lo = checked(maxb + arg2);
}
catch (OverflowException e)
{
    lo = maxb + arg2;
    hi++; 
}

var ov = maxb +arg2;
try
{
    var r = mull(10,20);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw new DivideByZeroException(ex.Message);
}
finally
{
    Console.WriteLine("FINNALY EXECUTE");
}


Console.WriteLine("Hello, World!");

Environment.Exit(0);

var a = 'D';
var c = args[0];
byte byteVar = 10; // 8 bit [0-255]
sbyte sbyteVar = -10; // 8 bit [-127..126]
short shortVar = -10; //16
ushort ushortVar = 10; //16
int intVar = -10; //32
uint uintVar = 10; //32
long longVar = 10; //64
ulong ulongVar = 10; //64

bool boolVar = false;
char charVar = 'A'; //16 UTF
string stringVar = "Hello World";
for (int i = 0; i < 1000000; i++)
    stringVar +=  i.ToString();
StringBuilder sb = new StringBuilder(stringVar);
for (int i = 0; i < 1000000; i++)
{
    sb.Append(i.ToString());
}
Console.WriteLine(sb.ToString());

float floatVar = 1.3f; //32
double doubleVar = 2.3; //64

decimal decimalVar = 2.3M; //
DateTime dateTimeVar = DateTime.Now;
doubleVar = floatVar;
floatVar = (float)doubleVar;

var anonimous = new { Name = "Ivan", Surname = "Sidorenko", Age = 32 };


if (anonimous.Name == "df")
{

}
else
{

}

switch (intVar)
{
    case 0:break;
    case 1:break;
    default:break;
}

var aT = intVar > 10 ? "ddd" : "fff";

while (true) { }
do { }while (true);
foreach (var aV in stringVar) { }
var ss = nameof(aT);

//break;
//continue;
// goto

int mull(int a,int b)
{
    if (a+b > 1000)
    {
        throw new Exception("arg b must by less 1000");
    }
    return a * b;
}
int[] items = new int[10];
int getItem(int index)
{
    if (index >= items.Length)
        throw new OverflowException();

    return items[index];
}

void showValue(object value)
{
    Console.WriteLine(value.ToString());
}

void showValueInt(int value)
{
    Console.WriteLine(value.ToString());
}




