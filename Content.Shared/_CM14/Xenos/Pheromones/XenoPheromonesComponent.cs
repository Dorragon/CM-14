﻿using Robust.Shared.GameStates;

namespace Content.Shared._CM14.Xenos.Pheromones;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedXenoPheromonesSystem))]
public sealed partial class XenoPheromonesComponent : Component
{
    [DataField, AutoNetworkedField]
    public XenoPheromones Pheromones;
}