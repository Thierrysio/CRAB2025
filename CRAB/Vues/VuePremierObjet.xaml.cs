using CRAB.Modeles;

namespace CRAB.Vues;

public partial class VuePremierObjet : ContentPage
{
	public VuePremierObjet()
	{
		InitializeComponent();
	}

    private void buttonValider_Clicked(object sender, EventArgs e)
    {
		int id = int.Parse(monId.Text);
		string libelle = monLibelle.Text;

		Station s = new Station (id, libelle);

    }
}