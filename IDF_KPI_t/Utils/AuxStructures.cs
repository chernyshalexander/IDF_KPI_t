using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_KPI_t.Utils
{
    public struct Terminal
    {
        public const string A = "SVO-A";
        public const string B = "SVO-B";
        public const string C = "SVO-C";
        public const string D = "SVO-D";
        public const string F = "SVO-F";
        public const string E = "SVO-E";
        public const string International = "МВЛ";
        public const string Domestic = "ВВЛ";
    }

    public class ProcResult
    {
        public ProcResult(bool _res, string _msg, string _err,bool _sh)
        {
            Result = _res;
            Error = _err;
            Message = _msg;
            Show = _sh;
        }
        public bool Result;
        public bool Show;
        public string Message;
        public string Error;
    }
}
