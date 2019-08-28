using System.Collections.Generic;
using Domain.Entities;
using Interfaces;
using Service.Interfaces;

namespace Libraries
{
    public class SchoolService:ISchoolService

    {
        public SchoolService(ISchoolRepository repository)
        {
            Repository = repository;
            School = Repository.GetSchool();
        }
        public ISchoolRepository Repository { get; set; }

        public School School { get; }
    }
}