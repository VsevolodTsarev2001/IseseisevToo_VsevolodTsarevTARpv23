using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IseseisevToo_VsevolodTsarevTARpv23
{
    public class MatrixOperations
    {
        public static (int sum, long product) CalculateSumAndProduct(int[,] matrix)
        {
            int sum = 0;
            long product = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                    product *= matrix[i, j];
                }
            }

            return (sum, product);
        }
    }
}
