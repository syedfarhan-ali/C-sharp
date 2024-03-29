namespace CS;

using System.Collections;

class Wizard
{
   public string name;
   public string favoriteSpell;
   private int spellSlots;
   private float experience;

   public Wizard(string _name,string _favoriteSpell)
   {
      name = _name;
      favoriteSpell = _favoriteSpell;
      spellSlots = 10;
      experience = 0f;
   }

   public void castSpell()
   {
      if (spellSlots > 0)
      {
         Console.WriteLine( "-------------------------------------\nEXP : "+experience);
        
         Console.WriteLine(name + " casts "+favoriteSpell);
         spellSlots--;
         experience += 0.3f;
         Console.WriteLine( "EXP : "+experience);
         Console.WriteLine("Spell Slots :"+spellSlots);

      }else
      {
         Console.WriteLine(name +" is out of spells.");
      }
      
   }
}
class Program
{
    static void Main(string[] args)
   {
      Wizard wiz1 = new Wizard("kallu majdoor","majdoori");
      wiz1.castSpell();
      Wizard wiz2 = new Wizard("racoon","momos");
      wiz2.castSpell();
      Console.ReadKey();
   }
}
