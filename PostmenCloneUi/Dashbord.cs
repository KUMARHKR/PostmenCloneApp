using PostmenCloneLibrary;

namespace PostmenCloneUi;

public partial class Dashbord : Form
{

    private readonly IApiAccess api = new ApiAccess();
    public Dashbord()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {

        //Validate input API key
        if (!api.IsValidUrl(apiText.Text))
        {
            resultsText.Text = "Invalid URL";
            return;
        }

        try
        {
            systemStatus.Text = "Calling API ...";

            resultsText.Text = await api.CallApiAsync(apiText.Text);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsLabel.Text = "Error : " + ex.Message;
            systemStatus.Text = "Error";
        }
    }

    private void resultsText_TextChanged(object sender, EventArgs e)
    {

    }

    private void Dashbord_Load(object sender, EventArgs e)
    {

    }
}
