namespace main;

public interface IInterractionBehavior
{
    public void Interract();
}
public abstract class Character
{
    protected IInterractionBehavior _interractionBehavior;
    
    public Character (IInterractionBehavior interractionBehavior)
    {
        _interractionBehavior = interractionBehavior;
    }
    public abstract void Move();
    public virtual void Interract()
    {
        if(_interractionBehavior != null)
        {
            _interractionBehavior.Interract();
        }
    }

}

public class Warrior : Character
{
    public Warrior(IInterractionBehavior interractionBehavior):base(interractionBehavior){}
    public override void Move()
    {
        Console.WriteLine("Moved Warrior");
    }
}
public class Merchant : Character
{
    public Merchant(IInterractionBehavior interractionBehavior):base(interractionBehavior){}
    public override void Move()
    {
        Console.WriteLine("Moved Merchant");
    }
}

public class TradeBehavior : IInterractionBehavior
{
    public void Interract()
    {
        Console.WriteLine("Made Trade");
    }
}

public class AttackBehavior : IInterractionBehavior
{
    public void Interract()
    {
        Console.WriteLine("Damage");
    }
}

