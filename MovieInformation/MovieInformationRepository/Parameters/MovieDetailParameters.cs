using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationRepository.Parameters
{
    public class MovieDetailParameters
    {
        public long MovieId { get; set; }
        public string MovieName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Plot { get; set; }
        public string Producer { get; set; }
        public string ActorIds { get; set; }
        public string ProducerId { get; set; }
    }
}
