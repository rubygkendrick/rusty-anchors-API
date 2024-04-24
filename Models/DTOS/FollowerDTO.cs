namespace RustyAnchorsApi.Models.DTOS;

public class FollowerDTO
{
    public int Id { get; set; }
    public int PirateId { get; set; }
    public int FollowerId { get; set; }
    public PirateDTO? Pirate { get; set; }
}