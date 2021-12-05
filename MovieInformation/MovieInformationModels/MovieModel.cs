using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationModels
{
    public class MovieModel
    {
        public long MovieId { get; set; }
        public string MovieName { get; set; }
        public string Plot { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string ProducerName { get; set; }
        public long? ActorId { get; set; }
        public string ActorIds { get; set; }
    }
}
