namespace AntonLeoApp.Model.Services.UserIO;

public class UserCharacter
{
    // Свойства делаем публичными для чтения, но приватными для записи извне
    public string Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string Image { get; private set; }

    // Конструктор делаем внутренним, чтобы заставить использовать Builder
    internal UserCharacter(string id, string name, string description, string image)
    {
        Id = id;
        Name = name;
        Description = description;
        Image = image;
    }

    // Статический метод для начала сборки
    public static UserCharacterBuilder CreateBuilder() => new UserCharacterBuilder();
}