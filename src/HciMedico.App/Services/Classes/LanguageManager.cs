using HciMedico.Domain.Models.Enums;
using System.Windows;

namespace HciMedico.App.Services.Classes;

public static class LanguageManager
{
    public static void SetLanguage(ApplicationLanguage? language = null)
    {
        ResourceDictionary languageDictionary = [];

        languageDictionary.Source = language switch
        {
            ApplicationLanguage.Serbian => new Uri("Resources/Language/Strings.sr.xaml", UriKind.Relative),

            // English by default
            _ => new Uri("Resources/Language/Strings.en.xaml", UriKind.Relative),
        };
        Application.Current.Resources.MergedDictionaries.Add(languageDictionary);

        if (UserContext.CurrentUser is not null)
            UserContext.CurrentUser.UserSettings.ApplicationLanguage = language ?? ApplicationLanguage.English;
    }
}
