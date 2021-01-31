using RTask.Domain.Interfaces;
using RTask.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RTask.Infrastructure.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly Context _context;
        public ExerciseRepository(Context context)
        {
            _context = context;
        }

        public Exercise GetExerciseById(int id)
        {
            var exercise = _context.Exercises.FirstOrDefault(e=>e.Id == id);
            return exercise;
        }

        public void SeedData()
        {
            List<Exercise> exercises = new List<Exercise>();

            for (int i = 1; i < 4; i++)
            {
                Exercise e = new Exercise();
                e.ExerciseName = $"Nazwa {i} zadania";
                e.ExerciseTextBody = $"To jest treść zadania {i}.";
                e.DifficultyLevel = new Random().Next(1, 5);
                exercises.Add(e);
            }
            _context.AddRange(exercises);
            _context.SaveChanges("SeedData User");
        }
    }
}
