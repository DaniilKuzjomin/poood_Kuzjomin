using System.IO;
using SautinSoft.Document;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertFromFile();
            ConvertFromStream();
        }

        /// <summary>
        /// Convert DOC (Word 97-2003) to PDF (file to file).
        /// </summary>
		/// <remarks>
        /// Details: https://sautinsoft.com/products/document/help/net/developer-guide/convert-doc-word-97-2003-to-pdf-in-csharp-vb.php
        /// </remarks>
        static void ConvertFromFile()
        {
            string inpFile = @"..\..\..\example.doc";
            string outFile = @"Result.pdf";

            DocumentCore dc = DocumentCore.Load(inpFile);
            dc.Save(outFile);

            // Open the result for demonstration purposes.
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
        }

        /// <summary>
        /// Convert DOC (Word 97-2003) to PDF (using Stream).
        /// </summary>
		/// <remarks>
        /// Details: https://sautinsoft.com/products/document/help/net/developer-guide/convert-doc-word-97-2003-to-pdf-in-csharp-vb.php
        /// </remarks>
        static void ConvertFromStream()
        {

            // We need files only for demonstration purposes.
            // The conversion process will be done completely in memory.
            string inpFile = @"..\..\..\example.doc";
            string outFile = @"ResultStream.pdf";
            byte[] inpData = File.ReadAllBytes(inpFile);
            byte[] outData = null;

            using (MemoryStream msInp = new MemoryStream(inpData))
            {

                // Load a document.
                DocumentCore dc = DocumentCore.Load(msInp, new DocLoadOptions());

                // Save the document to PDF format.
                using (MemoryStream outMs = new MemoryStream())
                {
                    dc.Save(outMs, new PdfSaveOptions() );
                    outData = outMs.ToArray();                    
                }
                // Show the result for demonstration purposes.
                if (outData != null)
                {
                    File.WriteAllBytes(outFile, outData);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
                }
            }
        }
    }
}