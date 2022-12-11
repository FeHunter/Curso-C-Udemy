using System;

namespace Matriz {
    class Program {
        static void Main (string[] args){
            System.Console.WriteLine("Type numbers of colums:");
            int c = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Type numbers of line:");
            int l = int.Parse(Console.ReadLine());

            int[,] mat = new int [c, l];

            System.Console.WriteLine("Matriz create with "+c+" colums and "+l+" lines.");

            for (int i=0; i < c; i++) {
                System.Console.Write("type on colum "+(i+1)+", type "+l+" values: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j=0; j < l; j++){
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("The Matriz");
            for (int i=0; i < c; i++){
                for (int j=0; j < l; j++){
                    System.Console.Write(mat[i, j] + " ");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Choose a number for analise");
            int checkNumber = int.Parse(Console.ReadLine());

            // Check position of the number
            System.Console.WriteLine();
            for (int i=0; i < c; i++){
                for (int j=0; j < l; j++){
                    if (checkNumber == mat[i, j]){
                        System.Console.WriteLine("Position: "+i+", "+j);
                    }
                }
            }

            // Check for neighbors
            for (int i=0; i < c; i++){
                for (int j=0; j < l; j++){
                    if (checkNumber == mat[i, j]){
                        int left = (j - 1);
                        System.Console.WriteLine("Left: "+mat[i, left]);
                        int right = (j + 1);
                        System.Console.WriteLine("Right: "+mat[i, right]);
                        int top = (i - 1);
                        System.Console.WriteLine("Top: "+mat[top, j]);
                        int down = (i + 1);
                        System.Console.WriteLine("Down: "+mat[down, j]);
                    }
                }
            }
            
        }
    }
}