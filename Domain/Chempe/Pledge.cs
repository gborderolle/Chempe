using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    /// <summary>
    /// Empeño, entidad principal
    /// </summary>
    [Table("Pledge")]
    public class Pledge
    {
        [Key]
        public int Pledge_ID { get; set; }
        
        public int Loan_term { get; set; }
        
        // FK ------------------
        [ForeignKey("Warrant_ID")]
        public Warrant Warrant { get; set; }
        public int? Warrant_ID { get; set; }

        // FK ------------------
        [ForeignKey("Request_ID")]
        public Request Request { get; set; }
        public int? Request_ID { get; set; }

        // FK ------------------
        [ForeignKey("Approval_ID")]
        public Approval Approval { get; set; }
        public int? Approval_ID { get; set; }

        // FK ------------------
        [ForeignKey("Acceptance_ID")]
        public Acceptance Acceptance { get; set; }
        public int? Acceptance_ID { get; set; }

        // FK ------------------
        [ForeignKey("Assignment_ID")]
        public Assignment Assignment { get; set; }
        public int? Assignment_ID { get; set; }

        // FK ------------------
        [ForeignKey("Pledge_status_ID")]
        public Pledge_status Pledge_status { get; set; }
        public int? Pledge_status_ID { get; set; }
        // FK ------------------

        public Pledge()
        {
        }
    }
}
