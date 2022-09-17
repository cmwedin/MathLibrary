using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SadSapphicGames.MathLibrary
{
    public class ScalarField : IScalarField
    {
        
        public int Dimension { get; private set; }
        public Func<float[], float> Mapping { get; private set; }

        public ScalarField(int dimension, Func<float[], float> mapping) {
            Dimension = dimension;
            Mapping = mapping;
        }
    }
}