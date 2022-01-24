using DAW2.Models.Many_to_Many;
using System;

namespace DAW2.Models.One_to_Many
{
    public class ModelsRelation
    {
        public Guid Model3Id { get; set; }
        public Model3 Model3 { get; set; }
        public Guid Model4Id { get; set; }
        public Model4 Model4 { get; set; }

    }
}
