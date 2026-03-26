namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double num1 = 0;      // 첫 번째 숫자 저장     // 소수점으로 인한 계산에 의해 int 함수에서 double 함수로 변경
        double num2 = 0;      // 두 번째 숫자 저장    // 소수점으로 인한 계산에 의해 int 함수에서 double 함수로 변경
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
            num2 = double.Parse(CurrentDisplay.Text);
            // 문자열을 숫자로 변환
            double result = num1 + num2;

            switch (op)    // 연산의 계산 
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break; // 과제 2
                case "x": result = num1 * num2; break; // 과제 2
                case "÷": result = num1 / num2; break; // 과제 2
            }
            // 결과값을 소수점 5자리까지만 반올림
            double roundedResult = Math.Round(result, 5);
            // 상단 텍스트박스: 마지막에 " = 결과" 추가
            TotalDisplay.Text += " = " + result.ToString();

            // 하단 텍스트박스: 기존 내용을 지우고 최종 결과값만 표시
            CurrentDisplay.Text = result.ToString();    // INT를 STINRG으로 다시 변환
        }

        private void Op_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // 하단 창에 적힌숫자를 첫번째 숫자로 저장
            num1 = double.Parse(CurrentDisplay.Text);       // STRING 데이터 INT로 변환
            // 어떤 연산자인지 저장
            op = btn.Text;
            // 상단 창에 연산자 표시 추가
            TotalDisplay.Text += " " + op + " ";
            // 연산자가 눌렸음을 표시
            OpClicked = true;
        }
        private void C_Click(object sender, EventArgs e) // C (완전 초기화)
        {
            num1 = 0;
            num2 = 0;
            op = "";
            OpClicked = false;
            TotalDisplay.Text = "";
            CurrentDisplay.Text = "";
        }

        private void CE_Click(object sender, EventArgs e) //CE (현재 입력중인 숫자만 초기화)
        {
            string current = CurrentDisplay.Text; // 상단 식에서 현재 입력된 숫자만큼 삭제
            if (string.IsNullOrEmpty(current)) return;

            int lengthToRemove = current.Length;
            if (TotalDisplay.Text.Length >= lengthToRemove)
            {
                TotalDisplay.Text = TotalDisplay.Text.Substring(0, TotalDisplay.Text.Length - lengthToRemove);
            }

            // 2. 하단 창 비우기
            CurrentDisplay.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
        }

        private void Del_Click(object sender, EventArgs e)
        {
            // 하단 창에 지울 글자가 있는지 체크
            if (CurrentDisplay.Text.Length > 0)
            {
                // 하단 창 마지막 글자 삭제
                CurrentDisplay.Text = CurrentDisplay.Text.Substring(0, CurrentDisplay.Text.Length - 1);

                // 상단 창에 지울 글자가 있는지 체크
                // 상단 창 마지막 글자 삭제 
                if (TotalDisplay.Text.Length > 0)
                {
                    TotalDisplay.Text = TotalDisplay.Text.Substring(0, TotalDisplay.Text.Length - 1);
                }

            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            // 이미 소수점이 있는지 확인
            if (!CurrentDisplay.Text.Contains("."))
            {
                    CurrentDisplay.Text += ".";
                    TotalDisplay.Text += ".";
                
            }
        }

        private void Negate_Click(object sender, EventArgs e)
        {
            // 입력된 값이 있는지 확인
            if (string.IsNullOrEmpty(CurrentDisplay.Text) || CurrentDisplay.Text == "0") return;

            // 현재 숫자를 변환해서 -1 곱하기
            decimal tempNum = decimal.Parse(CurrentDisplay.Text);
            tempNum = tempNum * -1;

            // 상단 창 업데이트 
            string oldVal = CurrentDisplay.Text;
            string newVal = tempNum.ToString();

            // 식의 맨 마지막에 있는 현재 숫자만 새 숫자로 교체
            int lastIndex = TotalDisplay.Text.LastIndexOf(oldVal);
            if (lastIndex != -1)
            {
                // 기존 숫자를 지우고 부호가 바뀐 숫자를 삽입
                TotalDisplay.Text = TotalDisplay.Text.Remove(lastIndex, oldVal.Length).Insert(lastIndex, newVal);
            }

            // 하단 창 업데이트
            CurrentDisplay.Text = newVal;
        }
    }
}
