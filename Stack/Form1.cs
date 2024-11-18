namespace Stack
{
    public partial class Form1 : Form
    {
        private int[] stack = new int[10];
        private int top = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (top == stack.Length - 1)
            {
                MessageBox.Show("The stack is full.");
                return;
            }

            if (int.TryParse(txtElement.Text, out int value))
            {
                stack[++top] = value;
                txtElement.Clear();
                DisplayStack();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (top == -1)
            {
                MessageBox.Show("The stack is empty.");
                return;
            }

            top--;
            DisplayStack();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            if (top == -1)
            {
                MessageBox.Show("The stack is empty.");
            }
            else
            {
                MessageBox.Show($"Top element: {stack[top]}");
            }
        }

        private void btnIsEmpty_Click(object sender, EventArgs e)
        {
            MessageBox.Show(top == -1 ? "The stack is empty." : "The stack is not empty.");
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Stack size: {top + 1}");
        }

        private void DisplayStack()
        {
            lstStack.Items.Clear(); 
            for (int i = top; i >= 0; i--)
            {
                lstStack.Items.Add(stack[i]);
            }
        }
    }
}
