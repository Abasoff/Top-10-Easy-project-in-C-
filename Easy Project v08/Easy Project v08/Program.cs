using System;
using System.IO;

class Program
{

    //-----------------------------------------------------------
    /* This project made by Anar Abasov
    * Basic File Manager: Build a simple file management tool that allows users to navigate directories, create, delete, and view files.*/
    //-----------------------------------------------------------


static string currentDirectory = Directory.GetCurrentDirectory();

static void Main(string[] args)
{
    Console.WriteLine("Basic File Manager");
    ShowMenu();

    while (true)
    {
        Console.Write("Select an option: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ListFoldersAndFiles();
                break;
            case "2":
                CreateFolder();
                break;
            case "3":
                DeleteFolder();
                break;
            case "4":
                NavigateToFolder();
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}

static void ShowMenu()
{ 
    Console.WriteLine("----------------------");
    Console.WriteLine("Basic File Manager");
    Console.WriteLine("----------------------");
    Console.WriteLine("Choose an operation:");
    Console.WriteLine("1. List Folders and Files");
    Console.WriteLine("2. Create Folder");
    Console.WriteLine("3. Delete Folder");
    Console.WriteLine("4. Navigate to Folder");
    Console.WriteLine("5. Exit");
}

static void ListFoldersAndFiles()
{
    try
    {
        string[] items = Directory.GetFileSystemEntries(currentDirectory);
        Console.WriteLine($"Contents of {currentDirectory}:");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}

static void CreateFolder()
{
    Console.Write("Enter the folder name: ");
    string folderName = Console.ReadLine().Trim();
    string folderPath = Path.Combine(currentDirectory, folderName);

    try
    {
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine($"Folder '{folderName}' created successfully!");
        }
        else
        {
            Console.WriteLine($"Folder '{folderName}' already exists.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}

static void DeleteFolder()
{
    Console.Write("Enter the folder name to delete: ");
    string folderName = Console.ReadLine().Trim();
    string folderPath = Path.Combine(currentDirectory, folderName);

    try
    {
        if (Directory.Exists(folderPath))
        {
            Directory.Delete(folderPath, true);
            Console.WriteLine($"Folder '{folderName}' removed successfully!");
        }
        else
        {
            Console.WriteLine($"Folder '{folderName}' doesn't exist.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}

static void NavigateToFolder()
{

    Console.Write("Enter the folder path to navigate to: ");
    string folderPath = Console.ReadLine().Trim();

    try
    {
        if (Directory.Exists(folderPath))
        {
            currentDirectory = folderPath;
            Console.WriteLine($"Navigated to folder: {currentDirectory}");
        }
        else
        {
            Console.WriteLine("Folder does not exist.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}
}
