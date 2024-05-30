using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Windows.Forms;
namespace ShipmentTracking.Utilities
{
    public class PDFGenerator
    {
        public void GenerateShipmentReport(DataGridView dgv)
        {
            string pdfPath = "../../Reports/Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

            using (PdfWriter writer = new PdfWriter(pdfPath))
            {
                PdfDocument pdf = new PdfDocument(writer);
                pdf.SetDefaultPageSize(PageSize.A4.Rotate());

                using (Document document = new Document(pdf))
                {
                    // Header Table
                    float[] headerColumnWidths = { 1, 3, 1 };
                    Table headerTable = new Table(UnitValue.CreatePercentArray(headerColumnWidths))
                        .UseAllAvailableWidth();

                    // Logo
                    Image logo = new Image(ImageDataFactory.Create("../../StaticFiles/duraplayLogo.png"));
                    logo.SetWidth(135);
                    logo.SetHeight(50);
                    Cell logoCell = new Cell().Add(logo).SetBorder(Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                    headerTable.AddCell(logoCell);

                    // Title
                    Paragraph title = new Paragraph("Shipment Report")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(16);
                    Cell titleCell = new Cell().Add(title).SetBorder(Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                    headerTable.AddCell(titleCell);

                    // Date
                    Paragraph date = new Paragraph(DateTime.Now.ToString("dd/MM/yyyy"))
                        .SetTextAlignment(TextAlignment.RIGHT);
                    Cell dateCell = new Cell().Add(date).SetBorder(Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
                    headerTable.AddCell(dateCell);

                    document.Add(headerTable);

                    // Sección 1: Información General
                    AddShipmentInfoSection(document, dgv);

                    // Sección 2: Detalles del Cliente y Entrega
                    AddCustomerDeliverySection(document, dgv);

                    // Sección 3: Información de Envío
                    AddShippingInfoSection(document, dgv);

                    document.Close();
                }
            }
        }

        private void AddShipmentInfoSection(Document document, DataGridView dgv)
        {
            Paragraph sectionTitle = new Paragraph("General Information")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12)
                .SetBold();
            document.Add(sectionTitle);

            float[] columnWidths = { 0.5f, 1, 2, 2, 2, 2 };
            Table table = new Table(UnitValue.CreatePercentArray(columnWidths))
                .UseAllAvailableWidth();

            string[] headers = { " ", "Invoice", "Invoice Date", "# Bol", "Purchase Order", "Purchase Order"};
            foreach (string header in headers)
            {
                table.AddHeaderCell(new Cell().Add(new Paragraph(header).SetFontSize(10).SetBold()));
            }

            Int16 i = 1;
            bool alternate = false;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                Color bgColor = alternate ? ColorConstants.LIGHT_GRAY : ColorConstants.WHITE;
                table.AddCell(new Cell().Add(new Paragraph(i.ToString()).SetFontSize(10).SetBold().SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph(row.Cells["Invoice"].Value?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph(((DateTime)row.Cells["InvoiceDate"].Value).ToString("dd/MM/yyyy")).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph(row.Cells["Bol"].Value?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph(row.Cells["PurchaseOrder"].Value?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph(row.Cells["PurchaseOrder2"].Value?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));

                i++;
                alternate = !alternate;
            }

            document.Add(table);
        }

        private void AddCustomerDeliverySection(Document document, DataGridView dgv)
        {
            Paragraph sectionTitle = new Paragraph("Customer details and delivery")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12)
                .SetBold();
            document.Add(sectionTitle);

            float[] columnWidths = { 0.5f, 2, 2 };
            Table table = new Table(UnitValue.CreatePercentArray(columnWidths))
                .UseAllAvailableWidth();

            string[] headers = { " ", "Customer", "Ship To" };
            foreach (string header in headers)
            {
                table.AddHeaderCell(new Cell().Add(new Paragraph(header).SetFontSize(10).SetBold()));
            }
            
            Int16 i = 1;
            bool alternate = false;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                Color bgColor = alternate ? ColorConstants.LIGHT_GRAY : ColorConstants.WHITE;
                table.AddCell(new Cell().Add(new Paragraph(i.ToString()).SetFontSize(10).SetBold().SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph((row.Cells["CustomerName"].Value)?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph((row.Cells["DeliveryPlaceName"].Value)?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));

                i++;
                alternate = !alternate;
            }

            document.Add(table);
        }

        private void AddShippingInfoSection(Document document, DataGridView dgv)
        {
            Paragraph sectionTitle = new Paragraph("Shipment details")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12)
                .SetBold();
            document.Add(sectionTitle);

            float[] columnWidths = { 0.5f, 2, 1, 2, 1, 2, 1, 1, 1 };
            Table table = new Table(UnitValue.CreatePercentArray(columnWidths))
                .UseAllAvailableWidth();

            string[] headers = { " ", "Material", "Quantity", "Carrier", "Driver", "# Platforma Caja", "Ship Date", "Quantity", "OTD" };
            foreach (string header in headers)
            {
                table.AddHeaderCell(new Cell().Add(new Paragraph(header).SetFontSize(10).SetBold()));
            }

            Int16 i = 1;
            bool alternate = false; 
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                Color bgColor = alternate ? ColorConstants.LIGHT_GRAY : ColorConstants.WHITE;
                table.AddCell(new Cell().Add(new Paragraph(i.ToString()).SetFontSize(10).SetBold().SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph((row.Cells["MaterialDescription"].Value)?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph(row.Cells["Quantity"].Value?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph((row.Cells["CarrierName"].Value)?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph((row.Cells["DriverName"].Value)?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph((row.Cells["PlatformBox"].Value)?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph(((DateTime)row.Cells["ShipDate"].Value).ToString("dd/MM/yyyy")).SetFontSize(10).SetBackgroundColor(bgColor)));
                table.AddCell(new Cell().Add(new Paragraph(row.Cells["Quantity2"].Value?.ToString()).SetFontSize(10).SetBackgroundColor(bgColor)));

                if (((DateTime)row.Cells["DeliveryDate"].Value).ToString("dd/MM/yyyy") == "01/01/2099")
                {
                    table.AddCell(new Cell().Add(new Paragraph("Not delivered yet").SetFontSize(10).SetBackgroundColor(bgColor)));
                }
                else
                {
                    table.AddCell(new Cell().Add(new Paragraph(((DateTime)row.Cells["DeliveryDate"].Value).ToString("dd/MM/yyyy")).SetFontSize(10).SetBackgroundColor(bgColor)));
                }

                i++;
                alternate = !alternate;
            }

            document.Add(table);
        }
    }
}
