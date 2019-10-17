﻿using UnityEngine;

namespace Lazlo.Recs.Examples.Zones
{
	public interface IZone : IComponent
	{
		// Attributes
		string requiredTag { get; }

		// Events
		Event<GameObject> onEnter { get; }
		Event<GameObject> onExit { get; }
	}
}