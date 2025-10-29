// See https://aka.ms/new-console-template for more information
var environmentUser = Environment.GetEnvironmentVariable("USERNAME") ?? "undefined user";
var environmentLanguage = Environment.GetEnvironmentVariable("LANGUAGE") ?? "undefined Language";

Console.WriteLine($"¡Hola, {environmentUser} desde GitHub!");

if (!environmentLanguage.Contains("undefined"))
{
  Console.WriteLine($"¡Bienvenido al curso de GitHub Actions con el lenguaje de {environmentLanguage}!");
}
