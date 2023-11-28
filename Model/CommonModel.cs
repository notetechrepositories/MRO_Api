namespace MRO_Api.Model
{
    public class CommonModel
    {
        public Dictionary<string,string> data { get; set; } // Use dynamic for the data property if it can have different structures
        public string action { get; set; }
        public string fake_name { get; set; }
        public string pgm_id { get; set; }
    }
}
