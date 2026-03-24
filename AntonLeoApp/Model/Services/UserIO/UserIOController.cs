using System.Text.Json;
using System.Text.Encodings.Web;

namespace AntonLeoApp.Model.Services.UserIO;

public class UserIOController
{
    private readonly string _dataPath = Path.Combine(FileSystem.AppDataDirectory, "local.json");
    private const string _mediaPath = "../../Data/media/";

    private readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    };

    public async Task<List<UserCharacter>> GetAllCaharacters()
    {
        if (!File.Exists(_dataPath))
        {
            return new List<UserCharacter>();
        }

        try
        {
            string json = await File.ReadAllTextAsync(_dataPath);
            return JsonSerializer.Deserialize<List<UserCharacter>>(json) ?? new List<UserCharacter>();
        }
        catch
        {
            return new List<UserCharacter>();
        }
    }
}