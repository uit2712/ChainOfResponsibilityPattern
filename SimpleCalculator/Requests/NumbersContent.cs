using System;

namespace SimpleCalculator.Requests
{
    class NumbersContent
    {
        public float Number1 { get; set; }
        public float Number2 { get; set; }
        public string Operation { get; set; }

        public NumbersContent(string number1, string number2, string operation)
        {
            float n1, n2;
            float.TryParse(number1, out n1);
            Number1 = n1;

            float.TryParse(number2, out n2);
            Number2 = n2;

            Operation = operation;
        }
    }
}
