using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urban_Renaissance
{
    enum costsPerUnit
    {
        sqFeet = 400,
        floor = 1000,
        seat = 250,
        cabin = 500,
        toilet = 350,
        kitchen = 500,
        room = 500
    }

    public class realEstate
    {
        public float area { get; set; }

        public realEstate(float area)
        {
            this.area = area;
        }
        public virtual float CalculatePrice()
        {
            return (area * (float)costsPerUnit.sqFeet);
        }
    }

    public class Building : realEstate
    {
        public int Floors { get; set; }
        public int Toilets { get; set; }
        public Building(float area, int Floors, int Toilets) : base(area)
        {
            this.Floors = Floors;
            this.Toilets = Toilets;
        }
        public override float CalculatePrice()
        {
            return (base.CalculatePrice() + (this.Floors * (float)costsPerUnit.floor) + (this.Toilets * (float)costsPerUnit.toilet));
        }
    }

    public class vacantLandSPace : realEstate
    {
        public vacantLandSPace(float area) : base(area)
        {
        }
    }

    public class CommercialOfficeSpace : Building
    {
        public int Seats { get; set; }
        public int Cabins { get; set; }
        public CommercialOfficeSpace(float area, int floors, int seats, int cabins, int toilets) : base(area, floors, toilets)
        {
            this.Seats = seats;
            this.Cabins = cabins;
        }
        public override float CalculatePrice()
        {
            return (base.CalculatePrice() + (this.Seats * (float)costsPerUnit.seat) + (this.Cabins * (float)costsPerUnit.cabin));
        }
    }
    public class HousingSpace : Building
    {
        public int Rooms { get; set; }
        public int Kitchens { get; set; }
        public HousingSpace(float area, int floors, int rooms, int Kitchens, int toilets) : base(area, floors, toilets)
        {
            this.Rooms = rooms;
            this.Kitchens = Kitchens;
        }
        public override float CalculatePrice()
        {
            return (base.CalculatePrice() + (this.Kitchens * (float)costsPerUnit.kitchen) + (this.Rooms * (float)costsPerUnit.room));

        }
    }
}
