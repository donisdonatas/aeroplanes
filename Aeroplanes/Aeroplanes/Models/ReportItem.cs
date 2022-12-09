namespace Aeroplanes.Models
{
    public class ReportItem
    {
        public string aircraftTailNumber;
        public string modelNumber;
        public string modelDescription;
        public string ownerComapanyName;
        public string companyCountryCode;
        public string companyCountryName;
        public bool   isEuropeCountry;

        public ReportItem(string tailNr, string modelNr, string modelDscrpt, string companyName, string countryCode, string countryName, bool isEUcountry)
        {
            aircraftTailNumber = tailNr;
            modelNumber = modelNr;
            modelDescription = modelDscrpt;
            ownerComapanyName = companyName;
            companyCountryCode = countryCode;
            companyCountryName = countryName;
            isEuropeCountry = isEUcountry;
        }
    }
}
