using DAW2.Models.Base;
using System;

namespace DAW2.Models.One_to_One
{
    public class Model6: BaseEntity
    {
        public string Name { get; set; }

        public Model5 Model5 { get; set; } 

        public Guid Model5Id { get; set; }
    }
}
