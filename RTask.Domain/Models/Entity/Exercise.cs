using RTask.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTask.Domain.Models.Entity
{
    public class Exercise : AuditableModelForEntity
    {
        public string ExerciseName { get; set; }
        public string ExerciseTextBody { get; set; }
        public int DifficultyLevel { get; set; }
    }
}
