using System.Collections.Generic;

namespace Prog_Assign_07_Fish_Example
{
    class FishStore
    {
        private DBAccess db = new DBAccess();

        public FishStore()
        {
            
        }
        public List<Fish> getAll() => db.GetAllFish();

        public Fish getFishByName(string name)
        {
            foreach (Fish aFish in getAll())
            {
                if (aFish.getName() == name)
                {
                    return aFish;
                }
            }
            return new Fish();
        }
        
        public string add(string name, string waterType)
        {
            // Add it to the database
            return db.FishAdd(name, waterType);
        }
        public string modify(int id, string name, string waterType)
        {
            // Add it to the database
            return db.FishModify(id, name, waterType);
        }
    }
}
