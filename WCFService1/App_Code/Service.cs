﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service" dans le code, le fichier svc et le fichier de configuration.
public class Service : IService
{

	public int WebAdd(int x, int y)
	{
		return x + y;
	}
	public int WebSoustraction(int x, int y)
	{
		return x - y;
	}
	public int WebMultiply(int x, int y)
	{
		return x * y;
	}
	public int WebDivision(int x, int y)
	{
		return x / y;
	}
}
