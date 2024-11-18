namespace Stack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtElement = new TextBox();
            label1 = new Label();
            btnPush = new Button();
            btnPop = new Button();
            btnIsEmpty = new Button();
            btnTop = new Button();
            btnSize = new Button();
            lstStack = new ListBox();
            SuspendLayout();
            // 
            // txtElement
            // 
            txtElement.Font = new Font("Segoe UI", 15F);
            txtElement.Location = new Point(342, 69);
            txtElement.Name = "txtElement";
            txtElement.Size = new Size(127, 34);
            txtElement.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(267, 27);
            label1.Name = "label1";
            label1.Size = new Size(267, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter a number into the stack";
            // 
            // btnPush
            // 
            btnPush.Location = new Point(97, 127);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(89, 30);
            btnPush.TabIndex = 2;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(222, 127);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(89, 30);
            btnPop.TabIndex = 3;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnIsEmpty
            // 
            btnIsEmpty.Location = new Point(479, 127);
            btnIsEmpty.Name = "btnIsEmpty";
            btnIsEmpty.Size = new Size(89, 30);
            btnIsEmpty.TabIndex = 5;
            btnIsEmpty.Text = "IsEmpty";
            btnIsEmpty.UseVisualStyleBackColor = true;
            btnIsEmpty.Click += btnIsEmpty_Click;
            // 
            // btnTop
            // 
            btnTop.Location = new Point(354, 127);
            btnTop.Name = "btnTop";
            btnTop.Size = new Size(89, 30);
            btnTop.TabIndex = 4;
            btnTop.Text = "Top";
            btnTop.UseVisualStyleBackColor = true;
            btnTop.Click += btnTop_Click;
            // 
            // btnSize
            // 
            btnSize.Location = new Point(602, 127);
            btnSize.Name = "btnSize";
            btnSize.Size = new Size(89, 30);
            btnSize.TabIndex = 6;
            btnSize.Text = "Size";
            btnSize.UseVisualStyleBackColor = true;
            btnSize.Click += btnSize_Click;
            // 
            // lstStack
            // 
            lstStack.FormattingEnabled = true;
            lstStack.ItemHeight = 15;
            lstStack.Location = new Point(342, 204);
            lstStack.Name = "lstStack";
            lstStack.Size = new Size(117, 64);
            lstStack.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstStack);
            Controls.Add(btnSize);
            Controls.Add(btnIsEmpty);
            Controls.Add(btnTop);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(label1);
            Controls.Add(txtElement);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtElement;
        private Label label1;
        private Button btnPush;
        private Button btnPop;
        private Button btnIsEmpty;
        private Button btnTop;
        private Button btnSize;
        private ListBox lstStack;
    }
}
