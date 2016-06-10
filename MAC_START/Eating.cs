using System;
using Microsoft.Xna.Framework.Graphics;

namespace ProefTentamen
{
	public class Eating : IState
	{
		public Cat cat{ get; set; }
		float _time = 0;
		public Eating (Cat c)
		{
			cat = c;
			cat.Texture = Game1.instance.Content.Load<Texture2D> ("cat_eating");
		}

		public void StateClick ()
		{
			
		}

		//Eating moet een update met _time, de tijd gaat lopen en als er 1 seconde verstreken is dan zal de ChangeState uitgevoerd worden
		public void Update (Microsoft.Xna.Framework.GameTime gameTime)
		{
			_time += (float)gameTime.ElapsedGameTime.TotalSeconds;

			if (_time > 1) {
				cat.ChangeState(new Playing (cat));
			}
		}
	}
}

