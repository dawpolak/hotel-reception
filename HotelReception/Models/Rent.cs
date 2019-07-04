using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReception
{
    public class Rent
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public double Cost { get; set; }
        public int Idroom { get; set; }
        public string Worker { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }

        public Rent() { }
        public Rent(DataRowView row)
        {
            this.Start = (DateTime)row["start"];
            this.End = (DateTime)row["end"];
            this.Cost = (double)row["cost"];
            this.Idroom = (int)row["idroom"];
            this.Worker = row["idworker"].ToString();
            this.Firstname = row["firstname"].ToString();
            this.Lastname = row["lastname"].ToString();
            this.Phone = row["phone"].ToString();
        }

        public override string ToString()
        {
           // return $"🔑:{Idroom} | Od:{Start.ToString("yyyy-MM-dd")} | Do:{End.ToString("yyyy-MM-dd")} | 💲:{Cost} |  💁‍♂️:{Worker} | 👨‍👩‍👧‍👦:{Firstname} {Lastname} | {Phone}";
           return $"🔑:{Idroom} | Od:{Start.ToString("dd-MM")} | Do:{End.ToString("dd-MM")} | 💲:{Cost} | {Worker} | {Firstname} {Lastname} | {Phone}";
        }
    }
}
