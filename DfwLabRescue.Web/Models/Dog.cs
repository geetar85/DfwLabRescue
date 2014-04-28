using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DfwLabRescue.Web.Models
{
    public class Dog : Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Breed Breed { get; set; }
        public Gender Gender { get; set; }
        public DogColor Color { get; set; }
        public string Weight { get; set; }
        public DateTime DateOfBirth { get; set; }
        private string _age;
        public string Age
        {
            get
            {
                if (_age != null) return _age;
                DateTime today = DateTime.Today;
                double ageInDays = (today - DateOfBirth).TotalDays;

                if (ageInDays < 365)
                    _age = Math.Round(ageInDays / 30, 1) + " month old";
                else
                    _age = Math.Round(ageInDays / 365, 1) + " year old";

                return _age;
            }
        }

               
        public string Summary { get; set; }
        public string Story { get; set; }

        public AdoptionStatus AdoptionStatus { get; set; }

        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
    }
}
