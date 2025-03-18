using iTextSharp.text.pdf;
using iTextSharp.text;
using Syncfusion.Grouping;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Element = iTextSharp.text.Element;
using System.IO;
using Bengkel_UKK.Admin.Riwayat;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.CustomUI;

namespace Bengkel_UKK.Helper
{
    public class Invoice
    {

        public static void GenerateInvoice(InvoiceModel invoice)
        {
            string fileName = $"Invoice_{invoice.NamaPelanggan}_{invoice.Tanggal:dd-MM-yyyy}.pdf";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            Document doc = new Document(PageSize.A4, 40f, 40f, 40f, 40f);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            AddHeader(doc, invoice);
            AddCustomerInfo(doc, invoice);
            AddInvoiceTable(doc, invoice);
            AddFooter(doc, invoice);

            doc.Close();
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private static void AddHeader(Document doc, InvoiceModel invoice)
        {
            PdfPTable headerTable = new PdfPTable(2) { WidthPercentage = 100 };
            headerTable.SetWidths(new float[] { 30f, 70f });

            if (File.Exists(invoice.LogoPath))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(invoice.LogoPath);
                logo.ScaleToFit(50f, 50f);
                PdfPCell logoCell = new PdfPCell(logo) { Border = iTextSharp.text.Rectangle.NO_BORDER, PaddingBottom = 10f };
                headerTable.AddCell(logoCell);
            }
            else
            {
                headerTable.AddCell(new PdfPCell(new Phrase(" ")) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            }

            PdfPCell invoiceCell = new PdfPCell(new Phrase("INVOICE", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 30, BaseColor.GRAY)))
            {
                HorizontalAlignment = Element.ALIGN_RIGHT,
                Border = iTextSharp.text.Rectangle.NO_BORDER,
                PaddingBottom = 10f
            };
            headerTable.AddCell(invoiceCell);

            doc.Add(headerTable);
        }

