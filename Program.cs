String trident;
Console.WriteLine("escreva uma frase");
trident=Console.ReadLine()!.Replace("a", "4")
.Replace("e", "3")
.Replace("i", "1")
.Replace("l", "1")
.Replace("o", "0")
.Replace("t", "7")
.Replace("s", "5").ToUpper();
Console.WriteLine($"{trident}");