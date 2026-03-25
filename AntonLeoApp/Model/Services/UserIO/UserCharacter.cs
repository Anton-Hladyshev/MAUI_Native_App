using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services.UserIO;

public class UserCharacter
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string Image { get; private set; }
    
    internal UserCharacter(string id, string name, string description, string image)
    {
        Id = id;
        Name = name;
        Description = description;
        Image = image;
    }

    public CharacterDto ToDto() => new CharacterDto
    {
        Id = Id,
        Name = Name,
        Description = Description,
        Image = Image
    };

    public static UserCharacter FromDto(CharacterDto dto)
    {
        return new UserCharacter(
            dto.Id ?? Guid.NewGuid().ToString("n").Substring(0, 24),
            dto.Name ?? string.Empty,
            dto.Description ?? string.Empty,
            dto.Image ?? string.Empty
        );
    }
    
    public static UserCharacterBuilder CreateBuilder() => new UserCharacterBuilder();
}