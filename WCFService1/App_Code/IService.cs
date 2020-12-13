﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService" à la fois dans le code et le fichier de configuration.
[ServiceContract]
public interface IService
{

	[OperationContract]
	int WebAdd(int x, int y);
	[OperationContract]
	int WebSoustraction(int x, int y);
	[OperationContract]
	int WebMultiply(int x, int y);
	[OperationContract]
	int WebDivision(int x, int y);
}


