using SimpleWhoIsBillionaire.Entities;
using SimpleWhoIsBillionaire.Handlers;
using SimpleWhoIsBillionaire.Requests;
using System;
using System.Windows.Forms;

namespace SimpleWhoIsBillionaire.ConcreteHandlers
{
    class NormalQuestionHandler : QuestionHandler
    {
        public NormalQuestionHandler(int questionId, long money, Question question)
            : base(questionId, money, question)
        {
        }

        public override void HandleRequest(AnswerContent request)
        {
            if (request == null || request.Player == null)
                return;

            if (request.IsRight)
            {
                request.Player.Money = _money;
                _successor?.HandleRequest(request);
            }
            else
            {
                request.IsLose = true;
                _ancestor?.HandleRequest(request);
            }
        }
    }
}
