using EllaManka.Contracts.Requests;
using EllaManka.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EllaManka.Infrastructure.Repositories
{
    public interface IAssignmentRepository
    {
        Task<List<AssignmentDto>> GetAssignmentsAsync(Guid userId, DateTime? day, int? month, int? year);
    }
}