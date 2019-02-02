using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopick4NDHU
{
    class Record
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public string StudentID { get; set; }
        public string Pwd { get; set; }
        public string SF { get; set; } // Sport field
    }
}
