﻿namespace NGrib.Sections.Templates.GridDefinitionTemplates
{
	public class StretchedRotatedGaussianLatLonGridDefinition : RotatedGaussianLatLonGridDefinition
	{
		/// <summary> .</summary>
		/// <returns> PoleLat as a float
		/// 
		/// </returns>
		public float PoleLat { get; }

		/// <summary> .</summary>
		/// <returns> PoleLon as a float
		/// 
		/// </returns>
		public float PoleLon { get; }

		/// <summary> .</summary>
		/// <returns> Factor as a float
		/// 
		/// </returns>
		public long Factor { get; }

		internal StretchedRotatedGaussianLatLonGridDefinition(BufferedBinaryReader reader) : base(reader)
		{
			PoleLat = reader.ReadUInt32() * Ratio;
			PoleLon = reader.ReadUInt32() * Ratio;
			Factor = reader.ReadUInt32();
		}
	}
}