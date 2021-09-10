//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();
        public ArrayList Steps { get => steps; }

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        /*
        Mantenemos en la clase Recipe la responsabilidad específica de redactar la receta. Es decir,
        debe preparar el texto que será impreso por los distintos medios de impresión futuros.
        */
        public string WriteRecipe(){
            StringBuilder builder = new StringBuilder($"Receta de {this.FinalProduct.Description}:\n");
            foreach (Step step in this.Steps)
            {
                builder.Append($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}\n");
            }
            return builder.ToString();
        }
    }
}