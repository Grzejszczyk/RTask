using RTask.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTask.Domain.Interfaces
{
    public interface IExerciseRepository
    {
        Exercise GetExerciseById(int id);
    }
}
