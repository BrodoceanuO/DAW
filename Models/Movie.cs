using DAW2.Models.Base;
using System.Collections.Generic;

namespace DAW2.Models
{
    public class Movie: BaseEntity
    {

        public string Title {  get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        public ICollection<UserMovieRelation> UserMovieRelations { get; set; }
    }
}
