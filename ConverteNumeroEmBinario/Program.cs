using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] binarios = new int[8];
        int numero;
        int resto;
        int contador = 7;
        Console.WriteLine("Informe um numero: ");
        numero = int.Parse(Console.ReadLine());

        do
        {
            binarios[contador] = converteBinario(numero);
            contador--;
        }while(contador >= 0);

        int converteBinario(int num)
        {
            resto =  numero % 2;
            numero = numero /2;
            return resto;
        }
        for( int x=0; x < 8;x++)
        {
            Console.Write(binarios[x] + " ");
        }



    }
}