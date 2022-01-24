using System;

namespace DAW2.Models
{
    public class UserMovieRelation
    {
        public User User { get; set; }

        public Guid UserId { get; set; }

        public Movie Movie { get; set; }

        public Guid MovieId { get; set; }
    }
}
