namespace SPAChallenge.Business.Persistence
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Screen
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string System { get; set; }
        public string Title { get; set; }
        public DateTime LastUpdate { get; set; }
        public virtual ICollection<Field> Fields { get; set; }
    }
}
