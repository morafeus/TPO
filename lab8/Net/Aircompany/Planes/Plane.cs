using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        private string model;
        private int maxSpeed;
        private int maxFlightDistance;
        private int maxLoadCapacity;

        public string Model { get { return model; } }
        public int MaxSpeed { get { return maxSpeed; } }
        public int MaxFlightDistace { get { return maxFlightDistance; } }
        public int MaxLoadCapacity { get { return maxLoadCapacity; } }

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            this.model = model;
            this.maxSpeed = maxSpeed;
            this.maxFlightDistance = maxFlightDistance;
            this.maxLoadCapacity = maxLoadCapacity;
        }

        

        public override string ToString()
        {
            return "Plane{" +
                "model='" + this.model + '\'' +
                ", maxSpeed=" + this.maxSpeed +
                ", maxFlightDistance=" + this.maxFlightDistance +
                ", maxLoadCapacity=" + this.maxLoadCapacity +
                '}';
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   this.model == plane.Model &&
                   this.maxSpeed == plane.MaxSpeed &&
                   this.maxFlightDistance == plane.MaxFlightDistace &&
                   this.maxLoadCapacity == plane.MaxLoadCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.model);
            hashCode = hashCode * -1521134295 + this.maxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + this.maxFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + this.maxLoadCapacity.GetHashCode();
            return hashCode;
        }        

    }
}
