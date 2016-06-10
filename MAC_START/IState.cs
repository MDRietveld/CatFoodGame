using System;
using Microsoft.Xna.Framework;

namespace ProefTentamen
{
	//cat meegeven aan alle states samen met 2 functies die alle states moeten hebben (sommige voeren niet alle functies uit)
	public interface IState
	{
		Cat cat { get; set; }
		void StateClick();
		void Update(GameTime gameTime);
	}
}

