using System;
using System.ComponentModel.DataAnnotations;

namespace LCMClient.Features.Orphans.Models
{
    public class AcademicCreationModel
    {
        [MaxLength(30)]
        public string Grade { get; set; }

        [MaxLength(30)]
        public string KCPE { get; set; }
        [MaxLength(30)]
        public string KCSE { get; set; }
        [MaxLength(255)]
        public string School { get; set; }

        [MaxLength(1000)]
        public string PostKCSENotes { get; set; }
        public DateTime EntryDate { get; set; }
        public int OrphanID { get; set; }
    }
}
