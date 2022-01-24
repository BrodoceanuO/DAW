using DAW2.Models.Base;
using System;

namespace DAW2.Models.One_to_Many
{
    public class Model2: BaseEntity
    {
        string Name { get; set; }

        public Model1 Model1 { get; set; }

        public Guid Model1Id { get; set; }
    }
}
