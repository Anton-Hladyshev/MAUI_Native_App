using System.Text.Json;
using System.Text.Encodings.Web;
using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services.UserIO;

public class UserIOController
{
    private readonly string _dataPath = Path.Combine(FileSystem.AppDataDirectory, "local.json");

    private readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    };

    public async Task<List<CharacterDto>> GetAllCharacterDosAsync()
    {
        if (!File.Exists(_dataPath))
        {
            return new List<CharacterDto>();
        }

        try
        {
            string json = await File.ReadAllTextAsync(_dataPath);
            return JsonSerializer.Deserialize<List<CharacterDto>>(json) ?? new List<CharacterDto>();
        }
        catch
        {
            return new List<CharacterDto>();
        }
    }

    public async Task SaveCharacterAsync(UserCharacter character)
    {
        var dtos = await GetAllCharacterDosAsync();
        
        var characterDto = character.ToDto();

        var index = dtos.FindIndex(d => d.Id == characterDto.Id);
        if (index == -1) 
            dtos.Add(characterDto);
        else
            dtos[index] = characterDto;
        
        string json = JsonSerializer.Serialize(dtos, _options);
        await File.WriteAllTextAsync(_dataPath, json);
    }
}