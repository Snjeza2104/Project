namespace ProjectService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleModel")]
    public partial class VehicleModel : IVehicleModel
    {
        public int Id { get; set; }

        public int MakeId { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Abrv { get; set; }

        public virtual VehicleMake VehicleMake { get; set; }
    }
}
