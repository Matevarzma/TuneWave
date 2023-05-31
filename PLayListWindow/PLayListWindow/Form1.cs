namespace PlayListWindow;
public partial class Form1 : Form
{


    public Form1()
    {
        InitializeComponent();

    }

    private void PLayingButton_Click(object sender, EventArgs e)
    {
        indicator.Top = PLayingButton.Top;
        bunifuPages1.SetPage(0);
    }

    private void ExploreButton_Click(object sender, EventArgs e)
    {
        indicator.Top = ExploreButton.Top;
        bunifuPages1.SetPage(0);
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }
}
