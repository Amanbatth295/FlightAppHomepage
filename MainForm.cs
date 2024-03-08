@ -0,0 +1,24 @@
public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		// Add any initialization code here
	}

	private void btnAboutUs_Click(object sender, EventArgs e)
	{
		AboutUsForm aboutUsForm = new AboutUsForm();
		aboutUsForm.ShowDialog();
	}

	private void btnFindFlights_Click(object sender, EventArgs e)
	{
		FindFlightsForm findFlightsForm = new FindFlightsForm();
		findFlightsForm.ShowDialog();
	}
}
