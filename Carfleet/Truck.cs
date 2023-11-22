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
<<<<<<< HEAD
                _isCarryingGoods=value;
=======
                _isCarryingGoods = value;
>>>>>>> cf68b828029f12199b738e7414724d9c26bc064f
            }
        }

        public override string ToString()
        {
<<<<<<< HEAD
            if (IsCarryingGoods == true) 
            {
                return Registration.ToString() + " - " + Brand.ToString() + " - " + Model.ToString() + " - " + ChassisNumber.ToString();
            }
            return Registration.ToString() + " - " + Brand.ToString() + " - " + Model.ToString() + " - " + ChassisNumber.ToString() + " - " + IsCarryingGoods.ToString().ToLower();
=======
            return base.ToString() + " - " + _isCarryingGoods.ToString().ToLower();
>>>>>>> cf68b828029f12199b738e7414724d9c26bc064f
        }
        #endregion public methods
    }
}
