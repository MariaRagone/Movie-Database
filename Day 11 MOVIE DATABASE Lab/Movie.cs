using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_MOVIE_DATABASE_Lab
{
    internal class Movie
    {
        //PROPERTIES

        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public int YearReleased { get; set; }
        public double Rating { get; set; }

     


        //CONSTRUCTOR

        public Movie(string _title, string _category, int _runTime, int _yearReleased, double _rating)
        {
            Title = _title;
            Category = _category;
            RunTime = _runTime;
            YearReleased = _yearReleased;
            Rating = _rating;
        }



        //OVERLOADING





        //METHODS
        public string GetDetails()
        { 
            return $"{Title}, Genre: {Category}, Run time: {RunTime} minutes, Year Released {YearReleased}, Rating: {Rating}/10"; 
        }

    }
}
