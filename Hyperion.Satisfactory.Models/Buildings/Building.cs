namespace Hyperion.Satisfactory.Models.Buildings;

public class Building
{
    public IEnumerable<Floor> Floors { get; set; } = Enumerable.Empty<Floor>();
}