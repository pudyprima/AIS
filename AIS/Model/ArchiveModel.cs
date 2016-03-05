using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIS.Model
{
    public class ArchiveModel
    {
        public string RegistrationCode { get; set; }
        public string ArchiveType { get; set; }
        public string Applicant { get; set; }
        public string ScannedDocument { get; set; }
        public DateTime EntryDateTime { get; set; }
    }
}
