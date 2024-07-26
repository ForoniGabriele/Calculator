namespace Calcolatrice {
    public partial class Form1 : Form {
        string[] nums = new string[1];
        double ans;

        public Form1() {
            InitializeComponent();
            //esponente per il tasto x10^x
            OFF.Cursor = Cursors.Hand;
        }
        //chiude il programma
        private void OFF_Click(object sender, EventArgs e) {
            Close();
        }
        //cancella tutto nella barra del risultato
        private void bAC_Click(object sender, EventArgs e) {
            EXPRESSION.Text = RESULT.Text = "";
            nums = new string[1];
        }

        public void calcola_e_sposta(double res, int i) {
            nums[i - 1] = res.ToString();

            for (int j = i; j < nums.Length - 2; j++) {
                nums[j] = nums[j + 2];
            }
            res = Convert.ToDouble(nums[0]);
            Array.Resize(ref nums, nums.Length - 2);
        }

        private void calculateResult() {
            double result = 0;

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == "*") {
                    result = Convert.ToDouble(nums[i - 1]) * Convert.ToDouble(nums[i + 1]);
                    calcola_e_sposta(result, i);
                    i = 0;
                }
                if (nums[i] == "/") {
                    result = Convert.ToDouble(nums[i - 1]) / Convert.ToDouble(nums[i + 1]);
                    calcola_e_sposta(result, i);
                    i = 0;
                }
            }
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == "+") {
                    result = Convert.ToDouble(nums[i - 1]) + Convert.ToDouble(nums[i + 1]);
                    calcola_e_sposta(result, i);
                    i = 0;
                }
                if (nums[i] == "-") {
                    result = Convert.ToDouble(nums[i - 1]) - Convert.ToDouble(nums[i + 1]);
                    calcola_e_sposta(result, i);
                    i = 0;
                }
            }
            nums = new string[1];
            nums[0] = result.ToString();
            ans = result;
            RESULT.Text = result.ToString();
        }


        private void b0_Click(object sender, EventArgs e) {
            if (EXPRESSION.Text != "" || EXPRESSION.Text != "0") {
                nums[nums.Length - 1] = "0";
                EXPRESSION.Text = String.Join("", nums);
            }
        }

        private void b1_Click(object sender, EventArgs e) {
            if (EXPRESSION.Text != "0") {
                nums[nums.Length - 1] += "1";
                EXPRESSION.Text = String.Join("", nums);
            }
        }

        private void b2_Click(object sender, EventArgs e) {
            if (EXPRESSION.Text != "0") {
                nums[nums.Length - 1] += "2";
                EXPRESSION.Text = String.Join("", nums);
            }
        }

        private void b3_Click(object sender, EventArgs e) {
            if (EXPRESSION.Text != "0") {
                nums[nums.Length - 1] += "3";
                EXPRESSION.Text = String.Join("", nums);
            }
        }

        private void b4_Click(object sender, EventArgs e) {
            if (EXPRESSION.Text != "0") {
                nums[nums.Length - 1] += "4";
                EXPRESSION.Text = String.Join("", nums);
            }
        }

        private void b5_Click(object sender, EventArgs e) {
            if (EXPRESSION.Text != "0") {
                nums[nums.Length - 1] += "5";
                EXPRESSION.Text = String.Join("", nums);
            }
        }

        private void b6_Click(object sender, EventArgs e) {
            if (EXPRESSION.Text != "0") {
                nums[nums.Length - 1] += "6";
                EXPRESSION.Text = String.Join("", nums);
            }
        }

        private void b7_Click(object sender, EventArgs e) {
            if (EXPRESSION.Text != "0") {
                nums[nums.Length - 1] += "7";
                EXPRESSION.Text = String.Join("", nums);
            }
        }

        private void b8_Click(object sender, EventArgs e) {
            if (EXPRESSION.Text != "0") {
                nums[nums.Length - 1] += "8";
                EXPRESSION.Text = String.Join("", nums);
            }
        }

        private void b9_Click(object sender, EventArgs e) {
            if (EXPRESSION.Text != "0") {
                nums[nums.Length - 1] += "9";
                EXPRESSION.Text = String.Join("", nums);
            }
        }


        private void bPlus_Click(object sender, EventArgs e) {
            Array.Resize(ref nums, nums.Length + 1);
            EXPRESSION.Text += "+";
            nums[nums.Length - 1] = "+";
            Array.Resize(ref nums, nums.Length + 1);
        }

        private void bMinus_Click(object sender, EventArgs e) {
            Array.Resize(ref nums, nums.Length + 1);
            EXPRESSION.Text += "-";
            nums[nums.Length - 1] = "-";
            Array.Resize(ref nums, nums.Length + 1);
        }

        private void bTimes_Click(object sender, EventArgs e) {
            Array.Resize(ref nums, nums.Length + 1);
            EXPRESSION.Text += "*";
            nums[nums.Length - 1] = "*";
            Array.Resize(ref nums, nums.Length + 1);
        }

        private void bDivide_Click(object sender, EventArgs e) {
            Array.Resize(ref nums, nums.Length + 1);
            EXPRESSION.Text += "/";
            nums[nums.Length - 1] = "/";
            Array.Resize(ref nums, nums.Length + 1);
        }

        private void bEquals_Click(object sender, EventArgs e) {
            Array.Resize(ref nums, nums.Length + 1);
            calculateResult();
        }

        private void bAns_Click(object sender, EventArgs e) {
            EXPRESSION.Text = ans.ToString();
            nums = new string[1];
            nums[0] = ans.ToString();
        }

        private void bD_Click(object sender, EventArgs e) {
            Array.Resize(ref nums, nums.Length - 1);
            EXPRESSION.Text = String.Join("", nums);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
