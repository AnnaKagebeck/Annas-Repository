using System;

namespace Learning.Core.Domain
{
    public class WineUnit
    {
        public WineUnit(string name, int vintage, string producer, string district, string grape, string country)
        {
            Name = name;            
            Producer = producer;
            District = district;
            Grape = grape;
            Country = country;           
            Vintage = vintage;
        }
        

        private string _name;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        private string _producer;
        public string Producer
        {
            get { return _producer; }
            private set { _producer = value; }
        }

        private string _district;
        public string District
        {
            get { return _district; }
            private set { _district = value; }
        }

        private string _grape;
        public string Grape
        {
            get { return _grape; }
            private set { _grape = value; }
        }

        private string _country;
        public string Country
        {
            get { return _country; }
            private set { _country = value; }
        }

        private int _vintage;

        

        public int Vintage
        {
            get { return _vintage; }
            private set { _vintage = value; }
        }
    }
}