﻿namespace HorizonPollyC.Models.Financial
{
    public class BankValidationFraudsterTestResultVM
    {
        public bool WasTestResultOverridden { get; set; }
        public int FraudsterFailureType { get; set; }
        public bool WasTestPerformed { get; set; }
        public bool IsValid { get; set; }
        public string Message { get; set; }

      
    }
}
