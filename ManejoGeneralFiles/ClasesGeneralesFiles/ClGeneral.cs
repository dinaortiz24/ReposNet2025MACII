using System.Text;


namespace ClasesGeneralesFiles
{

    public class ClGeneral
    {
        private  FileStream? fs;
        private string? value;
        //constructor

        public ClGeneral() { }
        public ClGeneral(FileStream fs, string value)
        {
            this.fs = fs ?? throw new ArgumentNullException(nameof(fs));
            this.value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public void AddText(FileStream fs, string value)
        {
            this.fs = fs ?? throw new ArgumentNullException(nameof(fs));
            this.value = value ?? throw new ArgumentNullException(nameof(value));

            byte[] info = new UTF8Encoding(true).GetBytes(this.value);
            this.fs.Write(info, 0, info.Length);
        }
    }
}