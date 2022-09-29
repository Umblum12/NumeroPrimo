// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa numero!");
int n;
n=Console.Read();
bool esprimo = true;
if (n <= 3)
{
    Console.WriteLine("Es primo");
}
else
{
 for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            esprimo = false;
            break;
        }
    }
}
if (esprimo)
{
    Console.WriteLine("Es Primo");
}
else
{
    Console.WriteLine("No es Primo");
}