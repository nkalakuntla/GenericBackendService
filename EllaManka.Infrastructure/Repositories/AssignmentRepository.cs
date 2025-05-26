using EllaManka.Contracts.Responses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EllaManka.Infrastructure.Data;

namespace EllaManka.Infrastructure.Repositories
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly ApplicationDbContext _context;

        public AssignmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<AssignmentDto>> GetAssignmentsAsync(Guid userId, DateTime? day, int? month, int? year)
        {
            var query = _context.Assignments.AsQueryable();

            query = query.Where(a => a.UserId == userId);

            if (day.HasValue)
            {
                // Filter for the specific day
                var targetDay = day.Value.Date;
                query = query.Where(a => a.AssignedDate.Date == targetDay);
            }
            else if (month.HasValue && year.HasValue)
            {
                // Filter for the given month and year
                query = query.Where(a => a.AssignedDate.Month == month && a.AssignedDate.Year == year);
            }

            return await query
                .Select(a => new AssignmentDto
                {
                    Id = a.Id,
                    UserId = a.UserId,
                    Title = a.Title,
                    Description = a.Description,
                    AssignedDate = a.AssignedDate,
                    DueDate = a.DueDate
                    // Map other properties as needed
                })
                .ToListAsync();
        }
    }
}