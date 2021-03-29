using System.Collections.Generic;

namespace ProjectService
{
    public interface IVehicleMake
    {
        string Abrv { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        ICollection<VehicleModel> VehicleModel { get; set; }
    }
}