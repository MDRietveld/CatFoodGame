using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProefTentamen
{
    class World
    {
		private Cat cat;
		private Cat cat2;
		private Cat cat3;
		private Cat cat4;
		FoodBowl bowl;
		private SpriteFont  _spVerdana;

        public World()
        {
			_spVerdana  = Game1.instance.Content.Load<SpriteFont>("Verdana");

			bowl = new FoodBowl (new Vector2 (20, 20));
			cat = new Cat (new Vector2 (70, 170), bowl);
			cat2 = new Cat (new Vector2 (420, 170), bowl);
			cat3 = new Cat (new Vector2 (240, 60), bowl);
			cat4 = new Cat (new Vector2 (240, 300), bowl);
        }

		public void Update(GameTime gameTime)
		{
			cat.Update (gameTime);
			cat2.Update (gameTime);
			cat3.Update (gameTime);
			cat4.Update (gameTime);
			bowl.Update (gameTime);
		}


		public void Draw(SpriteBatch spriteBatch)
        {
			cat.Draw (spriteBatch);
			cat2.Draw (spriteBatch);
			cat3.Draw (spriteBatch);
			cat4.Draw (spriteBatch);
			bowl.Draw (spriteBatch);


			spriteBatch.DrawString(_spVerdana, "Click on sleeping cats to wake them up", new Vector2(10, 460), Color.Black);
			spriteBatch.DrawString(_spVerdana, "Awake cats wait for food", new Vector2(10, 480), Color.Black);
			spriteBatch.DrawString(_spVerdana, "Click on food to feed waiting cats", new Vector2(10, 500), Color.Black);
			spriteBatch.DrawString(_spVerdana, "Eating will fall asleep after a while...", new Vector2(10, 520), Color.Black);
        }
    }
}
