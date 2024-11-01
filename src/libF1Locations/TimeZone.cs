using System;

namespace libF1Locations
{
	internal static class TimeZone
	{
		internal static TimeZoneInfo Get(string tzIdentifier)
		{
			TimeZoneInfo timeZone = tzIdentifier switch
			{
				"America/Chicago" => TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time"),
				"America/Los_Angeles" => TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"),
				"America/Mexico_City" => TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time (Mexico)"),
				"America/New_York" => TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
				"America/Sao_Paulo" => TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"),
				"America/Toronto" => TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
				"Asia/Bahrain" => TimeZoneInfo.FindSystemTimeZoneById("Arab Standard Time"),
				"Asia/Baku" => TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time"),
				"Asia/Dubai" => TimeZoneInfo.FindSystemTimeZoneById("Arabian Standard Time"),
				"Asia/Qatar" => TimeZoneInfo.FindSystemTimeZoneById("Arab Standard Time"),
				"Asia/Riyadh" => TimeZoneInfo.FindSystemTimeZoneById("Arab Standard Time"),
				"Asia/Shanghai" => TimeZoneInfo.FindSystemTimeZoneById("China Standard Time"),
				"Asia/Singapore" => TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time"),
				"Asia/Tokyo" => TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time"),
				"Australia/Melbourne" => TimeZoneInfo.FindSystemTimeZoneById("AUS Eastern Standard Time"),
				"Europe/Amsterdam" => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
				"Europe/Brussels" => TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time"),
				"Europe/Budapest" => TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time"),
				"Europe/London" => TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"),
				"Europe/Madrid" => TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time"),
				"Europe/Monaco" => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
				"Europe/Rome" => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
				"Europe/San_Marino" => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
				"Europe/Vienna" => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
				_ => throw new ArgumentOutOfRangeException(nameof(tzIdentifier))
			};

			return timeZone;
		}
	}
}
