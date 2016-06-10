using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace ProefTentamen
{
	public class Sleeping : IState
	{
		public Cat cat{ get; set; }
		public Sleeping (Cat c)
		{
			cat = c;
			cat.Texture = Game1.instance.Content.Load<Texture2D> ("cat_sleeping");
		}

		//Als de kat wordt geklikt wordt deze functie uitgevoerd waardoor de ChangeState in cat wordt uitgevoerd, 
		//met de parameter new Awake(cat) waardoor de state veranderd wordt
		public void StateClick()
		{
			cat.ChangeState(new Awake (cat));
		}

		public void Update (GameTime gameTime)
		{
			
		}
	}
}

