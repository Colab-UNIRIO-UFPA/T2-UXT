﻿using System;
using Firjan.Integracao.Dynamics.Application.ViewModels.Corporativo.Base;
using System.Runtime.Serialization;

namespace Firjan.Integracao.Dynamics.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto RamoAtividade"/>
    ///</summary>
    [DataContract]
    public class RamoAtividadeViewModel : TipoViewModel<Byte>
    {
        public string Codigo { get; set; }
    }
}