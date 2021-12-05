using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MovieInformationRepository.RecordModels
{
    public class Movies
    {
        [Key]
        public long MovieId { get; set; }
        public string MovieName { get; set; }
        public string Plot { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string ProducerName { get; set; }
        public long? ActorId { get; set; }
        public string ActorIds { get; set; }
        public Producers ProducerId { get; set; }
        public ICollection<Actors> ActorsList { get; set; }
    }
}
