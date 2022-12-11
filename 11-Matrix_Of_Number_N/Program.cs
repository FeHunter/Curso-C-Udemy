using System;

namespace MatrixN {
    class Program {
        static void Main (){
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int [n, n];

            for (int i=0; i < n; i++){
                string[] values = Console.ReadLine().Split(' ');
                for (int j=0; j < n; j++){
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            System.Console.WriteLine("Main Diagonal:");
            for (int i=0; i < n; i++){
                System.Console.WriteLine(mat[i, i]+" ");
            }

            int count = 0;
            for (int i=0; i < n; i++){
                for (int j=0; j < n; j++){
                    if (mat[i, j] < 0){
                        count ++;
                    }
                }
            }
            System.Console.WriteLine("Negative numbers: "+count);
        }
    }
}