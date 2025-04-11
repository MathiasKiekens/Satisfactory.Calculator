using Hyperion.Satisfactory.Models.Machines.Base;

namespace Hyperion.Satisfactory.Models.Buildings;

public class Floor
{
    public IEnumerable<IEnumerable<Machine>> Machines { get; set; } = Enumerable.Empty<IEnumerable<Machine>>();
}