using System;
using System.Collections.Generic;

namespace Prog_Assign_07_Fish_Example
{
    public class Fish
    {
        private int id;
        private string name;
        private string water;

        public Fish()
        {
            // Do nothing constructor
        }
        public Fish(int id, string name, string water)
        {
            this.id = id; 
            this.name = name;
            this.water = water;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }

        public string getWater()
        {
            return water;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setWater(string water)
        {
            this.water = water;
        }

        public List<Fish> getAll()
        {
            FishStore fishStore = new FishStore();
            return fishStore.getAll();
        }
        public string waterByFishName(string name)
        {
            FishStore fishStore = new FishStore();
            return fishStore.getFishByName(name).getWater();
        }

        public string add(string name, string waterType)
        {
            // A constant for error message. Avoids a magic value.
            const string NAME_IS_EMPTY_MSG = "Fish name must have a value";
            const string WATER_TYPE_IS_EMPTY_MSG = "Fish must have a water type";

            // Trim any leading or trailing blanks
            name = name.Trim();
            // Make sure it is not empty
            if (String.IsNullOrEmpty(name))
            {
                return NAME_IS_EMPTY_MSG;
            }

            waterType = waterType.Trim();
            if (String.IsNullOrEmpty(waterType))
            {
                return WATER_TYPE_IS_EMPTY_MSG;
            }
            FishStore fishStore = new FishStore();
            return fishStore.add(name, waterType);
        }
        public string modify(int id, string name, string waterType)
        {
            // A constant for error message. Avoids a magic value.
            const string NAME_IS_EMPTY_MSG = "Fish name must have a value";
            const string WATER_TYPE_IS_EMPTY_MSG = "Fish must have a water type";

            // Trim any leading or trailing blanks
            name = name.Trim();
            // Make sure it is not empty
            if (String.IsNullOrEmpty(name))
            {
                return NAME_IS_EMPTY_MSG;
            }

            waterType = waterType.Trim();
            if (String.IsNullOrEmpty(waterType))
            {
                return WATER_TYPE_IS_EMPTY_MSG;
            }
            FishStore fishStore = new FishStore();
            return fishStore.modify(id, name, waterType);
        }
    }
}
