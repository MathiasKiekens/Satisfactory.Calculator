using Hyperion.Satisfactory.Models.Items;

namespace Hyperion.Satisfactory.Models.Machines.Base;

public record Recipe(
    int Id,
    string Name,
    Dictionary<int, Material> Input,
    Dictionary<int, Material> Output,
    Machine AllowedMachine
);