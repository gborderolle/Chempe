using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    /// <summary>
    /// Empeño, entidad principal
    /// </summary>
    public class Pledge
    {
        [Key]
        public int Pledge_ID { get; set; }
        [ForeignKey("Warrant_ID")]
        public Warrant Warrant { get; set; }
        [ForeignKey("Request_ID")]
        public Request Request { get; set; }
        [ForeignKey("Approval_ID")]
        public Approval Approval { get; set; }
        [ForeignKey("Assignment_ID")]
        public Assignment Assignment { get; set; }
        [ForeignKey("Pledge_status_ID")]
        public Pledge_status Pledge_status { get; set; }
        public int Loan_term { get; set; }

    }
}
