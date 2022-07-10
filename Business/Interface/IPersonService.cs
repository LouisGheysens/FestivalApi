using Business.Service;
using Dto.Model;
using Gridify;

namespace Business.Interface;
public interface IPersonService
{
    Task<ServiceResponse<List<PersonDto>>> GetPersonsAsync(GridifyQuery gQuery, CancellationToken token);
    Task<ServiceResponse<PersonDto>> GetPersonAsync(int id, CancellationToken token);
    Task<ServiceResponse<int>> CreatePersonAsync(PersonDto dto, CancellationToken token);
    Task<ServiceResponse<int>> UpdatePersonAsync(int id, PersonDto dto, CancellationToken token);
    Task<ServiceResponse<object>> DeletePersonAsync(int id, CancellationToken token);
}
