using System.Drawing;

namespace PlayListWindow;
public partial class Form1 : Form
{


    public Form1()
    {
        InitializeComponent();


    }

    String[] paths, files;
    private void PLayingButton_Click(object sender, EventArgs e)
    {
        indicator.Top = PLayingButton.Top;
        bunifuPages1.SetPage(0);
    }

    private void ExploreButton_Click(object sender, EventArgs e)
    {
        indicator.Top = ExploreButton.Top;
        bunifuPages1.SetPage(1);
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {
    }

    private void ImportMusicButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();

        if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            paths = ofd.FileNames;
            files = ofd.SafeFileNames;

            for (int i = 0; i < files.Length; i++)
            {
                SongsList.Items.Add(files[i]);
            }
        }
    }
}
