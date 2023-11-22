using System;

namespace Carfleet{
    public class Truck:Vehicle
    {
        #region private attributes
        //TODO ???
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
                return _isCarryingGoods;
            }
            set
            {
                _isCarryingGoods=value;
            }
        }

        public override string ToString()
        {
            if (IsCarryingGoods == true) 
            {
                return Registration.ToString() + " - " + Brand.ToString() + " - " + Model.ToString() + " - " + ChassisNumber.ToString();
            }
            return Registration.ToString() + " - " + Brand.ToString() + " - " + Model.ToString() + " - " + ChassisNumber.ToString() + " - " + IsCarryingGoods.ToString().ToLower();
            return base.ToString() + " - " + _isCarryingGoods.ToString().ToLower();
        }
        #endregion public methods
    }
}
