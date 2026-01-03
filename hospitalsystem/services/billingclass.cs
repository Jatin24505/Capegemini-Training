class Billingclass
{
   int consultationFee { get; set; }
   int TESTCHARGES { get; set; }
   int ROOMCHARGES { get; set; }
   Double TOTAL()
   {
      return consultationFee+TESTCHARGES+ROOMCHARGES;
   }
}