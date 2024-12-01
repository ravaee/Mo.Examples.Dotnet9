

//NOTE: You can not use auto-property for both partial property members.
public partial class User
{
    // Declaring declaration
    public partial string Name { get; set; }
}

public partial class User
{

    // implementation declaration:
    private string _name;
    public partial string Name
    {
        get => _name;
        set => _name = value;
    }
}