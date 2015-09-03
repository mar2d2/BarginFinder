using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ShoppingApplication
{
    class PDFReceipt
    {
        private Document _document;      
        private UserManager _usermanager;

        public PDFReceipt(UserManager usermanager)
        {
            _document = new Document(PageSize.LETTER); // Sets the doucment to a pagesize letter.
            _usermanager = usermanager;                 // Sets the usermanager.
        }

        public void PrintReceipt(List<Item> itemList, Stream filename)
        {
            try
            {
                BaseFont bfTitle = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, false); // Creates a font.
                iTextSharp.text.Font desTitle = new iTextSharp.text.Font(bfTitle, 16);              // Saves the font with size 16.
                PdfWriter.GetInstance(_document, filename); // Gets the instance of the writer.
                Paragraph title = new Paragraph("Receipt", desTitle);  // Creates a paragraph with title and the created font.
                Paragraph totalCost = new Paragraph("Total: " + _usermanager.GetTotalCost().ToString(), desTitle); //Calculates the total cost of the items and prints it at the end of the document.                
                _document.Open();                
                _document.Add(title);  // Adds it to the document.
                foreach (Item item in itemList) 
                {
                    Paragraph p = new Paragraph(item.Name + "  " + item.Price);     //Foreach items in the list it adds a new paragraph with that item.
                    _document.Add(p);
                }
                _document.Add(totalCost);
                _document.Close();
            }
            catch
            {
                throw new ApplicationException();
            }
        }

    }
}
