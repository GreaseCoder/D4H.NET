using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace D4H.NET.Models
{
    public class Event : IModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("team_id")]
        public long? TeamId { get; set; }

        [JsonProperty("tracking_number")]
        public object TrackingNumber { get; set; }

        [JsonProperty("published")]
        public long Published { get; set; }

        [JsonProperty("archived")]
        public long Archived { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("enddate")]
        public DateTimeOffset Enddate { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("ref_autoid")]
        public object RefAutoid { get; set; }

        [JsonProperty("ref_desc")]
        public object RefDesc { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("location_bookmark_id")]
        public object LocationBookmarkId { get; set; }

        [JsonProperty("latlng")]
        public string Latlng { get; set; }

        [JsonProperty("lat")]
        public double? Lat { get; set; }

        [JsonProperty("lng")]
        public double? Lng { get; set; }

        [JsonProperty("distance")]
        public long? Distance { get; set; }

        [JsonProperty("bearing")]
        public object Bearing { get; set; }

        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("perc_attendance")]
        public long PercAttendance { get; set; }

        [JsonProperty("count_attendance")]
        public long CountAttendance { get; set; }

        [JsonProperty("count_guests")]
        public long CountGuests { get; set; }

        [JsonProperty("night")]
        public long Night { get; set; }

        [JsonProperty("streetaddress")]
        public string Streetaddress { get; set; }

        [JsonProperty("townaddress")]
        public string Townaddress { get; set; }

        [JsonProperty("regionaddress")]
        public string Regionaddress { get; set; }

        [JsonProperty("postcodeaddress")]
        public string Postcodeaddress { get; set; }

        [JsonProperty("countryaddress")]
        public string Countryaddress { get; set; }

        [JsonProperty("gridref")]
        public string Gridref { get; set; }

        [JsonProperty("count_equipment_used")]
        public long CountEquipmentUsed { get; set; }

        [JsonProperty("weather")]
        public object Weather { get; set; }
    }
}
