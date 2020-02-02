using Application.Seedwork;
using Domain.Modules.BlogAgg;
using Domain.Seedwork;

namespace Application.DTO
{
    [AutoInject(typeof(Blog))]
    public class BlogDTO : AuditableDTO
    {
        public string BlogName { get; set; }
    }
}
