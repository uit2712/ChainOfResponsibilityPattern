using SimpleWhoIsBillionaire.Entities;

namespace SimpleWhoIsBillionaire.Requests
{
    class AnswerContent
    {
        public Player Player { get; set; }
        public bool IsRight { get; set; }
        public bool IsLose { get; set; }

        public AnswerContent(Player player, bool isRight)
        {
            Player = player;
            IsRight = isRight;
            IsLose = false;
        }
    }
}
