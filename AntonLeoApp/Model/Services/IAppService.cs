using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public interface IAppService {
    Task<List<CharacterDto>> GetCharacters();
    Task<CharacterDto> GetCharacter(string characterId);
}