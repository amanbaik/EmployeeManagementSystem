﻿using System.ComponentModel.DataAnnotations;
namespace BaseLibrary.Entities
{
    public class Vacation : OtherEntityBase
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int NumberOfDays { get; set; }
        public DateTime EndDate => StartDate.AddDays(NumberOfDays);

        // Many to one relationship with VacationType
        public VacationType? VacationType { get; set; }

        [Required]
        public int VacationTypeId { get; set; }
    }
}
