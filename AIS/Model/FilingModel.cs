using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIS.Model
{
    public class FilingModel
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public string PIC { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<ArchiveModel> Archives { get; set; }
    }
}
