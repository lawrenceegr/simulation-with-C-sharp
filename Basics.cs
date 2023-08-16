public const string FILE_NAME= "example.bin"; 
static void Main()
{
    FileStream fs = new FileStream(FILE_NAME, FileMode    .CreateNew) // Create the writer for data .
    ; BinaryWriter w = new BinaryWriter(fs);//    Write data to Test.data.
    for (int i = 0; i < 11; i++) { w.Write((int)i); }
    w.Close();
    fs.Close() // Create the reader for data.
    ; fs = new FileStream(FILE_NAME, FileMode.Open
    , FileAccess.Read); BinaryReader r
    = new BinaryReader(fs); // Read data from Test.data.
    for (int i = 0; i < 11; i++)
    {
        Console.WriteLine
    (r.ReadInt32())
    ;
    }
    r.Close(); fs.Close();
}