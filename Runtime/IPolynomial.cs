using System;
using UnityEngine;

namespace SadSapphicGames.MathLibrary {
    public interface IPolynomial { //? maybe should be a class
        int Degree { get; set; }
        float[] Coefficients { get; set; }
        public float Evaluate(float t);
    }
}