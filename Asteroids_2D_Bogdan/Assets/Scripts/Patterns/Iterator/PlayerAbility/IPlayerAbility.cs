namespace Asteroids2D
{
    public interface IPlayerAbility
    {
         public string Name { get; }
         public int Damage { get; }
         public Target Target { get; }
    }
}