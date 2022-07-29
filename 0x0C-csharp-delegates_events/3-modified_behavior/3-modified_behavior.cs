using System;
/// <summary>
/// class player 
/// </summary>

    class Player
    {
        string name;
        float maxHp;
        float hp;

        public Player(string name = "Player", float maxHp= 100f)
        {
            this.name = name;
            if (maxHp <= 0){
                maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            }
            this.hp = maxHp;
            this.maxHp = maxHp;
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

    




