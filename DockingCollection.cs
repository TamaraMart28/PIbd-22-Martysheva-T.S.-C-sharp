using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly char separator = ':';

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

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"DockingCollection");
                foreach (var level in dockingStages)
                {
                    sw.WriteLine($"Docking{separator}{level.Key}");
                    ITransport ship = null;
                    for (int i = 0; (ship = level.Value.GetNext(i)) != null; i++)
                    {
                        if (ship != null)
                        {
                            //если место не пустое
                            //Записываем тип корабля
                            if (ship.GetType().Name == "Ship")
                            {
                                sw.Write($"Ship{separator}");
                            }
                            if (ship.GetType().Name == "Cruiser")
                            {
                                sw.Write($"Cruiser{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(ship);
                        }
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            using(StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                if (sr.ReadLine().Contains("DockingCollection"))
                {
                    dockingStages.Clear();
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
                Vehicle ship = null;
                string key = string.Empty;
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    if (str.Contains("Docking"))
                    {
                        key = str.Split(separator)[1];
                        dockingStages.Add(key, new Docking<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(str))
                    {
                        continue;
                    }
                    if (str.Split(separator)[0] == "Ship")
                    {
                        ship = new Ship(str.Split(separator)[1]);
                    }
                    else if (str.Split(separator)[0] == "Cruiser")
                    {
                        ship = new Cruiser(str.Split(separator)[1]);
                    }
                    var result = dockingStages[key] + ship;
                    if (result == -1)
                    {
                        throw new Exception("Не удалось загрузить корабль на стоянку доков");
                    }
                }
            }
        }
    }
}
