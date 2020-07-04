// Generated by https://quicktype.io
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SimulatedAnnealingUI.Geocode
{
	public partial class GeocodeResponse
	{
		[JsonProperty("documentation")]
		public Uri Documentation { get; set; }

		[JsonProperty("licenses")]
		public License[] Licenses { get; set; }

		[JsonProperty("rate")]
		public Rate Rate { get; set; }

		[JsonProperty("results")]
		public Result[] Results { get; set; }

		[JsonProperty("status")]
		public Status Status { get; set; }

		[JsonProperty("stay_informed")]
		public StayInformed StayInformed { get; set; }

		[JsonProperty("thanks")]
		public string Thanks { get; set; }

		[JsonProperty("timestamp")]
		public Timestamp Timestamp { get; set; }

		[JsonProperty("total_results")]
		public long TotalResults { get; set; }
	}

	public partial class License
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }
	}

	public partial class Rate
	{
		[JsonProperty("limit")]
		public long Limit { get; set; }

		[JsonProperty("remaining")]
		public long Remaining { get; set; }

		[JsonProperty("reset")]
		public long Reset { get; set; }
	}

	public partial class Result
	{
		[JsonProperty("annotations")]
		public Annotations Annotations { get; set; }

		[JsonProperty("bounds", NullValueHandling = NullValueHandling.Ignore)]
		public Bounds Bounds { get; set; }

		[JsonProperty("components")]
		public Dictionary<string, string> Components { get; set; }

		[JsonProperty("confidence")]
		public long Confidence { get; set; }

		[JsonProperty("formatted")]
		public string Formatted { get; set; }

		[JsonProperty("geometry")]
		public Geometry Geometry { get; set; }
	}

	public partial class Annotations
	{
		[JsonProperty("DMS")]
		public Dms Dms { get; set; }

		[JsonProperty("MGRS")]
		public string Mgrs { get; set; }

		[JsonProperty("Maidenhead")]
		public string Maidenhead { get; set; }

		[JsonProperty("Mercator")]
		public Mercator Mercator { get; set; }

		[JsonProperty("OSM")]
		public Osm Osm { get; set; }

		[JsonProperty("UN_M49")]
		public UnM49 UnM49 { get; set; }

		[JsonProperty("callingcode")]
		public long Callingcode { get; set; }

		[JsonProperty("currency")]
		public Currency Currency { get; set; }

		[JsonProperty("flag")]
		public string Flag { get; set; }

		[JsonProperty("geohash")]
		public string Geohash { get; set; }

		[JsonProperty("qibla")]
		public double Qibla { get; set; }

		[JsonProperty("roadinfo")]
		public Roadinfo Roadinfo { get; set; }

		[JsonProperty("sun")]
		public Sun Sun { get; set; }

		[JsonProperty("timezone")]
		public Timezone Timezone { get; set; }

		[JsonProperty("what3words")]
		public What3Words What3Words { get; set; }
	}

	public partial class Currency
	{
		[JsonProperty("alternate_symbols")]
		public object[] AlternateSymbols { get; set; }

		[JsonProperty("decimal_mark")]
		public string DecimalMark { get; set; }

		[JsonProperty("html_entity")]
		public string HtmlEntity { get; set; }

		[JsonProperty("iso_code")]
		public string IsoCode { get; set; }

		[JsonProperty("iso_numeric")]
		[JsonConverter(typeof(ParseStringConverter))]
		public long IsoNumeric { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("smallest_denomination")]
		public long SmallestDenomination { get; set; }

		[JsonProperty("subunit")]
		public string Subunit { get; set; }

		[JsonProperty("subunit_to_unit")]
		public long SubunitToUnit { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("symbol_first")]
		public long SymbolFirst { get; set; }

		[JsonProperty("thousands_separator")]
		public string ThousandsSeparator { get; set; }
	}

	public partial class Dms
	{
		[JsonProperty("lat")]
		public string Lat { get; set; }

		[JsonProperty("lng")]
		public string Lng { get; set; }
	}

	public partial class Mercator
	{
		[JsonProperty("x")]
		public double X { get; set; }

		[JsonProperty("y")]
		public double Y { get; set; }
	}

	public partial class Osm
	{
		[JsonProperty("edit_url", NullValueHandling = NullValueHandling.Ignore)]
		public Uri EditUrl { get; set; }

		[JsonProperty("note_url")]
		public Uri NoteUrl { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }
	}

	public partial class Roadinfo
	{
		[JsonProperty("drive_on")]
		public string DriveOn { get; set; }

		[JsonProperty("speed_in")]
		public string SpeedIn { get; set; }
	}

	public partial class Sun
	{
		[JsonProperty("rise")]
		public Rise Rise { get; set; }

		[JsonProperty("set")]
		public Rise Set { get; set; }
	}

	public partial class Rise
	{
		[JsonProperty("apparent")]
		public long Apparent { get; set; }

		[JsonProperty("astronomical")]
		public long Astronomical { get; set; }

		[JsonProperty("civil")]
		public long Civil { get; set; }

		[JsonProperty("nautical")]
		public long Nautical { get; set; }
	}

	public partial class Timezone
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("now_in_dst")]
		public long NowInDst { get; set; }

		[JsonProperty("offset_sec")]
		public long OffsetSec { get; set; }

		[JsonProperty("offset_string")]
		public string OffsetString { get; set; }

		[JsonProperty("short_name")]
		public string ShortName { get; set; }
	}

	public partial class UnM49
	{
		[JsonProperty("regions")]
		public Regions Regions { get; set; }

		[JsonProperty("statistical_groupings")]
		public string[] StatisticalGroupings { get; set; }
	}

	public partial class Regions
	{
		[JsonProperty("DE")]
		[JsonConverter(typeof(ParseStringConverter))]
		public long De { get; set; }

		[JsonProperty("EUROPE")]
		[JsonConverter(typeof(ParseStringConverter))]
		public long Europe { get; set; }

		[JsonProperty("WESTERN_EUROPE")]
		[JsonConverter(typeof(ParseStringConverter))]
		public long WesternEurope { get; set; }

		[JsonProperty("WORLD")]
		public string World { get; set; }
	}

	public partial class What3Words
	{
		[JsonProperty("words")]
		public string Words { get; set; }
	}

	public partial class Bounds
	{
		[JsonProperty("northeast")]
		public Geometry Northeast { get; set; }

		[JsonProperty("southwest")]
		public Geometry Southwest { get; set; }
	}

	public partial class Geometry
	{
		[JsonProperty("lat")]
		public double Lat { get; set; }

		[JsonProperty("lng")]
		public double Lng { get; set; }
	}

	public partial class Status
	{
		[JsonProperty("code")]
		public long Code { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }
	}

	public partial class StayInformed
	{
		[JsonProperty("blog")]
		public Uri Blog { get; set; }

		[JsonProperty("twitter")]
		public Uri Twitter { get; set; }
	}

	public partial class Timestamp
	{
		[JsonProperty("created_http")]
		public string CreatedHttp { get; set; }

		[JsonProperty("created_unix")]
		public long CreatedUnix { get; set; }
	}

	public partial class GeocodeResponse
	{
		public static GeocodeResponse FromJson(string json) => JsonConvert.DeserializeObject<GeocodeResponse>(json, Converter.Settings);
	}

	public static class Serialize
	{
		public static string ToJson(this GeocodeResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
	}

	internal static class Converter
	{
		public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
		{
			MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
			DateParseHandling = DateParseHandling.None,
			Converters = {
				new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
			},
		};
	}

	internal class ParseStringConverter : JsonConverter
	{
		public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

		public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null) return null;
			var value = serializer.Deserialize<string>(reader);
			long l;
			if (Int64.TryParse(value, out l))
			{
				return l;
			}
			throw new Exception("Cannot unmarshal type long");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (long)untypedValue;
			serializer.Serialize(writer, value.ToString());
			return;
		}

		public static readonly ParseStringConverter Singleton = new ParseStringConverter();
	}
}
