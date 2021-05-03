using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CollectionsProject
{
    //Model Class
    public class Movie : IComparable<Movie>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }

        public int CompareTo([AllowNull] Movie other)
        {
            return this.Duration.CompareTo(other.Duration);
        }

        public void TakeMovieDetails()
        {
            Console.WriteLine("Please enter the movie name");
            Name = Console.ReadLine();
            double duration = 0;
            Console.WriteLine("Please enter the movie duration");
            while (!double.TryParse(Console.ReadLine(), out duration))
            {
                Console.WriteLine("Invalid entry for duration. Please try again");
            }
            Duration = duration;
        }
        public override string ToString()
        {
            return "Movie Id : " + Id + " Name : " + Name + " Duration : " + Duration;
        }
    }
}
