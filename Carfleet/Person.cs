namespace Carfleet
{
    public class Driver
    {
        #region private attributes
        private string name;
        private string firstname;
        private string city;
        private string phonenumber;
        private string emailaddress;
        private string language;
        private string workZone;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string language = "", string workZone = "")
        {
        }
        #endregion public methods
    }
}
