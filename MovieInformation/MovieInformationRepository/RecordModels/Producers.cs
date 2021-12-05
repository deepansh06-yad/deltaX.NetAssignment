using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieInformationRepository.RecordModels
{
    public class Producers
    {
        [Key]
        public long ProducerId { get; set; }
        public string ProduceName { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string ProductionHouseName { get; set; }
        public Movies MovieId { get; set; }
        public ICollection<Movies> MoviesList { get; set; }
    }
}
