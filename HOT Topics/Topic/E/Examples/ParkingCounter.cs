using System;
using System.Linq;

namespace Topic.E.Examples
{
    public class ParkingCounter
    {
        public int ParkingSpots { get; private set; }

        public int OpenSpots { get; private set; }

        public ParkingCounter(int parkingSpots)
        {
            this.ParkingSpots = parkingSpots;
            this.OpenSpots = parkingSpots;
        }

        public ParkingCounter(int parkingSpots, int numberOfCars)
        {
            this.ParkingSpots = parkingSpots;
            this.OpenSpots = this.ParkingSpots - numberOfCars;
        }

        public void Leave()
        {
            OpenSpots++;
        }

        public void Enter()
        {
            OpenSpots--;
        }

        public void ResetLotAsEmpty()
        {
            OpenSpots = ParkingSpots;
        }

        public void ResetLotAsFull()
        {
            OpenSpots = 0;
        }
    }
}
