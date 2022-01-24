using DAW2.Models.DTOs;

namespace DAW2.Services
{
    public interface IService
    {
        UserResultDTO GetDataMappedByLastName(string LastName);
    }
}
