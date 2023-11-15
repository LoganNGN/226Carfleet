using System;

namespace Carfleet{
    public class Truck:Vehicle
    {
        #region private attributes
        private Boolean _isCarryingGoods = false;
        #endregion private attributes

        #region public methods
        public Truck(string registration, string brand, string model, string chassisNumber):base(registration, brand, model, chassisNumber)
        {
        }

        public Boolean IsCarryingGoods
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
<<<<<<< HEAD
            return _registration.ToString() + " - " + _brand.ToString() + " - " + _model.ToString() + " - " + _chassisNumber.ToString();
=======
            throw new NotImplementedException();
>>>>>>> 3805f8d1eb02f3f03f5de4e0568cee4dfb734356
        }
        #endregion public methods
    }
}
