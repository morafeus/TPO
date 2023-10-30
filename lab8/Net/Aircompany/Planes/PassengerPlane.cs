using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        private int passengersCapacity;

        public int PassangersCapacity { get { return passengersCapacity; } }

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            this.passengersCapacity = passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            PassengerPlane plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   this.passengersCapacity == plane.PassangersCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + this.passengersCapacity.GetHashCode();
            return hashCode;
        }
       
        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + this.passengersCapacity +
                    '}');
        }       
        
    }
}
