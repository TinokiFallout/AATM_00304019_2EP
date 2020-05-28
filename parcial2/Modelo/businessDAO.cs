namespace Parcial2
{
    public class BusinessDAO
    {
        public int idbusiness { get; set; }
        public string  name  { get; set; }
        public string description { get; set; }

        public BusinessDAO()
        {
            idbusiness = 0;
            name = "";
            description = "";
        }
    }
}