        private static void AddCustomerInfo(Document doc, InvoiceModel invoice)
        {
            doc.Add(new Paragraph(invoice.NamaBengkel, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)) { SpacingAfter = 5f });
            doc.Add(new Paragraph(invoice.AlamatBengkel, FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            doc.Add(new Paragraph($"Email: {invoice.EmailBengkel} | Telp: {invoice.TelpBengkel}", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            doc.Add(new Paragraph("------------------------------------------------------", FontFactory.GetFont(FontFactory.HELVETICA, 10)) { SpacingAfter = 10f });

            doc.Add(new Paragraph($"Nomor Antrean: {invoice.Antrean}", FontFactory.GetFont(FontFactory.HELVETICA, 10)) { SpacingAfter = 5f });
            doc.Add(new Paragraph($"Tanggal: {invoice.Tanggal.ToString("d MMMM yyyy", new CultureInfo("id-ID"))}", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            doc.Add(new Paragraph($"Pelanggan: {invoice.NamaPelanggan}", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            doc.Add(new Paragraph($"Kendaraan: {invoice.NamaKendaraan} ({invoice.NoPolisi})", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            doc.Add(new Paragraph($"Mekanik: {invoice.NamaMekanik}", FontFactory.GetFont(FontFactory.HELVETICA, 10))); // Tambahan nama mekanik
            doc.Add(new Paragraph("------------------------------------------------------", FontFactory.GetFont(FontFactory.HELVETICA, 10)) { SpacingAfter = 10f });
        }


        private static void AddInvoiceTable(Document doc, InvoiceModel invoice)
        {
            PdfPTable table = new PdfPTable(4) { WidthPercentage = 100 };
            table.SetWidths(new float[] { 50f, 10f, 20f, 20f });

            BaseColor headerColor = new BaseColor(128, 128, 128);
            iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE);
            iTextSharp.text.Font bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

            string[] headers = { "Barang / Jasa", "Jumlah", "Harga", "Total" };
            foreach (var header in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(header, headerFont))
                {
                    BackgroundColor = headerColor,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    Padding = 5f
                };
                table.AddCell(cell);
            }

            for (int i = 0; i < invoice.ListBarang.Count; i++)
            {
                table.AddCell(new PdfPCell(new Phrase(invoice.ListBarang[i], bodyFont)) { Padding = 5f });
                table.AddCell(new PdfPCell(new Phrase(invoice.ListQuantity[i].ToString(), bodyFont)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5f });
                table.AddCell(new PdfPCell(new Phrase($"Rp {invoice.ListHarga[i]:N0}", bodyFont)) { Padding = 5f });
                table.AddCell(new PdfPCell(new Phrase($"Rp {invoice.ListQuantity[i] * invoice.ListHarga[i]:N0}", bodyFont)) { Padding = 5f });
            }
            doc.Add(table);
            doc.Add(new Paragraph(" "));
        }

        private static void AddFooter(Document doc, InvoiceModel invoice)
        {
            iTextSharp.text.Font footerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            doc.Add(new Paragraph($"TOTAL: Rp {invoice.TotalBiaya:N0}", footerFont) { Alignment = Element.ALIGN_RIGHT, SpacingBefore = 10f });
            doc.Add(new Paragraph($"Catatan: {invoice.Catatan}", FontFactory.GetFont(FontFactory.HELVETICA, 10)) { SpacingBefore = 10f });
        }
        public static void GenerateLaporan(DateTime tanggal_1, DateTime tanggal_2)
        {
            LaporanDal _laporanDal = new LaporanDal();

            var laporan = _laporanDal.ListLaporan(tanggal_1, tanggal_2).ToList();
            if (laporan.Count == 0 || laporan == null)
            {
                PesanBox.Error($"Mohon maaf \nTidak ada data pada rentang tanggal \"{tanggal_1.ToString("dd-MM-yyyy")}\" - \"{tanggal_2.ToString("dd-MM-yyyy")}\". \nSilakan pilih tanggal yang lain.");
                return;
            }


            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Laporan Riwayat Servis");

                worksheet.Cell(1, 1).Value = $"Rentang Tanggal : {tanggal_1.ToString("dd-MMMM-yyyy")} - {tanggal_2.ToString("dd-MMMM-yyyy")}";

                // Header
                worksheet.Cell(2, 1).Value = "Tanggal";
                worksheet.Cell(2, 2).Value = "No KTP Pelanggan";
                worksheet.Cell(2, 3).Value = "Nama Pelanggan";
                worksheet.Cell(2, 4).Value = "Nama Kendaraan";
                worksheet.Cell(2, 5).Value = "Nama Petugas";
                worksheet.Cell(2, 6).Value = "Nama Mekanik";
                worksheet.Cell(2, 7).Value = "Jasa Servis";
                worksheet.Cell(2, 8).Value = "Nama Sparepart";
                worksheet.Cell(2, 9).Value = "Keluhan";
                worksheet.Cell(2, 10).Value = "Catatan";
                worksheet.Cell(2, 11).Value = "Total Biaya";
                worksheet.Cell(2, 12).Value = "Status";

                int row = 3;

                foreach (var item in laporan)
                {
                    int statusInt = 0; 
                    int.TryParse(item.status, out statusInt);

                    worksheet.Cell(row, 1).Value = item.tanggal;
                    worksheet.Cell(row, 2).Value = item.ktp_pelanggan ?? "[Tamu]";
                    worksheet.Cell(row, 3).Value = item.nama_pelanggan;
                    worksheet.Cell(row, 4).Value = item.nama_kendaraan;
                    worksheet.Cell(row, 5).Value = item.nama_petugas;
                    worksheet.Cell(row, 6).Value = item.nama_mekanik;
                    worksheet.Cell(row, 7).Value = item.jasa_servis;
                    worksheet.Cell(row, 8).Value = item.nama_sparepart;
                    worksheet.Cell(row, 9).Value = item.keluhan;
                    worksheet.Cell(row, 10).Value = item.catatan;
                    worksheet.Cell(row, 11).Value = $"Rp{item.total_harga:N0}";
                    worksheet.Cell(row, 12).Value = int.TryParse(item.status ?? "0", out int status) && status == 1 ? "Dibatalkan" : "Selesai";


                    row++;
                }

                decimal totalPendapatan = laporan.Sum(item => item.total_harga);

                // Tambahkan total pendapatan di baris terakhir
                row++;
                worksheet.Cell(row, 10).Value = "Total Pendapatan Servis:";
                worksheet.Cell(row, 11).Value = $"Rp{totalPendapatan:N0}";

                // Membuat  style tabel nya
                var range = worksheet.Range(2, 1, row - 1, 12);
                var table = range.CreateTable();
                table.Theme = XLTableTheme.TableStyleLight10;

                // untuk menyesuaikan ukuran kolom secara otomatis
                worksheet.Columns().AdjustToContents();

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Simpan Laporan",
                    FileName = $"Laporan_Riwayat_Servis_{tanggal_1:dd-MM-yyyy}_{tanggal_2:dd-MM-yyyy}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                }
            }
        }
    }

    public class InvoiceModel
    {
        public string LogoPath { get; set; } = @"D:\UKK\Bengkel_UKK\Bengkel_UKK\Asset\logo.png";
        public string NamaBengkel { get; set; } = "TECHNO GARAGE";
        public string AlamatBengkel { get; set; } = "Jl. Mawar No. 50, Gempolan";
        public string EmailBengkel { get; set; } = "technogarage@gmail.com";
        public string TelpBengkel { get; set; } = "08123456789";
        public string NamaMekanik { get; set; } = "John Doe"; // Nama mekanik default


        public string Antrean { get; set; } = "A123";
        public DateTime Tanggal { get; set; } = DateTime.Now;
        public string NamaPelanggan { get; set; } = "Budi Santoso";
        public string NamaKendaraan { get; set; } = "Toyota Avanza";
        public string NoPolisi { get; set; } = "B 1234 XYZ";
        public string NomorInvoice { get; set; } = "BKGA1332";

        public List<string> ListBarang { get; set; } = new List<string> { "Servis Rutin", "Oli Mesin", "Filter Udara" };
        public List<int> ListQuantity { get; set; } = new List<int> { 1, 1, 1 };
        public List<int> ListHarga { get; set; } = new List<int> { 250000, 75000, 50000 };

        public string Catatan { get; set; } = "Terima kasih telah menggunakan layanan kami.";

        public int TotalBiaya => HitungTotal();

        private int HitungTotal()
        {
            int total = 0;
            for (int i = 0; i < ListBarang.Count; i++)
            {
                total += ListQuantity[i] * ListHarga[i];
            }
            return total;
        }
    }

}
