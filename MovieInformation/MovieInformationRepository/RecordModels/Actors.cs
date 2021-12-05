using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MovieInformationRepository.RecordModels
{
    public class Actors
    {
        [Key]
        public long ActorId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public ICollection<Movies> MoviesList { get; set; }
    }
}
