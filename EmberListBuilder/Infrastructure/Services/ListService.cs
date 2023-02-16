using EmberListBuilder.Domain.Map;

namespace EmberListBuilder.Infrastructure.Services;

public class ListService : IListService
{
    public List<Mech> MechList { get; set; }

    internal Task InitializeListAsync()
    {
        MechList = new 
            List<Mech>();
        return Task.CompletedTask;
    }
}