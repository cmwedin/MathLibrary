using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace SadSapphicGames.MathLibrary
{
    public interface IMorphism<TInputSpace, TOutputSpace>
    {
        public Func<TInputSpace,TOutputSpace> Mapping { get; }
    }
}