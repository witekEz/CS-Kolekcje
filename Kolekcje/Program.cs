using Kolekcje;
using System.Data;
using System.Linq;

//Lists
Lists lists = new Lists();
List<int> list = new List<int>() { 3, 5, 2, 5, 2 ,6 ,6,2,23};
lists.list= list;
lists.DisplayList();
Console.WriteLine("*SORT*");
lists.list.Sort();
lists.DisplayList();
//LinQ
List<Person> GetEmplyees()
{
    List<Person> employees = new List<Person>()
    {
        new Person(new DateTime(1990,2,2),"Bill","Wick"),
        new Person(new DateTime(1995,6,2),"John","Wick"),
        new Person(new DateTime(1996,4,3),"Bob","Wick"),
        new Person(new DateTime(2001,2,2),"Bill","Smith"),
        new Person(new DateTime(2005,6,5),"John","Smith"),
        new Person(new DateTime(2003,3,2),"Bob","Smith"),
    };
        return employees;
}
List<Person> employees= GetEmplyees();
bool EmployeeIsYoung(Person employee)
{
    return employee.GetDateOfBirth()> new DateTime(2000, 1, 1);
}
List<Person> youngEmployees = employees.Where(EmployeeIsYoung).ToList();

//foreach(Person employee in employees)
//{
//    if(employee.GetDateOfBirth()>new DateTime(2000,1,1))
//    {
//        youngEmployees.Add(employee);
//    }
//}
Console.WriteLine($"Young employees: {youngEmployees.Count}");
bool IsThisBob(Person employee)
{
    return employee.FirstName == "Bob";
}
Person bob = youngEmployees.FirstOrDefault(IsThisBob);
//foreach(Person youngEmployee in youngEmployees)
//{
//    if(youngEmployee.FirstName=="Bob")
//    {
//        bob = youngEmployee;
//        break;
//    }
//}
if(bob!=null)
{
    bob.SayHi();
}
else
{
    Console.WriteLine("Bob not found!");
}
//Wyr.Lambda
List<Person> youngEmployees1 = employees.Where(e=>e.GetDateOfBirth()>new DateTime(2000,1,1)).ToList();
Console.WriteLine($"Young employees: {youngEmployees1.Count}");
Person bob1 = youngEmployees1.FirstOrDefault(e => e.FirstName == "Bob");
if (bob1 != null)
{
    bob1.SayHi();
}
else
{
    Console.WriteLine("Bob not found!");
}
//Słownik
Dictionary<string,Currency> GetCurrencies()
{
    return new Dictionary<string,Currency>()
    {
        {"usd", new Currency("usd", "United States Dollar",1) },
        { "eur", new Currency("eur", "Euro", 0.83975) },
        { "gbp", new Currency("gbp", "British Pound, ", 0.74771) },
        { "cad", new Currency("cad", "Canadian Dollar ", 1.30724) },
        { "inr", new Currency("inr", "Indian Ruppe ", 73.04) },
        { "mxn", new Currency("mxn", "Mexican Peso", 21.7571) }
    };
}
Dictionary<string,Currency> currencies = GetCurrencies();
Console.WriteLine("Chcek rate for:");
string usrInput=Console.ReadLine();
if(usrInput!=null)
{
    Currency selectedCurrency = currencies[usrInput];
    if (currencies.TryGetValue(usrInput, out selectedCurrency))
    {
        Console.WriteLine($"Rate for USD to {selectedCurrency.FullName} is {selectedCurrency.Rate}");
    }
    else
    {
        Console.WriteLine("Currency not found");
    }
    currencies.Remove("usd");
    currencies.TryAdd("usd", new Currency("usd", "United States Dollar", 1));
}
// słowo var
//zastosujemy je tylko przy definicji zmiennych, nie deklaracji

//Iterator Yield

static IEnumerable<int> GetData()
{
    Console.WriteLine($"Get data start");
    var result = new List<int>();
    for (int i = 0; i < 9; i++)
    {
        Console.WriteLine($"Get add element {i}");
        result.Add(i);
    }
    Console.WriteLine($"Get data end");
    return result;
}
static IEnumerable<int> GetYieldedData()
{
    Console.WriteLine($"Get YieldData start");
    for (int i=0;i<9;i++)
    {
        Console.WriteLine($"Get YieldAdd element {i}");
        yield return i;
        if(i % 3==0) { yield break; }
    }
    Console.WriteLine($"Get YieldData end");
}
var yieldedData=GetYieldedData();
var data=GetData();
foreach(int i in yieldedData)
{
    Console.WriteLine(i);
}