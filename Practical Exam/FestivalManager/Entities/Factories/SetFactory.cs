﻿using System;
using System.Linq;
using System.Reflection;

namespace FestivalManager.Entities.Factories
{
	using Contracts;
	using Entities.Contracts;
	using Sets;

	public class SetFactory : ISetFactory
	{
		public ISet CreateSet(string name, string type)
		{
		    var assembly = Assembly.GetCallingAssembly();

		    var setType = assembly
		        .GetTypes()
		        .First(s => s.Name == type);

		    if (setType == null)
		    {
		        throw new Exception(); // ? ?????
		    }

		    ISet set = (ISet) Activator.CreateInstance(setType, name);

		    return set;
		}
	}




}
