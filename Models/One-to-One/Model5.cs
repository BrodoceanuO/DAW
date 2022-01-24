using DAW2.Models.Base;

namespace DAW2.Models.One_to_One
{
    public class Model5: BaseEntity
    {
        public string Name { get; set; }

        public Model6 Model6 { get; set; }
    }
}
