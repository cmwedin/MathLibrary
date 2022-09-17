using System;

namespace SadSapphicGames.MathLibrary
{
    public interface IScalarField : IMorphism<float[], float> {
        int Dimension { get; }
        public float Evaluate(float[] argument) {
            if(argument.Length != Dimension) {
                throw new ArgumentException("Length of argument does not match dimension of input space");
            }
            return Mapping(argument);
        }
    }
}