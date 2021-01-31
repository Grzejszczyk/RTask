using RTask.Application.Interfaces;
using RTask.Application.ViewModels;
using RTask.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTask.Application.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;
        public ExerciseService(IExerciseRepository exerciseRepo)
        {
            _exerciseRepository = exerciseRepo;
        }

        public ExerciseVM GetExerciceById(int id)
        {
            var exercise = _exerciseRepository.GetExerciseById(id);

            if (exercise != null)
            {
                ExerciseVM exerciseVM = new ExerciseVM();
                exerciseVM.ExerciseName = exercise.ExerciseName;
                exerciseVM.ExerciseTextBody = exercise.ExerciseTextBody;
                exerciseVM.DifficultyLevel = exercise.DifficultyLevel;
                return exerciseVM;
            }
            else
            {
                return null;
            }
        }
    }
}
