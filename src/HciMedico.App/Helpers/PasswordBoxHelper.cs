using System.Reflection;
using System.Windows;
using Wpf.Ui.Controls;

namespace HciMedico.App.Helpers;

public static class PasswordBoxHelper
{
    public static readonly DependencyProperty BoundPasswordProperty =
        DependencyProperty.RegisterAttached(
            "BoundPassword",
            typeof(string),
            typeof(PasswordBoxHelper),
            new FrameworkPropertyMetadata(string.Empty, OnBoundPasswordChanged)
        );

    public static string GetBoundPassword(DependencyObject depObj)
    {
        var box = depObj as PasswordBox;

        if (box is not null)
        {
            box.PasswordChanged -= PasswordChanged;
            box.PasswordChanged += PasswordChanged;
        }

        return (string)depObj.GetValue(BoundPasswordProperty);
    }

    public static void SetBoundPassword(DependencyObject depObj, string value)
    {
        if (string.Equals(value, GetBoundPassword(depObj))) return;

        depObj.SetValue(BoundPasswordProperty, value);
    }

    private static void OnBoundPasswordChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
    {
        var box = depObj as PasswordBox;

        if (box is null) return;

        box.Password = GetBoundPassword(depObj);
    }

    private static void PasswordChanged(object sender, RoutedEventArgs e)
    {
        var password = sender as PasswordBox;

        if (password is null) return;

        SetBoundPassword(password, password.Password);

        password
            .GetType()
            ?.GetMethod("Select", BindingFlags.Instance | BindingFlags.NonPublic)
            ?.Invoke(password, [password.Password.Length, 0]);
    }
}