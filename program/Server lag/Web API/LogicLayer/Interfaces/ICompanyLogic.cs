using Domain.Domain.Entities;

namespace LogicLayer.Interfaces;

public interface ICompanyLogic
{
    void CreatePost(JobPost jobPost);
}