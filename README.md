# NoesisWithUnity

In order to create a solution such as this one. Create your Unity Solution first and then delete the Asset folder.
Create your WPF Blend Solution to be at the root of the directory. If it creates another directory, move everything outside
and delete the new directory.

Leave the main App.config, App.xaml, and MainWindow.xaml files alone. Create sub directories inside of the Assets folder to
work with xaml files. These base ones are required for WPF to run correctly.

The UserDesign csproj file is the one you want to work with with this solution. Make sure to use Blend instead of Visual Studio
Proper though as blend gives you more control over the XAML design and won't have the XAML files disappear on you.