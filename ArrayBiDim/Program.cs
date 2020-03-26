using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variaveis
            string str;
            float [ , ] matrix;
            int lines, colunas;
            float somadasmedias = 0;
             
            //Pedir utilizador numero de linhas da matrix
            Console.WriteLine("Nº of lines:");
            str = Console.ReadLine();
            lines = int.Parse(str);
            
            //Pedir ao user colunas da matrix
            Console.WriteLine("Nº of Columns:");
            str = Console.ReadLine();
            colunas = int.Parse(str);
            
            // Inicializar matrix
            matrix = new float[lines,colunas];
            
            //Pedir floats para a matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Insert floats for Matrix ({i},{j}):");
                    str = Console.ReadLine();
                    matrix [i, j] = Convert.ToSingle(str);
                }
            }
            
            //Mostrar matrix e a media de cada linha
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                float soma = 0, media;
                Console.Write("| ");
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    soma += matrix[i, j];
                    Console.Write(matrix[i, j] + " ");
                }
                media = soma / matrix.GetLength(1);                                                                                          
                Console.Write($"| -> {media,10:f3}");
                somadasmedias += media;

            }

            //Mostrar soma das medias
            Console.Write("Total das medias: {0,10:f3}", somadasmedias);
        }
    }
}
