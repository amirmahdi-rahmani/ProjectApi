namespace WebApi.Models
{
    public class item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string link { get; set; }

        public byte[] ImageOne { get; set; }
        public byte[] ImageTwo { get; set; }

    }
}
