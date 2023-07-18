namespace PropertyManagementApp.Models
{
    public class PropertyDataModel
    {
        public int? id { get; set; }

        public bool? favourite { get; set; }

        public string? title { get; set; } 

        public string? headline { get; set; }

        public string? address { get; set; }

        public string? city { get; set; }

        public decimal? latitude { get; set; }

        public decimal? longitude { get; set; }

        public string? picture { get; set; }

        public string? picture_large { get; set; }

        public string? application_url { get; set; }

        public int? checkinType { get; set; }

        public string? mode { get; set; }

        //public bool? agent_showing { get; set; }

        public int? showing_type_order { get; set; }

        public int? availability_date_order { get; set; }

        public string? manager_name { get; set; }

        public string? manager_img { get; set; }

        public string? ready_date_text { get; set; }

        public bool? for_sale { get; set; }

        public string? type { get; set; }

        public int? estimated_monthly_payment { get; set; }

        public bool? premium { get; set; }



    }
}