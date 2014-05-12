using System;

namespace Dnd_4e_Character_Assistant
{
	public class MonoSupport
	{
			public static bool IsMono{get{
				Type t = Type.GetType ("Mono.Runtime");
        			if (t != null){
						return true;
					}
        			else{
						return false;}
			}}
	}}

