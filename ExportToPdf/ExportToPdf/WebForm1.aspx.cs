using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Color = iTextSharp.text.BaseColor;
using Font = iTextSharp.text.Font;

namespace ExportToPdf
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        #region Functions
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataTable MakeDataTable()
        {

            DataTable info = new DataTable();

 
            info.Columns.Add("Attribute");
            info.Columns.Add("Data");
   

            //Populate with infos :)
            info.Rows.Add("Name", "Smithgsdgsdgshgfquiuiofhoqwhouie fh2 hjloqjh eyo12uyhero2edou`1  u1  di  gd1yidg   d 1wgdo1ughfdou1oufwdghqwugo gd");
            info.Rows.Add("Address", "Mohammadpur");
            info.Rows.Add("Mobile Number", "01686512201");
            info.Rows.Add("Email", "mahruj66@gmail.com");
            info.Rows.Add("Office", "Dhaka");
            info.Rows.Add("Bank Account No", "017896532148555");
           

            return info;
        }
#endregion

        #region Events
        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

 
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
           
            Font fntHead = new Font(bfntHead, 16, 1, Color.BLACK);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);


          
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

          
            document.Add(new Chunk("\n", fntHead));

           
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
         
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.BLACK);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = Color.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtbl = MakeDataTable();
                ExportDataTableToPdf(dtbl, @"E:\test.pdf", "Personal Info");
                if (CheckBox1.Checked)
                {
                    System.Diagnostics.Process.Start(@"E:\test.pdf");
                   
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error Message");
            }
        }
        #endregion
    }
}