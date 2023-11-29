namespace Program_4_Idea_Lo_Shu_Squares.Pages;

//Used to setup types of modes.
public enum GameMode { EASY, MEDIUM, HARD};

public partial class GamePage : ContentPage
{
	GameMode mode;

	public GamePage(GameMode mode = GameMode.EASY)
	{
		InitializeComponent();
		//This passes the game mode selection from the main menu to the game page. 
		this.mode = mode;
	}

    void CellInput(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
    }
    void OnMainMenuClicked(System.Object sender, System.EventArgs e)
    { 
        Application.Current.MainPage = new MainMenuPage(); 
    }

    void OnNewGameClicked(System.Object sender, System.EventArgs e)
    {
    }
    void OnHintClicked(System.Object sender, System.EventArgs e)
    {
    }
    void OnGridButtonClicked(System.Object sender, System.EventArgs e)
    {
    }
    void OnGetHintClicked(System.Object sender, System.EventArgs e)
    {
    }
    
}