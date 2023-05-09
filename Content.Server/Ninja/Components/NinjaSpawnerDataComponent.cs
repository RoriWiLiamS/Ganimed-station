using Content.Server.Ninja.Systems;

namespace Content.Server.Ninja.Components;

/// <summary>
/// Used by space ninja spawner to indicate what station grid to head towards.
/// </summary>
[RegisterComponent, Access(typeof(NinjaSystem))]
public sealed class NinjaSpawnerDataComponent : Component
{
    /// <summary>
    /// The grid uid being targeted.
    /// </summary>
    public EntityUid Grid;
}
