using System;
/// <summary>
/// obstract class
/// </summary>



public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return ($"{name} is a {this.GetType()}");
    }


}

public class TestObject: Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    void Interact()
    {

    }

    void Break()
    {

    }

    void Collect()
    {

    }

}