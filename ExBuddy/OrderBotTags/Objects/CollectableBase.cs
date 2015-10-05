﻿namespace ExBuddy.OrderBotTags.Objects
{
	using Clio.XmlEngine;

	using ExBuddy.Interfaces;

	public abstract class CollectableBase : INamedItem
	{
		[XmlAttribute("Name")]
		public string Name { get; set; }

		[XmlAttribute("Value")]
		public int Value { get; set; }

		public override string ToString()
		{
			return this.DynamicToString();
		}
	}
}