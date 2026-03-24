namespace AntonLeoApp.Model.Services.UserIO;

public class UserCharacterBuilder
{
    private string _id = Guid.NewGuid().ToString("n").Substring(0, 24);
    private string _name = "New Character";
    private string _description = " ";
    private string _image = "../../media/DefaultImage.png";

    public UserCharacterBuilder WithId(string id)
    {
        _id = id;
        return this;
    }

    public UserCharacterBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public UserCharacterBuilder WithDescription(string description)
    {
        _description = description;
        return this;
    }

    public UserCharacterBuilder WithImage(string image)
    {
        _image = image;
        return this;
    }

    public UserCharacter Build()
    {
        return new UserCharacter(_id, _name, _description, _image);
    }
}