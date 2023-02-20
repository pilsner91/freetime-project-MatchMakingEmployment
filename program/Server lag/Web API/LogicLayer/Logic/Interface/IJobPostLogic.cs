using Domain.Domain.Entities;

namespace LogicLayer.Logic.Interface;

public interface IJobPostLogic
{
    void CreatePosting(JobPost jobPost);
}