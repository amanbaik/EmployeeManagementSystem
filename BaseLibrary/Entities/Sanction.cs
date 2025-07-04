﻿using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities
{
    public class Sanction : OtherEntityBase
    {
        [Required]
        public DateTime Date{ get; set; }
        [Required]
        public string Punishment { get; set; } = string.Empty;
        [Required]
        public DateTime PunishmentDate { get; set; }

        //Many to one relationship with SanctionType
        public SanctionType? SanctionType { get; set; }
    }
}
