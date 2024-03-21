using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Route.C41.G03.DAL.models;

namespace Route.C41.G03.DAL.data
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}