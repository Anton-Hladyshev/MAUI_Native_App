using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public interface IAppService {
    Task<List<CharacterDto>> GetCharacters();
    Task<CharacterDto> GetCharacter(string characterId);
    Task<CreatureDto> GetCreature(string creatureId);
    Task<List<CreatureDto>> GetCreatures();
    Task<DroidDto> GetDroid(string creatureId);
    Task<List<DroidDto>> GetDroids();
}