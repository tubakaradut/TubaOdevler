using System;

namespace ProductAbstraction
{
    public abstract class BaseClass
    {
        //Custom Properties
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        //Methods

        public abstract string Add();
        public abstract string Update(int index);
        public abstract string Delete(int index);
        public abstract string List();



    }
}
