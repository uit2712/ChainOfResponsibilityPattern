using SimpleWhoIsBillionaire.ConcreteHandlers;
using SimpleWhoIsBillionaire.Entities;
using SimpleWhoIsBillionaire.Handlers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using SimpleWhoIsBillionaire.Requests;

namespace SimpleWhoIsBillionaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _questionHandlers.Add(new ImportantQuestionHandler(0, 0, null));
            _questionHandlers.Add(new NormalQuestionHandler(1, 200000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(2, 400000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(3, 600000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(4, 1000000, GetQuestion()));
            _questionHandlers.Add(new ImportantQuestionHandler(5, 2000000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(6, 3000000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(7, 6000000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(8, 10000000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(9, 14000000, GetQuestion()));
            _questionHandlers.Add(new ImportantQuestionHandler(10, 22000000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(11, 30000000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(12, 40000000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(13, 60000000, GetQuestion()));
            _questionHandlers.Add(new NormalQuestionHandler(14, 85000000, GetQuestion()));
            _questionHandlers.Add(new ImportantQuestionHandler(15, 150000000, GetQuestion()));

            for (int i = 1; i < _questionHandlers.Count - 1; i++)
                _questionHandlers[i].SetSuccessor(_questionHandlers[i + 1]);

            _questionHandlers[1].SetAncestor(_questionHandlers[0]);
            _questionHandlers[2].SetAncestor(_questionHandlers[0]);
            _questionHandlers[3].SetAncestor(_questionHandlers[0]);
            _questionHandlers[4].SetAncestor(_questionHandlers[0]);
            _questionHandlers[5].SetAncestor(_questionHandlers[0]);
            _questionHandlers[6].SetAncestor(_questionHandlers[5]);
            _questionHandlers[7].SetAncestor(_questionHandlers[5]);
            _questionHandlers[8].SetAncestor(_questionHandlers[5]);
            _questionHandlers[9].SetAncestor(_questionHandlers[5]);
            _questionHandlers[10].SetAncestor(_questionHandlers[5]);
            _questionHandlers[11].SetAncestor(_questionHandlers[10]);
            _questionHandlers[12].SetAncestor(_questionHandlers[10]);
            _questionHandlers[13].SetAncestor(_questionHandlers[10]);
            _questionHandlers[14].SetAncestor(_questionHandlers[10]);
            _questionHandlers[15].SetAncestor(_questionHandlers[10]);

            CurrentQuestion = _questionHandlers[_currentQuestionId]?.Question;
        }

        Player _player = new Player("Phạm Quang Vĩ");
        List<Question> _lstQuestions = new List<Question>
        {
            new Question { QuestionContent="1+1=?", AnswerA="3", AnswerB="4", AnswerC="5", AnswerD="2", RightAnswer="2" },
            new Question { QuestionContent="1+2=?", AnswerA="3", AnswerB="4", AnswerC="5", AnswerD="2", RightAnswer="3" },
            new Question { QuestionContent="3+1=?", AnswerA="3", AnswerB="4", AnswerC="5", AnswerD="2", RightAnswer="4" },
            new Question { QuestionContent="2+3=?", AnswerA="3", AnswerB="4", AnswerC="5", AnswerD="2", RightAnswer="5" },
            new Question { QuestionContent="3*3-3=?", AnswerA="0", AnswerB="9", AnswerC="6", AnswerD="Không biết", RightAnswer="6" },
            new Question { QuestionContent="4/2*3-1=?", AnswerA="-1/3", AnswerB="-2/3", AnswerC="5", AnswerD="Để hỏi đứa bạn :))", RightAnswer="5" },
            new Question { QuestionContent="1 kí bông và 1 kí sắt, cái nào nặng hơn?", AnswerA="1 kí bông", AnswerB="1 kí sắt", AnswerC="1 kí đồng", AnswerD="bằng nhau", RightAnswer="bằng nhau" },
            new Question { QuestionContent="một ông thủy thủ làm việc trên tàu, 1 giờ công được tính 50 ngìn đồng, ngày hôm nay ông làm được 8 giờ. Hỏi ông thuyền trưởng bao nhiêu tuổi?", AnswerA="1 tuổi", AnswerB="2 tuổi", AnswerC="3 tuổi", AnswerD="chúa cũng không biết", RightAnswer="chúa cũng không biết" },
            new Question { QuestionContent="lịch nào dài nhất?", AnswerA="lịch 200 tờ", AnswerB="lịch trong nhà tù", AnswerC="lịch năm", AnswerD="lịch sử", RightAnswer="lịch sử" },
            new Question { QuestionContent="2 con vịt đi trước 2 con vịt, 2 con vịt đi sau 2 con vịt, 2 con vịt đi giữa 2 con vịt. Hỏi có mấy con vịt?", AnswerA="3", AnswerB="4", AnswerC="5", AnswerD="1 bầy vịt", RightAnswer="4" },
            new Question { QuestionContent="môn gì càng thắng càng thua?", AnswerA="cờ vua", AnswerB="đá cầu", AnswerC="nhảy cao", AnswerD="đua xe đạp", RightAnswer="đua xe đạp" },
            new Question { QuestionContent="chuột nào đi bằng 2 chân?", AnswerA="chuột chù", AnswerB="chuột cống", AnswerC="chuột thành tinh", AnswerD="chuột Jerry", RightAnswer="chuột Jerry" },
            new Question { QuestionContent="từ gì mà 100% người Việt phát âm sai?", AnswerA="đúng", AnswerB="không sai", AnswerC="sai", AnswerD="không đúng", RightAnswer="sai" },
            new Question { QuestionContent="khi Beckham thực hiện quả đá phạt đền, anh ta sẽ sút vào đâu?", AnswerA="quả bóng", AnswerB="khung thành đối phương", AnswerC="trọng tài", AnswerD="khung thành đội nhà", RightAnswer="quả bóng" },
            new Question { QuestionContent="con trai có gì quí nhất?", AnswerA="tiền", AnswerB="đẹp trai", AnswerC="ngọc trai", AnswerD="bầu", RightAnswer="trai" }
        };
        List<QuestionHandler> _questionHandlers = new List<QuestionHandler>();
        int _currentQuestionId = 1;
        Random _random = new Random();
        Question _currentQuestion = null;
        Question CurrentQuestion
        {
            set
            {
                _currentQuestion = value;
                if (_currentQuestion != null)
                {
                    lblQuestionContent.Text = _currentQuestion.QuestionContent;
                    rbAnswerA.Text = _currentQuestion.AnswerA;
                    rbAnswerB.Text = _currentQuestion.AnswerB;
                    rbAnswerC.Text = _currentQuestion.AnswerC;
                    rbAnswerD.Text = _currentQuestion.AnswerD;

                    rbAnswerA.Checked = rbAnswerB.Checked = false;
                    rbAnswerC.Checked = rbAnswerD.Checked = false;
                }
            }
            get { return _currentQuestion; }
        }

        private Question GetQuestion()
        {
            if (_lstQuestions.Count == 0)
                return null;

            Question question = _lstQuestions[_random.Next() % _lstQuestions.Count];
            _lstQuestions.RemoveAt(_random.Next() % _lstQuestions.Count);
            return question;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!rbAnswerA.Checked
                && !rbAnswerB.Checked
                && !rbAnswerC.Checked
                && !rbAnswerD.Checked)
                return;

            RadioButton checkedRadioButton = Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            bool isRight = string.Compare(checkedRadioButton.Text, CurrentQuestion?.RightAnswer) == 0;
            _questionHandlers[_currentQuestionId++]?.HandleRequest(new AnswerContent(_player, isRight));
            CurrentQuestion = _questionHandlers[_currentQuestionId]?.Question;
        }
    }
}
