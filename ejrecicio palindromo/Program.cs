// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escribe una palabra o frase, reswivaremos si es un palindromo!");
string? input = Console.ReadLine();
bool isPalindrome = IsPalindrome(input);
Console.ReadLine(); = input?.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "") ?? "";
if (isPalindrome)
{
    Console.WriteLine("Es un palindromo");
}
else
{
    Console.WriteLine("No es un palindromo");
}
Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();