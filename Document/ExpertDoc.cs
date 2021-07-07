using System;
namespace Doc
{
    public class ExpertDocument : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format.");
        }
    }
}
