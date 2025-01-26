using System.IO;

string sourcePath = @"D:\EstudoCSharp\Arquivos\file.txt";
string targetPath = @"D:\EstudoCSharp\Arquivos\file2.txt";
//FileStream fs = null;
//StreamReader sr = null;
try
{
    /* Ler e copiar arquivo
    FileInfo fileInfo = new(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);
    foreach(string line in lines)
    {
        Console.WriteLine(line);
    }*/

    /*FileStream e StreamReader
    fs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
    sr = new StreamReader(fs);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
    */

    /*Bloco using
    try
    {
        using (FileStream fs = new(sourcePath, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader sr = new(fs))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
    }
    catch (IOException e)
    {
        Console.WriteLine("An eror ocurred");
        Console.WriteLine(e.Message);
    }
    */

    //StreamWriter
    string[] lines = File.ReadAllLines(sourcePath);
    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An eror occurred");
    Console.WriteLine(e.Message);
}
//finally
//{
//    sr?.Close();
//    fs?.Close();
//}