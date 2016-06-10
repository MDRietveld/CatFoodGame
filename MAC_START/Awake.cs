using System;
using Microsoft.Xna.Framework.Graphics;

namespace ProefTentamen
{
	public class Awake : IState
	{
		//Awake moet alleen een functie uitvoeren vanuit de constructor waardoor de kat aan de list wordt toegevoegd, 
		//zodat FoodBowl een message kan senden waardoor de kat kan eten
		public Cat cat{ get; set; }
		public Awake (Cat c)
		{
			cat = c;
			cat.Texture = Game1.instance.Content.Load<Texture2D> ("cat_awake");
			cat.RegisterCat ();
		}

		public void StateClick ()
		{
		}

		public void Update (Microsoft.Xna.Framework.GameTime gameTime)
		{
			
		}
	}
}

