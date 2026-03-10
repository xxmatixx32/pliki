namespace BlackThemeApp;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        functionButton1 = new Button();
        functionButton2 = new Button();
        functionButton3 = new Button();
        functionButton4 = new Button();
        statusLabel = new Label();
        SuspendLayout();
        // 
        // functionButton1
        // 
        functionButton1.BackColor = Color.FromArgb(32, 32, 32);
        functionButton1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
        functionButton1.FlatStyle = FlatStyle.Flat;
        functionButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        functionButton1.ForeColor = Color.White;
        functionButton1.Location = new Point(24, 28);
        functionButton1.Name = "functionButton1";
        functionButton1.Size = new Size(150, 60);
        functionButton1.TabIndex = 0;
        functionButton1.Text = "1";
        functionButton1.UseVisualStyleBackColor = false;
        functionButton1.Click += OnFunctionButtonClick;
        // 
        // functionButton2
        // 
        functionButton2.BackColor = Color.FromArgb(32, 32, 32);
        functionButton2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
        functionButton2.FlatStyle = FlatStyle.Flat;
        functionButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        functionButton2.ForeColor = Color.White;
        functionButton2.Location = new Point(198, 28);
        functionButton2.Name = "functionButton2";
        functionButton2.Size = new Size(150, 60);
        functionButton2.TabIndex = 1;
        functionButton2.Text = "2";
        functionButton2.UseVisualStyleBackColor = false;
        functionButton2.Click += OnFunctionButtonClick;
        // 
        // functionButton3
        // 
        functionButton3.BackColor = Color.FromArgb(32, 32, 32);
        functionButton3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
        functionButton3.FlatStyle = FlatStyle.Flat;
        functionButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        functionButton3.ForeColor = Color.White;
        functionButton3.Location = new Point(24, 108);
        functionButton3.Name = "functionButton3";
        functionButton3.Size = new Size(150, 60);
        functionButton3.TabIndex = 2;
        functionButton3.Text = "3";
        functionButton3.UseVisualStyleBackColor = false;
        functionButton3.Click += OnFunctionButtonClick;
        // 
        // functionButton4
        // 
        functionButton4.BackColor = Color.FromArgb(32, 32, 32);
        functionButton4.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
        functionButton4.FlatStyle = FlatStyle.Flat;
        functionButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        functionButton4.ForeColor = Color.White;
        functionButton4.Location = new Point(198, 108);
        functionButton4.Name = "functionButton4";
        functionButton4.Size = new Size(150, 60);
        functionButton4.TabIndex = 3;
        functionButton4.Text = "4";
        functionButton4.UseVisualStyleBackColor = false;
        functionButton4.Click += OnFunctionButtonClick;
        // 
        // statusLabel
        // 
        statusLabel.Font = new Font("Segoe UI", 10F);
        statusLabel.ForeColor = Color.Gainsboro;
        statusLabel.Location = new Point(24, 190);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(324, 46);
        statusLabel.TabIndex = 4;
        statusLabel.Text = "Kliknij przycisk funkcyjny 1, 2, 3 lub 4.";
        statusLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(372, 258);
        Controls.Add(statusLabel);
        Controls.Add(functionButton4);
        Controls.Add(functionButton3);
        Controls.Add(functionButton2);
        Controls.Add(functionButton1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Aplikacja funkcyjna - czarny motyw";
        ResumeLayout(false);
    }

    #endregion

    private Button functionButton1;
    private Button functionButton2;
    private Button functionButton3;
    private Button functionButton4;
    private Label statusLabel;
}
