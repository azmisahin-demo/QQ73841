using System.Data;

namespace Helper
{
  /// <summary>
  /// 
  /// </summary>
  public class Adaptor
  {

    /// <summary>
    /// Convert Data Table from Martix
    /// </summary>
    /// <param name="matris"></param>
    /// <returns></returns>
    public DataTable ConvertToDataTable(int[,] matris)
    {
      DataTable dataTable = new DataTable();

      // Column
      for (int i = 0; i < matris.GetLength(1); i++)
      {
        dataTable.Columns.Add("Column" + (i + 1));
      }

      // Rows
      for (int i = 0; i < matris.GetLength(0); i++)
      {
        DataRow row = dataTable.NewRow();
        for (int j = 0; j < matris.GetLength(1); j++)
        {
          row[j] = matris[i, j];
        }
        dataTable.Rows.Add(row);
      }

      return dataTable;
    }

  }
}
