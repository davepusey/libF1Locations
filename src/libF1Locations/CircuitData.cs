using libF1Locations;
using System;

namespace F1LiveTiming.Data
{
	public record CircuitData
	{
		public byte Key { get; init; }
		public string ShortName { get; init; }
		public TimeZoneInfo TimeZone { get; init; }
		public Uri Flag { get; init; }

        public CircuitData(CircuitList key)
        {
            Key = (byte)key;

			switch (key)
			{
				case CircuitList.Silverstone:
					ShortName = "Silverstone";
					TimeZone = libF1Locations.TimeZone.Get("Europe/London");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/a/a5/Flag_of_the_United_Kingdom_%281-2%29.svg");
					break;
				case CircuitList.Hungaroring:
					ShortName = "Hungaroring";
					TimeZone = libF1Locations.TimeZone.Get("Europe/Budapest");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/c/c1/Flag_of_Hungary.svg");
					break;
				case CircuitList.Imola:
					ShortName = "Imola";
					TimeZone = libF1Locations.TimeZone.Get("Europe/San_Marino");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/b/b1/Flag_of_San_Marino.svg");
					break;
				case CircuitList.SpaFrancorchamps:
					ShortName = "Spa-Francorchamps";
					TimeZone = libF1Locations.TimeZone.Get("Europe/Brussels");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/6/65/Flag_of_Belgium.svg");
					break;
				case CircuitList.Austin:
					ShortName = "Austin";
					TimeZone = libF1Locations.TimeZone.Get("America/Chicago");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/a/a9/Flag_of_the_United_States_%28DoS_ECA_Color_Standard%29.svg");
					break;
				case CircuitList.Melbourne:
					ShortName = "Melbourne";
					TimeZone = libF1Locations.TimeZone.Get("Australia/Melbourne");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/8/88/Flag_of_Australia_%28converted%29.svg");
					break;
				case CircuitList.Interlagos:
					ShortName = "Interlagos";
					TimeZone = libF1Locations.TimeZone.Get("America/Sao_Paulo");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/0/05/Flag_of_Brazil.svg");
					break;
				case CircuitList.Catalunya:
					ShortName = "Catalunya";
					TimeZone = libF1Locations.TimeZone.Get("Europe/Madrid");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/8/89/Bandera_de_Espa%C3%B1a.svg");
					break;
				case CircuitList.Spielberg:
					ShortName = "Spielberg";
					TimeZone = libF1Locations.TimeZone.Get("Europe/Vienna");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/4/41/Flag_of_Austria.svg");
					break;
				case CircuitList.MonteCarlo:
					ShortName = "Monte Carlo";
					TimeZone = libF1Locations.TimeZone.Get("Europe/Monaco");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/e/ea/Flag_of_Monaco.svg");
					break;
				case CircuitList.Montreal:
					ShortName = "Montreal";
					TimeZone = libF1Locations.TimeZone.Get("America/Toronto");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/d/d9/Flag_of_Canada_%28Pantone%29.svg");
					break;
				case CircuitList.Monza:
					ShortName = "Monza";
					TimeZone = libF1Locations.TimeZone.Get("Europe/Rome");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/0/03/Flag_of_Italy.svg");
					break;
				case CircuitList.Suzuka:
					ShortName = "Suzuka";
					TimeZone = libF1Locations.TimeZone.Get("Asia/Tokyo");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/9/9e/Flag_of_Japan.svg");
					break;
				case CircuitList.Shanghai:
					ShortName = "Shanghai";
					TimeZone = libF1Locations.TimeZone.Get("Asia/Shanghai");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/f/fa/Flag_of_the_People%27s_Republic_of_China.svg");
					break;
				case CircuitList.Zandvoort:
					ShortName = "Zandvoort";
					TimeZone = libF1Locations.TimeZone.Get("Europe/Amsterdam");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/2/20/Flag_of_the_Netherlands.svg");
					break;
				case CircuitList.Singapore:
					ShortName = "Singapore";
					TimeZone = libF1Locations.TimeZone.Get("Asia/Singapore");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/4/48/Flag_of_Singapore.svg");
					break;
				case CircuitList.Sakhir:
					ShortName = "Sakhir";
					TimeZone = libF1Locations.TimeZone.Get("Asia/Bahrain");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/2/2c/Flag_of_Bahrain.svg");
					break;
				case CircuitList.MexicoCity:
					ShortName = "Mexico City";
					TimeZone = libF1Locations.TimeZone.Get("America/Mexico_City");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/f/fc/Flag_of_Mexico.svg");
					break;
				case CircuitList.YasMarina:
					ShortName = "Yas Marina Circuit";
					TimeZone = libF1Locations.TimeZone.Get("Asia/Dubai");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/c/cb/Flag_of_the_United_Arab_Emirates.svg");
					break;
				case CircuitList.Baku:
					ShortName = "Baku";
					TimeZone = libF1Locations.TimeZone.Get("Asia/Baku");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/d/dd/Flag_of_Azerbaijan.svg");
					break;
				case CircuitList.Jeddah:
					ShortName = "Jeddah";
					TimeZone = libF1Locations.TimeZone.Get("Asia/Riyadh");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/0/0d/Flag_of_Saudi_Arabia.svg");
					break;
				case CircuitList.Lusail:
					ShortName = "Lusail";
					TimeZone = libF1Locations.TimeZone.Get("Asia/Qatar");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/6/65/Flag_of_Qatar.svg");
					break;
				case CircuitList.Miami:
					ShortName = "Miami";
					TimeZone = libF1Locations.TimeZone.Get("America/New_York");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/a/a9/Flag_of_the_United_States_%28DoS_ECA_Color_Standard%29.svg");
					break;
				case CircuitList.LasVegas:
					ShortName = "Las Vegas";
					TimeZone = libF1Locations.TimeZone.Get("America/Los_Angeles");
					Flag = new("https://upload.wikimedia.org/wikipedia/commons/a/a9/Flag_of_the_United_States_%28DoS_ECA_Color_Standard%29.svg");
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(key));
			}
		}
	}
}
