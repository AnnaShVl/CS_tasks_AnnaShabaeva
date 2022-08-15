//  Написать программу, которая обменивает элементы первой строки и последней строки

 Random rnd = new Random();  
            const int n = 4, m = 5;     
            int[,] matrix = new int[n, m];  
            int i, j, temp;             
                       for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(100);   
                    Console.Write($"{matrix[i, j],4}");   
                }
                Console.WriteLine();
            }
            
            for (j = 0; j < m; j++)
            {
                temp=matrix[0, j];
                matrix[0, j]=matrix[n - 1, j];
                matrix[n - 1, j] = temp;
            }
            Console.WriteLine("Матрица после замены строк:");
          
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }