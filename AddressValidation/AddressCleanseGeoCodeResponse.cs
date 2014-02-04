using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressValidation
{
    public class AddressCleanseGeoCodeResponse
    {
        public string Status { get; set; }
        public string StatusMessage { get; set; }
        public string RawDetailCode { get; set; }
        public string AddressID { get; set; }
        public string PrimaryAddress { get; set; }
        public string PrimaryNumber { get; set; }
        public string PrimaryPrefix { get; set; }
        public string PrimaryName { get; set; }
        public string PrimaryType { get; set; }
        public string PrimaryPostfix { get; set; }
        public string PrimaryAddressRemainder { get; set; }
        public string SecondaryAddress { get; set; }
        public string SecondaryUnitDescription { get; set; }
        public string SecondaryUnitNumber { get; set; }
        public string City { get; set; }
        public string City13 { get; set; }
        public string State { get; set; }
        public string Zip10 { get; set; }
        public string Zip5 { get; set; }
        public string Zip4 { get; set; }
        public string AddressType { get; set; }
        public string IsDefault { get; set; }
        public string DeliveryPointBarcode { get; set; }
        public string DeliveryPointBarcodeCheckDigit { get; set; }
        public string LineOfTravel { get; set; }
        public string LineOfTravelOrder { get; set; }
        public string CarrierRoute { get; set; }
        public string CountyCode { get; set; }
        public string CountyName { get; set; }
        public string DpvFootnote { get; set; }
        public string IsDpvNoStat { get; set; }
        public string DpvStatus { get; set; }
        public string SuiteLinkResult { get; set; }
        public string IsVacant { get; set; }
        public string NonPostalSecondaryAddress { get; set; }
        public string ExtraLine1 { get; set; }
        public string ExtraLine2 { get; set; }
        public string SecondaryAddressExtraneous { get; set; }
        public string AssignmentLevel { get; set; }
        public string CensusTractBLock { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string MetroStatAreaCode { get; set; }
    }


}
