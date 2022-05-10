using System;
using UnityEngine;

namespace SadSapphicGames.MathLibrary {
    public interface IPolynomial { //? maybe should be a class
        int Degree { get; set; }
        float[] Coefficients { get; set; }

        public float GetValue(float t) {
            float result = 0;
            for (int i = 0; i <= Degree; i++) {
                result += Coefficients[0] * Mathf.Pow(t,i);
            }
            return result;
        }
    }
}