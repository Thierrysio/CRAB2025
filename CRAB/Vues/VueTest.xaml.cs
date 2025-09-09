using CRAB.Modeles;

namespace CRAB.Vues;

public partial class VueTest : ContentPage
{
	public VueTest()
	{
		InitializeComponent();
		Station s = new Station(1, "station1");
		monLabel.Text = s.LibelleEmplacement;
		
	}
}