namespace NotesPL.Views;

public partial class AllNotesPage : ContentPage
{
	public AllNotesPage()
	{
		InitializeComponent();

	}
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        PLnotesCollection.SelectedItem = null;
    }

}