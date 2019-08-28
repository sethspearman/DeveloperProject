using Domain.Entities;
using Interfaces;

namespace Service.Interfaces
{
    public interface ISchoolService
    {
        ISchoolRepository Repository { get; set; }
        School School { get; }
    }
}