using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReception
{
    public class Room
    {
        public int? Idroom { get; set; }
        public int Guests { get; set; }
        public int SingleBeds { get; set; }
        public int DoubleBeds { get; set; }
        public bool Balcony { get; set; }
        public bool Archived { get; set; }
        public double Cost { get; set; }

        public Room() { }

        public Room(DataRowView row)
        {
            this.Idroom = (int)row["idroom"];
            this.Guests = (int)row["guests"];
            this.SingleBeds = (int)row["singleBeds"];
            this.DoubleBeds = (int)row["doubleBeds"];
            if (Int32.Parse(row["balcony"].ToString()) == 1) this.Balcony = true; else this.Balcony = false;
            if (Int32.Parse(row["archived"].ToString()) == 1) this.Archived = true; else this.Archived = false;
            this.Cost = (double)row["cost"]; 
        }

        public override string ToString()
        {
            return $"🔑: {Idroom} | 👨‍👩‍👧‍👦: {Guests} | 🛌: {SingleBeds} | 🛌👫: {DoubleBeds} | 🤸‍♂️: {Balcony} | 💰: {Cost}";
        }
    }
}
