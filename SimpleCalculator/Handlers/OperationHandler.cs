using SimpleCalculator.Requests;

namespace SimpleCalculator.Handlers
{
    abstract class OperationHandler
    {
        protected OperationHandler _succesor;

        public void SetSuccessor(OperationHandler succesor)
        {
            _succesor = succesor;
        }

        public abstract string Calculate(NumbersContent request);
    }
}
