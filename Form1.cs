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
            // 1. 피연산자 num2 가져오기
            num2 = double.Parse(CurrentDisplay.Text);
            double result = 0;

            // 2. 연산 수행
            switch (op)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "x": result = num1 * num2; break;
                case "÷": result = num1 / num2; break;
            }

            // 3. 결과값 반올림 (선택사항: 아까 만드신 roundedResult 변수 활용)
            double roundedResult = Math.Round(result, 2);

            // 4. [수정 포인트] 결과 출력 및 히스토리 저장
            // 상단 식에 " = 결과"를 딱 한 번만 추가합니다.
            string historyEntry = TotalDisplay.Text + " = " + roundedResult.ToString();

            TotalDisplay.Text = historyEntry;           // 상단 식 업데이트
            CurrentDisplay.Text = roundedResult.ToString(); // 하단 결과창 업데이트

            // 5. 리스트박스에 기록 추가
            listBoxHistory.Items.Add(historyEntry);

            // 6. 다음 계산을 위해 연산자 초기화
            op = "";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxHistory_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxHistory.SelectedItem != null)
            {
                string selectedItem = listBoxHistory.SelectedItem.ToString();

                // "식 = 결과값" 형태에서 '=' 이후의 값만 추출
                string[] parts = selectedItem.Split('=');
                if (parts.Length > 1)
                {
                    string lastResult = parts[1].Trim();

                    // 현재 입력창에 다시 넣어주기
                    CurrentDisplay.Text = lastResult;
                    TotalDisplay.Text = lastResult; // 새 계산을 위해 상단도 동기화
                }
            }
        }

        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
