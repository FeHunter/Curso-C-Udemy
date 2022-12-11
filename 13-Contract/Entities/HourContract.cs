namespace Course.Entities {
    class HourContract {
        public DateTime Data {get; set;}
        public double ValuePerHour { get; set; }
        public int Hour {get; set;}

        public HourContract (){}
        public HourContract ( DateTime data, double valuePerHour, int hour ){
            Data = data;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }

        public double TotalValue (){
            return Hour * ValuePerHour;
        }
    }
}