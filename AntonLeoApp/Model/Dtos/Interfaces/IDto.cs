namespace AntonLeoApp.Model.Dtos;

public interface IDto
{
    string? Id { get; set; }
    string? Name { get; set; }
    string? Description { get; set; }
    string? Image { get; set; }
}