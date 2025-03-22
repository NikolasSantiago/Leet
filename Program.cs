string fraseDigitada; 

string fraseLeet;

 Console.Clear();

  Console.Write(" Digite uma frase: ");

   fraseDigitada = Console.ReadLine()!;

    fraseLeet = fraseDigitada 
    .Replace("a", "4") 
    .Replace("e", "3")
    .Replace("i", "1")
    .Replace("o", "0")
    .Replace("t", "7")
    .Replace("s", "5");

     Console.WriteLine(fraseLeet);