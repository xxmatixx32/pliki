using System.Drawing;

namespace BlackThemeApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        ConfigureTheme();
    }

    private void ConfigureTheme()
    {
        BackColor = Color.FromArgb(18, 18, 18);
        ForeColor = Color.White;
    }

    private void OnFunctionButtonClick(object? sender, EventArgs e)
    {
        if (sender is Button button)
        {
            statusLabel.Text = $"Uruchomiono funkcję: {button.Text}";
        }
    }
}
