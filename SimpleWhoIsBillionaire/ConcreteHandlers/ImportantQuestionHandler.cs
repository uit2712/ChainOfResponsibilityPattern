using SimpleWhoIsBillionaire.Entities;
using SimpleWhoIsBillionaire.Handlers;
using SimpleWhoIsBillionaire.Requests;
using System.Windows.Forms;

namespace SimpleWhoIsBillionaire.ConcreteHandlers
{
    class ImportantQuestionHandler : QuestionHandler
    {
        public ImportantQuestionHandler(int questionId, long money, Question question)
            : base(questionId, money, question)
        {
        }

        public override void HandleRequest(AnswerContent request)
        {
            if (request == null || request.Player == null)
                return;

            if (request.IsLose)
            {
                MessageBox.Show(string.Format("Xin chia buồn, bạn đã ra về với số tiền thưởng là {0} VNĐ", _money), "Thua cuộc", MessageBoxButtons.OK);
                return;
            }

            if (request.IsRight)
            {
                MessageBox.Show(string.Format("Xin chúc mừng, bạn đã vượt qua câu hỏi số {0} và nhận được số tiền {1} VNĐ!", _questionId, _money), "Cột mốc quan trọng", MessageBoxButtons.OK);
                request.Player.Money = _money;
                request.IsRight = false;
                _successor?.HandleRequest(request);
            }
            else _ancestor?.HandleRequest(request);
        }
    }
}
