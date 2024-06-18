namespace Operations
{
    public class Operation
    {
        public decimal ValueOne { get; set; }
        public decimal ValueTwo { get; set; }

        public Operation()
        {
            ValueOne = 0;
            ValueTwo = 0;
        }

    }
    public class Sum : Operation
    {

    }
}


