using libF1Locations;
using System;

namespace F1LiveTiming.Data
{
	public record CountryData
	{
		public byte Key { get; init; }
		public string Code { get; init; }
		public string Name { get; init; }

		public CountryData(CountryList key)
		{
			Key = (byte)key;

			switch (key)
			{
				case CountryList.Spain:
					Code = "ESP";
					Name = "Spain";
					break;
				case CountryList.GreatBritain:
					Code = "GBR";
					Name = "Great Britain";
					break;
				case CountryList.Japan:
					Code = "JPN";
					Name = "Japan";
					break;
				case CountryList.Australia:
					Code = "AUS";
					Name = "Australia";
					break;
				case CountryList.Mexico:
					Code = "MEX";
					Name = "Mexico";
					break;
				case CountryList.Brazil:
					Code = "BRA";
					Name = "Brazil";
					break;
				case CountryList.Italy:
					Code = "ITA";
					Name = "Italy";
					break;
				case CountryList.Hungary:
					Code = "HUN";
					Name = "Hungary";
					break;
				case CountryList.Belgium:
					Code = "BEL";
					Name = "Belgium";
					break;
				case CountryList.Austria:
					Code = "AUT";
					Name = "Austria";
					break;
				case CountryList.UnitedStates:
					Code = "USA";
					Name = "United States";
					break;
				case CountryList.UnitedArabEmirates:
					Code = "UAE";
					Name = "United Arab Emirates";
					break;
				case CountryList.Azerbaijan:
					Code = "AZE";
					Name = "Azerbaijan";
					break;
				case CountryList.Bahrain:
					Code = "BRN";
					Name = "Bahrain";
					break;
				case CountryList.Canada:
					Code = "CAN";
					Name = "Canada";
					break;
				case CountryList.China:
					Code = "CHN";
					Name = "China";
					break;
				case CountryList.Monaco:
					Code = "MON";
					Name = "Monaco";
					break;
				case CountryList.Netherlands:
					Code = "NED";
					Name = "Netherlands";
					break;
				case CountryList.Qatar:
					Code = "QAT";
					Name = "Qatar";
					break;
				case CountryList.SaudiArabia:
					Code = "KSA";
					Name = "Saudi Arabia";
					break;
				case CountryList.Singapore:
					Code = "SGP";
					Name = "Singapore";
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(key));
			}
		}
	}
}
