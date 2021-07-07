using System;
namespace Doc
{
    static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string key;
                DocumentProgram program = null;
                do
                {
                    Console.WriteLine(@$"Please enter your key 
basic
pro 
expert
");
                    Console.Write("Enter key: ");
                    key = Console.ReadLine();
                } while (String.IsNullOrEmpty(key));

                if (key == ProgramKeys.Basic)
                    program = new DocumentProgram();
                else if (key == ProgramKeys.Pro)
                    program = new ProDocumentProgram();
                else if (key == ProgramKeys.Expert)
                    program = new ExpertDocument();
                else
                {
                    throw new ProgramKeyException($"There is no key equal to -> {key}");
                }
                program.OpenDocument();
                program.EditDocument();
                program.SaveDocument();
                Console.WriteLine("Document Closed");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
    }
}
