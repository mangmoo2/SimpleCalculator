namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int num1 = 0;      // 첫 번째 숫자 저장
        int num2 = 0;      // 두 번째 숫자 저장
        string op = "";    // 선택한 연산자 저장
        bool OpClicked = false; // 연산자 눌렀는지 확인

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;

            if (OpClicked)           // 연산자 눌렀더라면 하단창 초기화
            {
                CurrentDisplay.Text = "";
                OpClicked = false;
            }

            // 전체 식에 추가
            TotalDisplay.Text += num;

            // 현재 입력값에만 추가 
            CurrentDisplay.Text += num;
        }
        private void Result_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(CurrentDisplay.Text);
            // 문자열을 숫자로 변환
            int result = num1 + num2;

            switch (op)    // 연산의 계산 
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "x": result = num1 * num2; break;
                case "÷": result = num1 / num2; break;
            }

            // 상단 텍스트박스: 마지막에 " = 결과" 추가
            TotalDisplay.Text += " = " + result.ToString();

            // 하단 텍스트박스: 기존 내용을 지우고 최종 결과값만 표시
            CurrentDisplay.Text = result.ToString();    // INT를 STINRG으로 다시 변환
        }

        private void Op_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 하단 창에 적힌숫자를 첫번째 숫자로 저장
            num1 = int.Parse(CurrentDisplay.Text);       // STRING 데이터 INT로 변환
            // 어떤 연산자인지 저장
            op = btn.Text;
            // 상단 창에 연산자 표시 추가
            TotalDisplay.Text += " " + op + " ";
            // 연산자가 눌렸음을 표시
            OpClicked = true;
        }
    }
}
