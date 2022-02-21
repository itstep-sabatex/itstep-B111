// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
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









