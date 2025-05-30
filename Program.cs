using System;
using System.IO;

namespace Matrices
{
    class MatricesProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nIniciando Vector y Matrices\n");

            Console.WriteLine("Creando y mostrando un vector con 4 celdas con el contenido de 3.5 \n");
            double[] vec = Utils.VecCreate(4, 3.5);
            Utils.VecShow(vec, 3, 6);

            Console.WriteLine("\nCreando y visualizando matriz de 4x3\n");
            double[][] m1 = Utils.MatCreate(3, 4);
            Utils.MatShow(m1, 3, 6);

            Console.WriteLine("\nCargando la matriz de 4x3 con el archivo data_ml.tsv \n");
            string fn = Path.Combine(Directory.GetCurrentDirectory(), "data_ml.tsv");
            int[] cols = new int[] { 0, 1, 2 };
            double[][] m2 = Utils.MatLoad(fn, 4, cols, '\t');
            Utils.MatShow(m2, 3, 6);

            Console.WriteLine("\nFin de la aplicación\n");
            Console.ReadLine();
        }
    }

    public class Utils // clase de utilidades para el manejo de vectores y matrices
    {
        public static double[] VecCreate(int n, double val = 0.0) // crea vector de tamaño n con los valores recibidos
        {
            double[] result = new double[n];
            for (int i = 0; i < n; ++i)
                result[i] = val;
            return result;
        }

        public static void VecShow(double[] vec, int dec, int wid) // muestra el vector
        {
            for (int i = 0; i < vec.Length; ++i)
            {
                double x = vec[i];
                Console.Write(x.ToString("F" + dec).PadLeft(wid));
            }
            Console.WriteLine();
        }

        public static double[][] MatCreate(int nRows, int nCols) // crea la matriz con datos dummy
        {
            double[][] result = new double[nRows][];
            for (int i = 0; i < nRows; ++i)
            {
                result[i] = new double[nCols];
                for (int j = 0; j < nCols; ++j)
                    result[i][j] = i * 10 + j;
            }
            return result;
        }

        public static void MatShow(double[][] mat, int dec, int wid) // muestra la matriz con formato
        {
            int nRows = mat.Length;
            int nCols = mat[0].Length;
            for (int i = 0; i < nRows; ++i)
            {
                for (int j = 0; j < nCols; ++j)
                {
                    double x = mat[i][j];
                    Console.Write(x.ToString("F" + dec).PadLeft(wid));
                }
                Console.WriteLine();
            }
        }

        public static double[][] MatLoad(string fn, int nRows, int[] cols, char sep) // carga datos desde archivo
        {
            int nCols = cols.Length;
            double[][] result = MatCreate(nRows, nCols);

            string line = "";
            string[] tokens = null;

            FileStream ifs = new FileStream(fn, FileMode.Open);
            StreamReader sr = new StreamReader(ifs);

            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("#") == true)
                    continue;

                tokens = line.Split(sep);
                for (int j = 0; j < nCols; ++j)
                {
                    int k = cols[j];
                    result[i][j] = double.Parse(tokens[k]);
                }
                ++i;
            }

            sr.Close();
            return result;
        }
    }
}
