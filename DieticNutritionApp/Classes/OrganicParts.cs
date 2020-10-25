using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace DieticNutritionApp.Classes
{
    [Serializable]
    [DataContract]
    public class OrganicParts
    {   /*     
        readonly float proteins;
        readonly float fats;
        readonly float carbs;
        readonly float vitamins;
        readonly float minerals;
        */
        [XmlElement(ElementName = "Proteins")]
        [DataMember]
        public float proteins;
        [XmlElement(ElementName = "Fats")]
        [DataMember]
        public float fats;
        [XmlElement(ElementName = "Carbs")]
        [DataMember]
        public float carbs;
        [XmlElement(ElementName = "Vitamins")]
        [DataMember]
        public float vitamins;
        [XmlElement(ElementName = "Minerals")]
        [DataMember]
        public float minerals;

        public OrganicParts()
        {
        }

        public OrganicParts(float proteins, float fats, float carbs, float vitamins, float minerals)
        {
            this.proteins = proteins;
            this.fats = fats;
            this.carbs = carbs;
            this.vitamins = vitamins;
            this.minerals = minerals;
        }

        public float GetCalories()
        {
            float calories = (proteins + carbs) * 4 + fats * 9;

            return calories;
        }       

        public override string ToString()
        {
            string text = $"Proteins: {proteins}\n   Fats: {fats}\n   Carbs: {carbs}\n   Vitamins: {vitamins}\n   Minerals: {minerals}";

            return text;
        }

        public string ArgsToString()
        {
            string text = $"{proteins},{fats},{carbs},{vitamins},{minerals}";

            return text;
        }

        public static OrganicParts operator +(OrganicParts orgParts1, OrganicParts orgParts2)
        {
            float proteinSum = orgParts1.proteins + orgParts2.proteins;
            float fatsSum = orgParts1.fats + orgParts2.fats;
            float carbsSum = orgParts1.carbs + orgParts2.carbs;
            float vitaminsSum = orgParts1.vitamins + orgParts2.vitamins;
            float mineralsSum = orgParts1.minerals + orgParts2.minerals;

            OrganicParts sum = new OrganicParts(proteinSum, fatsSum, carbsSum, vitaminsSum, mineralsSum);

            return sum;
        }

        public static OrganicParts operator *(OrganicParts orgParts1, float multiplier)
        {
            multiplier /= 100;

            float proteinSum = orgParts1.proteins * multiplier;
            float fatsSum = orgParts1.fats * multiplier;
            float carbsSum = orgParts1.carbs * multiplier;
            float vitaminsSum = orgParts1.vitamins * multiplier;
            float mineralsSum = orgParts1.minerals * multiplier;

            OrganicParts sum = new OrganicParts(proteinSum, fatsSum, carbsSum, vitaminsSum, mineralsSum);

            return sum;
        }
    }
}
