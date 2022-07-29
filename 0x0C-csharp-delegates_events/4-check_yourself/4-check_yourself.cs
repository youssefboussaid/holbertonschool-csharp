using System;
/// <summary>
/// class player 
/// </summary>

    class Player
    {
        string name;
        float maxHp;
        float hp;
        string status;


        public Player(string name = "Player", float maxHp= 100f)
        {
            this.name = name;
            if (maxHp <= 0){
                maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            }
            this.hp = maxHp;
            this.maxHp = maxHp;
            status = $"{this.name}  is ready to go!";
            HPCheck += CheckStatus;
        }

        public void PrintHealth()
        {
            Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
        }
    
    public delegate void CalculateHealth(float amount);

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
        HPCheck(this, new CurrentHPArgs(hp));
    }

	/// <summary>
	/// TakeDamage: method
	/// </summary>
	/// <param name="damage">float</param>
	public void TakeDamage(float damage)
    {
        float newHp = hp;
		if(damage < 0)
        {
			damage = 0f;
			Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
			Console.WriteLine($"{name} takes {damage} damage!");
            newHp = hp - damage;
        }
        ValidateHP(newHp);
    }

	/// <summary>
	/// HealDamage: method
	/// </summary>
	/// <param name="heal">float</param>
	public void HealDamage(float heal)
    {

        float newHp = hp;
		if(heal < 0)
        {
			heal = 0f;
			Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
			Console.WriteLine($"{name} heals {heal} HP!");
            newHp = hp + heal;
        }
        ValidateHP(newHp);
    }
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return (baseValue*0.5f);
        }
        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }
        else if (modifier == Modifier.Strong)
        {
            return (baseValue*1.5f);
        }
        else
        {
            return baseValue;
        }
    }


    public event  EventHandler<CurrentHPArgs> HPCheck;

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = ($"{name} is in perfect health!");
        }
        else if (e.currentHp >= maxHp / 2f )
        {
            status = ($"{name} is doing well!");
        }
        else if (e.currentHp >= maxHp / 4f)
        {
            status = ($"{name} isn't doing too great...");
        }
        else if (e.currentHp > 0)
        {
            status = ($"{name} needs help!");
        }
        else
        {
            status = ($"{name} is knocked out");
        }
        Console.WriteLine(status);
    }


    }

    /// <summary>
    /// Damage or Heal modifier
    /// </summary>
    public enum Modifier{
    /// <summary>
    /// Weak modifier
    /// </summary>
        Weak,

    /// <summary>
    /// Base modifier
    /// </summary>
        Base,

    /// <summary>
    /// Strong modifier
    /// </summary>
        Strong

    }
    /// <summary>
/// CalculateModifier: delegate
/// </summary>
/// <param name="baseValue">float</param>
/// <param name="modifier">Modifier</param>
/// <returns>float</returns>
    public delegate float CalculateModifier(float baseValue, Modifier modifier);


/// <summary>
/// CurrentHPArgs class that inherits from EventArgs.
/// </summary>
    public class CurrentHPArgs: EventArgs
    {
        /// <summary>
    /// Player's current health.
    /// </summary>
        public readonly float currentHp;
    /// <summary>
    /// constructor.
    /// </summary>
    /// <param name="newHp">The new value of health.</param>
        public CurrentHPArgs(float newHp)
        {
            currentHp = newHp;
        }
            
    }

    




