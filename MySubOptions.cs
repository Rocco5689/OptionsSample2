namespace ServiceOptionsSample
{
    public class MySubOptions
    {
        public MySubOptions()
        {
            // Set default values.
            SubOption1 = "value1_from_ctor of SubSection";
            SubOption2 = "value2_from_ctor of SubSection";
        }

        public string SubOption1 { get; set; }
        public string SubOption2 { get; set; }
    }
}