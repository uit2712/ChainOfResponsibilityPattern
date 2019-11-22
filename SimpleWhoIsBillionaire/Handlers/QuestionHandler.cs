using SimpleWhoIsBillionaire.Entities;
using SimpleWhoIsBillionaire.Requests;

namespace SimpleWhoIsBillionaire.Handlers
{
    abstract class QuestionHandler
    {
        protected QuestionHandler _successor;
        protected QuestionHandler _ancestor;
        protected int _questionId;
        protected long _money;

        public Question Question { get; set; }

        public QuestionHandler(int questionId, long money, Question question)
        {
            _questionId = questionId;
            _money = money;
            Question = question;
        }

        public void SetSuccessor(QuestionHandler successor)
        {
            _successor = successor;
        }

        public void SetAncestor(QuestionHandler ancestor)
        {
            _ancestor = ancestor;
        }

        public abstract void HandleRequest(AnswerContent request);
    }
}
