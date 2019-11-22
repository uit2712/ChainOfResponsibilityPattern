using SimpleCalculator.Handlers;
using SimpleCalculator.Requests;

namespace SimpleCalculator.ConcreteHandlers
{
    class AddHandler : OperationHandler
    {
        public override string Calculate(NumbersContent request)
        {
            if (request == null || _succesor == null)
                return "0";

            if (string.Compare("+", request.Operation) == 0)
                return (request.Number1 + request.Number2).ToString();
            else return _succesor.Calculate(request);
        }
    }
}
