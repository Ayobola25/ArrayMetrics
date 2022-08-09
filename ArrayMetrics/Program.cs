namespace ArrayMetrics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr3d1 = new int[3, 2, 3]
            {
               { {1,2,3},{4,3,4} },
               { {1,2,3},{4,3,4} },
               { {1,2,3},{4,3,4} }

             };
            int[,,] arr3d2 = new int[3, 2, 3]
            {
               { {1,2,3},{4,3,4} },
               { {1,2,3},{4,3,4} },
               { {1,2,3},{4,3,4} }

            };

            int[,,] arr3d3 = new int[3, 2, 3];
            for (int i = 0; i < arr3d1.GetLength(0); i++) 
            {
                for (int j = 0; j < arr3d1.GetLength(1); j++)
                {
                    for (int k = 0; k < arr3d1.GetLength(2); k++)
                    {
                        arr3d3[i, j, k] += arr3d1[i, j, k] * arr3d2[i, j, k];
                        foreach (int value in arr3d2)
                        {
                            Console.WriteLine(arr3d3[i,j,k]);
                        }
                    }
                }
             }

                     
            Console.WriteLine("Hello, World!");
        }
    }
}