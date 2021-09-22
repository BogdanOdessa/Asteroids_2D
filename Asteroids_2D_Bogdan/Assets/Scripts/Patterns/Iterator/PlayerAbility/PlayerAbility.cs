namespace Asteroids2D
{
    public class PlayerAbility : IPlayerAbility
    {
        
        public string Name { get; }
        public int Damage { get; }
        public Target Target { get; }
        
        public PlayerAbility(string name, int damage, Target target)
        {
            Name = name;
            Damage = damage;
            Target = target;
        }
        
        public override string ToString()
        {
            return $"{Name}, damage: {Damage}, target: {Target}";
        }
    }
    
    
}