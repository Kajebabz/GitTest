namespace GitTest.MadssFolder
{
    public class TemplateMads
    {
        public TemplateMads()
        {
        }

        public TemplateMads(string myProperty, int myProperty2)
        {
            MyProperty = myProperty;
            MyProperty2 = myProperty2;
        }

        public string MyProperty { get; set; }
        public int MyProperty2 { get; set; }

    }
}
