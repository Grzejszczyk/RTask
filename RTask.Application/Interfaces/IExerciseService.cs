using RTask.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTask.Application.Interfaces
{
    public interface IExerciseService
    {
        ExerciseVM GetExerciceById(int id);
    }
}
