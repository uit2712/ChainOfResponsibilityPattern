using SimpleCalculator.ConcreteHandlers;
using SimpleCalculator.Handlers;
using SimpleCalculator.Requests;
using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _addHandler.SetSuccessor(_subtractHandler);
            _subtractHandler.SetSuccessor(_multiplyHandler);
            _multiplyHandler.SetSuccessor(_divideHandler);
            _divideHandler.SetSuccessor(_addHandler);
        }

        OperationHandler _addHandler = new AddHandler();
        OperationHandler _subtractHandler = new SubtractHandler();
        OperationHandler _multiplyHandler = new MultiplyHandler();
        OperationHandler _divideHandler = new DivideHandler();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            NumbersContent _numbers = new NumbersContent(txtNumber1.Text, txtNumber2.Text, cbbOperation.Text);
            txtResult.Text = _addHandler.Calculate(_numbers);
        }
    }
}
