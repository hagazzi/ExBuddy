﻿namespace ExBuddy.OrderBotTags.Gather.Rotations
{
	using System.Threading.Tasks;

	using ExBuddy.Attributes;
	using ExBuddy.Interfaces;

	using ff14bot.Managers;

	[GatheringRotation("Collect345", 24)]
	public sealed class Collect345GatheringRotation : CollectableGatheringRotation, IGetOverridePriority
	{
		#region IGetOverridePriority Members

		int IGetOverridePriority.GetOverridePriority(ExGatherTag tag)
		{
			// if we have a collectable && the collectable value is greater than or equal to 345: Priority 345
			if (tag.CollectableItem != null && tag.CollectableItem.Value >= 345)
			{
				return 345;
			}

			return -1;
		}

		#endregion

		public override async Task<bool> ExecuteRotation(ExGatherTag tag)
		{
			await Methodical(tag);
			await Methodical(tag);
			await Methodical(tag);

			await IncreaseChance(tag);

			return true;
		}
	}
}