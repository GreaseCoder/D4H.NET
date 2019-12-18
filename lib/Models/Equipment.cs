using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace D4H.NET.Models
{
    public class Equipment : IModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("barcode")]
        public object Barcode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("total_weight")]
        public TotalWeight TotalWeight { get; set; }

        [JsonProperty("total_replacement_cost")]
        public TotalReplacementCost TotalReplacementCost { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("id_marks")]
        public string IdMarks { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("critical_alert")]
        public long CriticalAlert { get; set; }

        [JsonProperty("expire_alert")]
        public long ExpireAlert { get; set; }

        [JsonProperty("is_monitor")]
        public bool IsMonitor { get; set; }

        [JsonProperty("is_critical")]
        public bool IsCritical { get; set; }

        [JsonProperty("is_all_child_op")]
        public object IsAllChildOp { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("minutes_use")]
        public long MinutesUse { get; set; }

        [JsonProperty("date_expires")]
        public object DateExpires { get; set; }

        [JsonProperty("date_purchased")]
        public object DatePurchased { get; set; }

        [JsonProperty("date_manufactured")]
        public object DateManufactured { get; set; }

        [JsonProperty("date_last_moved")]
        public object DateLastMoved { get; set; }

        [JsonProperty("date_firstuse")]
        public object DateFirstuse { get; set; }

        [JsonProperty("date_warranty")]
        public object DateWarranty { get; set; }

        [JsonProperty("date_retired")]
        public object DateRetired { get; set; }

        [JsonProperty("date_last_status_change")]
        public object DateLastStatusChange { get; set; }

        [JsonProperty("odometer_reading")]
        public object OdometerReading { get; set; }

        [JsonProperty("odometer_reading_date")]
        public object OdometerReadingDate { get; set; }

        [JsonProperty("odometer_reading_total")]
        public object OdometerReadingTotal { get; set; }

        [JsonProperty("odometer_reading_total_allowed")]
        public long OdometerReadingTotalAllowed { get; set; }

        [JsonProperty("cost_per_distance")]
        public object CostPerDistance { get; set; }

        [JsonProperty("cost_per_hour")]
        public object CostPerHour { get; set; }

        [JsonProperty("cost_per_use")]
        public object CostPerUse { get; set; }

        [JsonProperty("category")]
        public Brand Category { get; set; }

        [JsonProperty("kind")]
        public Brand Kind { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("brand")]
        public Brand Brand { get; set; }

        [JsonProperty("model")]
        public Brand Model { get; set; }

        [JsonProperty("supplier")]
        public Brand Supplier { get; set; }

        [JsonProperty("supplier_ref")]
        public Brand SupplierRef { get; set; }

        [JsonProperty("retired_reason")]
        public Brand RetiredReason { get; set; }

        [JsonProperty("team_id")]
        public long TeamId { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }
    }

    public partial class Brand
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        [JsonProperty("location_title")]
        public string LocationTitle { get; set; }

        [JsonProperty("parent_id")]
        public object ParentId { get; set; }

        [JsonProperty("member_id")]
        public object MemberId { get; set; }

        [JsonProperty("member_name")]
        public object MemberName { get; set; }

        [JsonProperty("location_array")]
        public string[] LocationArray { get; set; }

        [JsonProperty("unit_title")]
        public string UnitTitle { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("is_all_child_op")]
        public object IsAllChildOp { get; set; }
    }

    public partial class TotalReplacementCost
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public partial class TotalWeight
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public partial class Urls
    {
        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
