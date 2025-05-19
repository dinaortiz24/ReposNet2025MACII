using System.Runtime.CompilerServices;
using System.Text;

internal class Test
{
    private static void Main(string[] args)
    {
        // hacer objero de clase
        ClasesGeneralesFiles.ClGeneral objc = new ClasesGeneralesFiles.ClGeneral();
            string path = @"C:\Users\dinao\Documents\MyTest.txt";
        //borrar el archivo si existe
        if (File.Exists(path)) { 
          File.Delete(path);
        }
        //crear el archivo
        using (FileStream fs = File.Create(path)) {
              objc.AddText(fs, "Eba\n");
            objc.AddText(fs, "Textto recopilao");

            fs.Close();
        }

        //Abrir el archivo usar stran y leeer regresar los datos
        using (FileStream fs = File.OpenRead(path))
        {
            byte[] b=new byte[1024];
            UTF8Encoding tem = new UTF8Encoding(true);
            while(fs.Read(b, 0,b.Length) > 0)
            {
                Console.WriteLine(tem.GetString(b));
            }
            fs.Close   ();
        }
    }
   

} //fin de clase