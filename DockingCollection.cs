using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCruiser
{
    public class DockingCollection
    {
        readonly Dictionary<string, Docking<Vehicle>> dockingStages;
        public List<string> Keys => dockingStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;

        public DockingCollection(int pictureWidth, int pictureHeight)
        {
            dockingStages = new Dictionary<string, Docking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddDocking(string name)
        {
            if (!dockingStages.ContainsKey(name)) dockingStages.Add(name, new Docking<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelDocking(string name)
        {
            if (dockingStages.ContainsKey(name)) dockingStages.Remove(name);
        }

        public Docking<Vehicle> this[string ind]
        {
            set { dockingStages[ind] = value; }
            get 
            {
                if (!dockingStages.ContainsKey(ind)) return null;
                return dockingStages[ind];                
            }
        }
    }
}
