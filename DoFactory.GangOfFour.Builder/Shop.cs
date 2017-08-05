using System;

namespace DoFactory.GangOfFour.Builder
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    class Shop
    {
        VehicleBuilder vehicleBuilder;

        // Builder uses a complex series of steps
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            this.vehicleBuilder = vehicleBuilder;

            this.vehicleBuilder.BuildFrame();
            this.vehicleBuilder.BuildEngine();
            this.vehicleBuilder.BuildWheels();
            this.vehicleBuilder.BuildDoors();
        }

        public void ShowVehicle()
        {
            vehicleBuilder.Vehicle.Show();
        }
    }
}
