using System;
using Excel;
using System.IO;
using System.Data;

namespace IDF_KPI_t.Utils
{
    interface IPassTrafficProvider
    {

        bool VerifySource();
        DateTime GetFirstDate();
        DateTime GetLastDate();
        int GetTraffic(string terminal, string flightGroup);
    }

    class DailyPassTrafficProvider : IPassTrafficProvider
    {
        private const int dateCol = 4;
        private const int dateRow = 0;
        private const int headerRow = 3;
        private const int vpoHeaderRow = 41;

        private const int termNameCol = 1;
        private const int passCol = 4;

        private const int AmvlCol = 2;
        private const int AmvlRow = 43;

        private const int DvvlRow = 13;
        private const int DmvlRow = 19;
        private const int EmvlRow = 25;
        private const int FmvlRow = 31;

        private DataTable tbl0;
        //private int RowCount;
        //private int ColCount;

        public DailyPassTrafficProvider(string filePath)
        {
            try
            {
                FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                excelReader.IsFirstRowAsColumnNames = false;
                DataSet result = excelReader.AsDataSet();
                tbl0 = result.Tables[0];
                //ColCount = tbl0.Columns.Count;
                //RowCount = tbl0.Rows.Count;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DateTime GetFirstDate()
        {
            return Convert.ToDateTime(tbl0.Rows[dateRow][dateCol].ToString());
            // throw new NotImplementedException();
        }

        public DateTime GetLastDate()
        {
            return Convert.ToDateTime(tbl0.Rows[dateRow][dateCol].ToString());
            //throw new NotImplementedException();
        }

        public int GetTraffic(string terminal, string flightGroup)
        {
            switch (terminal)
            {
                case "SVO-A": return Convert.ToInt32(tbl0.Rows[AmvlRow][AmvlCol].ToString());
                case "SVO-F": return Convert.ToInt32(tbl0.Rows[FmvlRow][passCol].ToString());
                case "SVO-E": return Convert.ToInt32(tbl0.Rows[EmvlRow][passCol].ToString()); ;
                case "SVO-D":
                    if (flightGroup == "МВЛ") { return Convert.ToInt32(tbl0.Rows[DmvlRow][passCol].ToString()); }
                    else { return Convert.ToInt32(tbl0.Rows[DvvlRow][passCol].ToString()); }
                default: return 0;
            }
        }

        public bool VerifySource()
        {
            try
            {
                bool tblName = tbl0.TableName == "Ежедневный отчет";
                bool dateName = tbl0.Rows[dateRow][termNameCol].ToString() == "Ежедневный отчет за";
                bool passHeader = tbl0.Rows[headerRow][passCol].ToString() == "Пасс";
                bool vpoHeader = tbl0.Rows[vpoHeaderRow][AmvlCol].ToString() == "ВПО";
                bool DMVL = tbl0.Rows[DmvlRow][termNameCol].ToString() == "D МBЛ";
                bool DVVL = tbl0.Rows[DvvlRow][termNameCol].ToString() == "D BBЛ";
                bool EMVL = tbl0.Rows[EmvlRow][termNameCol].ToString() == "E";
                bool FMVL = tbl0.Rows[FmvlRow][termNameCol].ToString() == "F";
                bool AMVL = tbl0.Rows[AmvlRow][termNameCol].ToString() == "Бизнес-авиация";

                return tblName && dateName && passHeader && vpoHeader && DMVL && DVVL && EMVL && FMVL && AMVL;
            }
            catch (Exception)
            {
                return false;
            }


            //throw new NotImplementedException();
        }
    }
}
