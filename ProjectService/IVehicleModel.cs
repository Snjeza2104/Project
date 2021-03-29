namespace ProjectService
{
    public interface IVehicleModel
    {
        string Abrv { get; set; }
        int Id { get; set; }
        int MakeId { get; set; }
        string Name { get; set; }
        VehicleMake VehicleMake { get; set; }
    }
}