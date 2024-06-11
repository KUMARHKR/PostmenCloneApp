namespace PostmenCloneUi;

public partial class Dashbord : Form
{
    public Dashbord()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {

        //Validate input API key

        try
        {
            systemStatus.Text = "Calling API ...";

            // Sample code  - Replace with api call code
            await Task.Delay(2000);

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
}
