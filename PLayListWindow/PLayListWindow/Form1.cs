using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

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
        ofd.Multiselect = true;
        if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            paths = ofd.FileNames;
            files = ofd.SafeFileNames;

            for (int i = 0; i < files.Length; i++)
            {
                ListOfSongs.Items.Add(files[i]);

            }
        }

    }

    private void bunifuImageButton1_Click(object sender, EventArgs e)
    {
       
    }

    private void bunifuImageButton3_Click(object sender, EventArgs e)
    {
        
    }

    private void bunifuImageButton4_Click(object sender, EventArgs e)
    {

    }
}
