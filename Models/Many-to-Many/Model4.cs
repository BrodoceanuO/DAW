using DAW2.Models.Base;
using DAW2.Models.One_to_Many;
using System.Collections.Generic;

namespace DAW2.Models.Many_to_Many
{
    public class Model4: BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ModelsRelation> ModelsRelations { get; set; }
    }
}
