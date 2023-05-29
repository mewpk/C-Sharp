
// for each list array
double[] numbers = { 0.1, 2.32 };

foreach (double number in numbers)
{

    Console.WriteLine("Number {0}", number);
}
Console.ReadKey();


// array 2 dimensional
string[,] person = new string[4, 5] {
{"John" , "John" , "John" , "John" , "John"},
{"Bob" , "Bob" , "Bob" , "Bob" , "Bob"},
{"Sally" , "Sally" , "Sally" , "Sally" , "Sally"},
{"Robert" , "Robert" , "Robert" , "Robert" , "Robert"}
};
// 4 row , 5 column fix

string[,] teacher = {
    {"John" , "John" , "John" , "John"},{"Bob" , "Bob" , "Bob" , "Bob"}
};
// Dynamic array
Console.WriteLine("Teacher Rows {0}", teacher.GetLength(0));
Console.WriteLine("Teacher Cols {0}", teacher.GetLength(1));
Console.WriteLine("Teacher Total Length {0}", teacher.Length);
Console.ReadKey();

