namespace SPAChallenge.Business.Persistence
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Field
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public Status Status { get; set; }
        public string Tooltip { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
