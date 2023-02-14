using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    // CompanyId parameter in the route
    public record EmployeeForCreationDto(string Name, int Age, string Position);
}
