using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Models
{
    [Table("BANK_NARRATIVES")]
    public class BankNarratives
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("REPORT_ID")]
        public int ReportId { get; set; }

        [Column("BANK_NARRATIVES")]
        [MaxLength(19000)]
        public string BankNarrative { get; set; }

        [Column("CREATE_USER_ID")]
        public int? CreateUserId { get; set; }

        [Column("CREATE_TIMESTAMP")]
        public DateTime? CreateTimestamp { get; set; }

        [Column("MODIFIED_USER_ID")]
        public int? ModifiedUserId { get; set; }

        [Column("MODIFIED_TIMESTAMP")]
        public DateTime? ModifiedTimestamp { get; set; }
    }
}