using SimpleCalculator.Handlers;
using SimpleCalculator.Requests;

namespace SimpleCalculator.ConcreteHandlers
{
    class DivideHandler : OperationHandler
    {
        public override string Calculate(NumbersContent request)
        {
            if (request == null || _succesor == null)
                return "0";

            if (string.Compare("/", request.Operation) == 0)
            {
                if (request.Number2 == 0)
                    return "Can't divide by zero!";

                return (request.Number1 / request.Number2).ToString();
            }
            else return _succesor.Calculate(request);
        }
    }
}
