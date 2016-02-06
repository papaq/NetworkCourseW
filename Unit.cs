using System.Collections.Generic;
using System.Linq;
using System.Windows;
using NetsCo;

namespace NetworksCeW
{
    public class Unit
    {
        public int Index;
        public int NetwIndex;
        public Point Position;
        public List<int> ListBindsIndexes = new List<int>();

        public int Buffer = 2000;
        public bool Disabled;

        public Unit()
        {
        }

        public Unit(Unit unit)
        {
            Index = unit.Index;
            NetwIndex = unit.NetwIndex;
            Position = new Point(unit.Position.X, unit.Position.Y);
            foreach (var index in unit.ListBindsIndexes)
                ListBindsIndexes.Add(index);
            Buffer = unit.Buffer;
            Disabled = unit.Disabled;
        }

        public void AddBind(Bind newBind)
        {
            ListBindsIndexes.Add(newBind.Index);
        }
        
        public List<int> GetListOfConnectedUnitsIndexes(List<Bind> listOfBinds)
        {
            var listOfCoUnits = new List<int>();
            foreach (var bind in listOfBinds.Where(bind => bind.ListOfBothUnitsIndexes.Contains(Index)))
                listOfCoUnits.Add(bind.GetSecondUnitIndex(Index));
            return listOfCoUnits;
        }

        public string ConnectsIndexes(List<Bind> listOfBinds)
        {
            if (ListBindsIndexes.Count == 0)
            {
                return "No yet";
            }
            var listOfCoUnitsIndexes = GetListOfConnectedUnitsIndexes(listOfBinds);
            var strOfIndexes = "";
            foreach (var index in listOfCoUnitsIndexes)
                strOfIndexes += index + ", ";
            return strOfIndexes.Remove(strOfIndexes.Length - 2);
        }
    }
}
