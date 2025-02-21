string? roleNames;
bool validEntry = false;

do
{
    System.Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    roleNames = Console.ReadLine();
    if (roleNames != null)
    {
        roleNames = roleNames.Trim().ToLower();
    }
    if(roleNames == "administrator" || roleNames == "manager" || roleNames == "user")
        validEntry = true;
    else
    {
        Console.Write($"The role name that you entered, ({roleNames}) is not valid.\n");
    }
} while (validEntry == false);

System.Console.WriteLine($"Your input value ({roleNames}) has been accepted.");
