using ClosedXML.Excel;

namespace GobData
{
    public class ExportadorExcel
    {
        public void ExportToExcel(DataGridView dgv, string nombreArchivo)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Datos");

                // Encabezados
                for (int i = 1; i <= dgv.Columns.Count; i++)
                {
                    worksheet.Cell(1, i).Value = dgv.Columns[i - 1].HeaderText;
                }

                // Filas
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int s = 0; s < dgv.Columns.Count; s++)
                    {
                        worksheet.Cell(i + 2, s + 1).Value = dgv.Rows[i].Cells[s].Value?.ToString();
                    }
                }

                // Guardar archivo
                workbook.SaveAs(nombreArchivo);
            }
        }
    }
}
