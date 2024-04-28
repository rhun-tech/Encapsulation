public class Weapon
{
    private string name;
    private int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public string GetName()
    {
        return name;
    }

    public int GetDamage()
    {
        return damage;
    }

    // Method to attack with the weapon
    public void Attack()
    {
        Console.WriteLine($"Attacking with {name} - Damage: {damage}");
    }
}

public class Knight
{
    private string name;
    private Weapon weapon;

    public Knight(string name, Weapon weapon)
    {
        this.name = name;
        this.weapon = weapon;
    }

    public void Attack()
    {
        Console.WriteLine($"{name} is attacking!");
        weapon.Attack();
    }

    public void EquipWeapon(Weapon newWeapon)
    {
        weapon = newWeapon;
        Console.WriteLine($"{name} has equipped {newWeapon.GetName()}!");
    }
}

class Program
{
    static void Main()
    {
        // Creating weapons
        Weapon sword = new Weapon("Sword", 20);
        Weapon axe = new Weapon("Axe", 25);

        // Creating a knight
        Knight knight = new Knight("Sir Lancelot", sword);

        // Knight attacks with initial weapon
        knight.Attack();

        // Knight equips a new weapon
        knight.EquipWeapon(axe);

        // Knight attacks with the new weapon
        knight.Attack();
    }
}
