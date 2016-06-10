using System;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace ProefTentamen
{
	public class FoodBowl : GameObject
	{
		//List voor observers
		List<IObserver> observer = new List<IObserver> ();

		private MouseState _previousMouse;
		private MouseState _mouse;

		public FoodBowl (Vector2 position) : base (position)
		{
			Texture = Game1.instance.Content.Load<Texture2D> ("food");
		}


		//Alle observers(katten in de lijst) voeren de functie OnClick uit
		//Er wordt een nieuwe lijst aangemaakt zodat de katten hier weer opnieuw in kunnen komen
		public override void ButtonClick()
		{
			foreach (IObserver obs in observer) 
			{
				obs.OnFood ();
			}
			observer = new List<IObserver> ();
		}

		//Hier worden de observers toegevoegd (wordt aangeroepen in Cat.cs)
		public void RegisterCat(IObserver obs)
		{
			observer.Add (obs);
		}

		public override void Update(GameTime gameTime){
			_mouse = Mouse.GetState();

			bool mouseHit = (Bounds.Contains(_mouse.X, _mouse.Y));
			bool mouseClicked = (_mouse.LeftButton != _previousMouse.LeftButton && _mouse.LeftButton == ButtonState.Pressed);

			//Op click met de voedingsbak voer ButtonClick uit
			if(mouseHit && mouseClicked) {
				ButtonClick ();
			}

			_previousMouse = _mouse;
		}
	}
}

