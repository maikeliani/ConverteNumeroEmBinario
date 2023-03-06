using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] binarios = new int[8];
        int valor;
        int resto;
        int quociente;
        Console.WriteLine("Informe um numero: ");
        valor = int.Parse(Console.ReadLine());


        converteBinario(valor);

        int[] converteBinario(int valor)
        {

            quociente = valor;

            for (int x = 0; x < binarios.Length; x++)
            {
                if ((quociente == 1) && (quociente % 2 == 0))
                {
                    x = binarios.Length;
                }

                resto = quociente % 2;
                binarios[x] = resto;
                quociente = valor / 2;
                valor = quociente;
            }
            return binarios;

        }
        for( int x= binarios.Length -1 ; x >= 0;x--)
        {
            Console.Write(binarios[x] + " ");
        }



    }
}