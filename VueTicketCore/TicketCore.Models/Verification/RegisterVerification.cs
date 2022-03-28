﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketCore.Models.Verification
{
    [Table("RegisterVerification")]
    public class RegisterVerification
    {
        [Key]
        public long RegisterVerificationId { get; set; }
        public string GeneratedToken { get; set; }
        public DateTime? GeneratedDate { get; set; }
        public bool VerificationStatus { get; set; }
        public bool Status { get; set; }
        public long UserId { get; set; }
        public DateTime? VerificationDate { get; set; }
    }
}