using System;
using System.Collections.Generic;
using AIS.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace AIS
{
    public static class Program
    {
        public static ObservableCollection<ArchiveModel> archives = new ObservableCollection<ArchiveModel>();
        public static ObservableCollection<FilingModel> filings = new ObservableCollection<FilingModel>();
        public static List<string> archiveTypes = new List<string>();
        public static List<string> filingTypes = new List<string>();

        public static void Init()
        {
            archiveTypes = new List<string>()
            {
                "Opex",
                "Capex",
                "Tanah",
                "Proyek",
                "PPL",
                "POP",
                "PR Deleted",
                "Lainnya"
            };

            filingTypes = new List<string>()
            {
                "Dokumen Tender",
                "TOR",
                "ECE",
                "Usulan Penawaran",
                "AANWIZJING",
                "Penawaran",
                "Rekap Penawaran",
                "Evaluasi Teknis",
                "Negosiasi",
                "OP",
                "Pembayaran",
                "Perpanjangan"
            };

            ArchiveModel archive1 = new ArchiveModel()
            {
                RegistrationCode = "Arsip01",
                ArchiveType = archiveTypes[0],
                Applicant = "IlyasJelek",
                ScannedDocument = "File1.docx",
                EntryDateTime = new DateTime(2016, 01, 01)
            };

            ArchiveModel archive2 = new ArchiveModel()
            {
                RegistrationCode = "Arsip02",
                ArchiveType = archiveTypes[1],
                Applicant = "IlyasJelek2",
                ScannedDocument = "File2.docx",
                EntryDateTime = new DateTime(2016, 01, 11)
            };

            ArchiveModel archive3 = new ArchiveModel()
            {
                RegistrationCode = "Arsip03",
                ArchiveType = archiveTypes[2],
                Applicant = "IlyasJelek3",
                ScannedDocument = "File3.pdf",
                EntryDateTime = new DateTime(2016, 01, 11)
            };

            archives = new ObservableCollection<ArchiveModel>()
            {
                archive1,
                archive2,
                archive3
            };

            filings = new ObservableCollection<FilingModel>() 
            {
                new FilingModel()
                {
                    Code = "Berkas01",
                    Type = filingTypes[0],
                    PIC = "Ilyas",
                    CreatedDate = new DateTime(2016, 02, 02),
                    Archives = new List<ArchiveModel>(){archive1, archive2}
                },
                new FilingModel()
                {
                    Code = "Berkas02",
                    Type = filingTypes[1],
                    PIC = "Ilyas Lagi",
                    CreatedDate = new DateTime(2016, 02, 12),
                    Archives = new List<ArchiveModel>(){archive1, archive3}
                },
                new FilingModel()
                {
                    Code = "Berkas03",
                    Type = filingTypes[2],
                    PIC = "Ilyas Aja Terus",
                    CreatedDate = new DateTime(2016, 02, 16),
                    Archives = new List<ArchiveModel>(){archive2, archive3}
                }
            };
        }

        public static void AddArchive(ArchiveModel archive)
        {
            archives.Add(archive);
        }

        public static void AddFiling(FilingModel filing)
        {
            filings.Add(filing);
        }

        public static void DeleteFiling(FilingModel filing)
        {
            filings.Remove(filing);
        }

        public static void DeleteArchive(ArchiveModel archive)
        {
            archives.Remove(archive);
            foreach(FilingModel filing in filings)
            {
                filing.Archives.Remove(archive);
            }
        }

        public static void UpdateFiling(FilingModel filing)
        {
            FilingModel updateFilling = filings.SingleOrDefault(x => x.Code == filing.Code);
            updateFilling.Archives = filing.Archives;
            updateFilling.PIC = filing.PIC;
            updateFilling.Type = filing.Type;
        }

        public static void UpdateArchive(ArchiveModel archive)
        {
            ArchiveModel updateArchive = archives.SingleOrDefault(x => x.RegistrationCode == archive.RegistrationCode);
            updateArchive.Applicant = archive.Applicant;
            updateArchive.ArchiveType = archive.ArchiveType;
            updateArchive.ScannedDocument = archive.ScannedDocument;
        }
    }
}
