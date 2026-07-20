using Microsoft.EntityFrameworkCore;
using VideoGameCharacterApi.Data;
using VideoGameCharacterApi.Dtos;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services;

public class VideoGameCharacterApiService(AppDbContext context) : IVideoGameCharactersService
{   
    public async Task<CharacterResponse> AddCharacterAsync(CreateCharacterRequest character)
    {
        var newCharacter = new Character
        {
            Name = character.Name,
            Game = character.Game,
            Role = character.Role
        };

        context.Characters.Add(newCharacter);
        await context.SaveChangesAsync();

        return new CharacterResponse
        {
            Id = newCharacter.Id,
            Name = newCharacter.Name,
            Game = newCharacter.Game,
            Role = newCharacter.Role
        };
    }

    public Task<bool> DeleteCharacterAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CharacterResponse>> GetAllCharactersAsync()
        => await context.Characters.Select(c => new CharacterResponse
        {
            Id = c.Id,
            Name = c.Name,
            Game = c.Game,
            Role = c.Role
        }).ToListAsync();

    public async Task<CharacterResponse?> GetCharacterByIdAsync(int id)
    {
        var result = await context.Characters
            .Where(c => c.Id == id)
            .Select(c => new CharacterResponse
            {
                Id = c.Id,
                Name = c.Name,
                Game = c.Game,
                Role = c.Role
            }).FirstOrDefaultAsync();
        return result;
    }

    public Task<bool> UpdateCharacterAsync(int id, UpdateCharacterRequest character)
    {
        throw new NotImplementedException();
    }
}