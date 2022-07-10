using Business.Service;
using Dto.Model;
using Gridify;

namespace Business.Interface;
public interface IFestivalService
{
    Task<ServiceResponse<List<FestivalDto>>> GetFestivalsAsync(GridifyQuery gQuery, CancellationToken token);
    Task<ServiceResponse<FestivalDto>> GetFestivalAsync(int id, CancellationToken token);
    Task<ServiceResponse<int>> CreateFestivalAsync(FestivalDto dto, CancellationToken token);
    Task<ServiceResponse<int>> UpdateFestivalAsync(int id, FestivalDto dto, CancellationToken token);
    Task<ServiceResponse<object>> DeleteFestivalAsync(int id, CancellationToken token);
}
