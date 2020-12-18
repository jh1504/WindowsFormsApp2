using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2

{
    public enum MeasurementType
    {
        Grams,
        Ounces
    }

    public class Ingredients
    {

        private string myIngredients;
        private double ingredientWeight;
        private const double MEASURE_GRAMS = 1;
        private const double MEASURE_OUNCES = 0.0353;




        public string GetIngredients
        {
            get
            {
                return myIngredients;
            }
            set
            {
                myIngredients = value;
            }
        }

        public double GetIngredientWeight
        {
            get
            {
                return = ingredientWeight;
            }
            set
            {
                ingredientWeight = value;
            }
        }

        public double ConvertTo(double value, MeasurementType)
        {
            double result = 0;
            switch (unitTo)
            {
                case MeasurementType.Grams:
                    result = ConvertToGrams(value);
                    break;

                case MeasurementType.Ounces:
                    result = ConvertToOucnes(value);
                    break;

                default:
                    result = value;
                    break;
            }
            return result;
            }
        }


            private double ConvertToGrams(double value)
            {
                return value * MEASURE_GRAMS;
            }

            private double ConvertToOucnes(double value)
            {
                return value * MEASURE_OUNCES;
            }
    }

    


    


    

