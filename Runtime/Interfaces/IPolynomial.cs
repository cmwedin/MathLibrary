using System;
using UnityEngine;

namespace SadSapphicGames.MathLibrary {
    /// <summary>
    /// An interface for polynomials
    /// </summary>
    public interface IPolynomial : IMorphism<float,float> {
        int Degree { get; set; }
        float[] Coefficients { get; set; }
        public float Evaluate(float t) {
            return Mapping(t);
        }
        public IPolynomial Derivative { get; }
    }
}