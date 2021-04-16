using System;
namespace Lab2
{
    public class Bus
    {
        public string model;
        public string nubmer;
        public Park id;
        public Bus(string model, string nubmer, Park id)
        {
            this.model = model;
            this.nubmer = nubmer;
            this.id = id;
        }

        public Bus ShallowCopy()
        {
            return (Bus)this.MemberwiseClone();
        }

        public Bus DeepCopy()
        {
            Bus newbus = (Bus)this.MemberwiseClone();
            newbus.id = new Park(id.id);
            newbus.model = String.Copy(model);
            newbus.nubmer = String.Copy(nubmer);
            return newbus;
        }
    }
}
