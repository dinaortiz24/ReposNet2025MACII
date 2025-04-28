internal class Program
{

    //declaraciones 
    //arreglo unidimensional su declaración y su asignacion de datos
    static int[] ArreUni = new int[10];
    static char[] ArreUniChar = new char[10];
    //Arreglo bidimensionl o matrices, declaración y asignación
    static int[,] ArreBidi ={{30,10,20},/*Reglon1*/
                            {100,200,150},/*Renglon2*/
                            {1000,2000,300}/*Reglon3*/ };

    //Arreglo tridimensional, declaración y asignación
    static int[,,] ArreTridi ={{{10,20,30},/*Renglon0*/{40,50,60},/*renglo1*/{70,80,90}/*Renglon2*/},/*Plano0*/
                                {{100,200,300},/*Renglon0*/{400,500,600},/*renglo1*/{700,800,900}/*Renglon2*/},/*Plano1*/
                                {{1,2,3},/*Renglon0*/{4,5,6},/*renglo1*/{7,8,9}/*Renglon2*/}/*Plano2*/};
    private static void Main(string[] args)
    {
        //asignación de datos en ArreUni
        for (int i = 0; i < ArreUni.Length; i++)
        {
            ArreUni[i] = i * i + 1;
        }
        Console.WriteLine("Elementos del Arreglo Unidimesnional");
        for (int i = 0; i < ArreUni.Length; i++)
        {
            Console.WriteLine("ArreUni[{0}]={1}", i, ArreUni[i]);
        }
        Console.WriteLine("Elementos del Arreglo Bidimensional");
        //ciclo que recorre renglones
        for (int r = 0; r < ArreBidi.GetLength(0); r++)
        {
            //ciclo que recorre las columnas
            for (int c = 0; c < ArreBidi.GetLength(1); c++)
            {
                Console.Write("ArreBidi[{0}]  ", ArreBidi[r, c]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Elementos del Arreglo Tridimensional");
        //ciclo que recoore el plano
        for (int p = 0; p < ArreTridi.GetLength(0); p++)
        {
            //ciclo que recorre renglones
            for (int r = 0; r < ArreTridi.GetLength(1); r++)
            {
                //ciclo que recorre las columnas
                for (int c = 0; c < ArreTridi.GetLength(2); c++)
                {
                Console.Write("ArreTridi[{0},{1},{2}]={3}  ",p,r,c, ArreTridi[p,r, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

    }
}