namespace Hyperion.Satisfactory.Models.Machines.Base;

public abstract class Machine (int id, double powerConsumption)
{
    private readonly double _basePowerConsumption = powerConsumption;
    public required int Id { get; init; } = id;
    public double ClockSpeed { get; set; } = 1.0;
    public double PowerConsumption { get => _basePowerConsumption * ClockSpeed; }
    public Recipe? Recipe { get; set; }
}