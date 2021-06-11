namespace Confectionery.Model
{
    public partial class Client
    {
        public string FullName
        {
            get
            {
                return $"{lastName} {firstName}";
            }
        }
    }
}
