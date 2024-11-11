using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_Truck
{
    
    public class Motorcycle : Vehicle
    {
        public int EngineCC { get; }
        public bool IsSportBike { get; }

        public Motorcycle(int vehicleId, string make, string model, float fuelEfficiency, int engineCC, bool isSportBike)
            : base(vehicleId, make, model, fuelEfficiency)
        {
            EngineCC = engineCC;
            IsSportBike = isSportBike;
        }

        public override float CalculateFuelConsumption(float distance)
        {
            float fuelConsumption = base.CalculateFuelConsumption(distance);
            return IsSportBike ? fuelConsumption * 1.1f : fuelConsumption;
        }
    }

    public class Truck : Vehicle
    {
        public float CargoCapacity { get; } 
        public bool IsHeavyDuty { get; }

        public Truck(int vehicleId, string make, string model, float fuelEfficiency, float cargoCapacity, bool isHeavyDuty) : base(vehicleId, make, model, fuelEfficiency)
        {
            CargoCapacity = cargoCapacity;
            IsHeavyDuty = isHeavyDuty;
        }

        public float CalculateFuelConsumption(float distance, float cargoWeight)
        {
            float baseFuelConsumption = base.CalculateFuelConsumption(distance);
            float cargoFactor = 1 + (cargoWeight / CargoCapacity);
            float heavyDutyFactor = IsHeavyDuty ? 1.2f : 1.0f;

            return baseFuelConsumption * cargoFactor * heavyDutyFactor;
        }
    }

    

}
