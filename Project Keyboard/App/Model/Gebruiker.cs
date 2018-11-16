using System;

/// Summary description for Class1
/// 
public class Gebruiker
{
    private string gebruikersnaam { get; set; }
    private string password { get; set; }
    private string voornaam { get; set; }
    private string achternaam { get; set; }
    private int leeftijd { get; set; }

    public Gebruiker (string gebruikersnaam_, string password_, string voornaam_, string achternaam_, int leeftijd)
    {
        gebruikersnaam_ = gebruikersnaam;
        password_ = password;
        voornaam_ = voornaam;
        achternaam_ = achternaam;
        leeftijd_ = leeftijd;
    }
}
