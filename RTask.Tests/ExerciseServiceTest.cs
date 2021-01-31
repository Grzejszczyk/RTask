using FluentAssertions;
using Moq;
using RTask.Application.Interfaces;
using RTask.Application.Services;
using RTask.Application.ViewModels;
using RTask.Domain.Interfaces;
using RTask.Domain.Models.Entity;
using System;
using Xunit;

namespace RTask.Tests
{
    public class ExerciseServiceTest
    {
        [Fact]
        public void CanGetExerciseById()
        {
            //Arrange:
            Exercise exercise = new Exercise()
            {
                Id = 1,
                ExerciseName = "ExerciseName",
                ExerciseTextBody = "ExerciseTextBody",
                DifficultyLevel = 10
            };

            ExerciseVM exerciseVM = new ExerciseVM()
            {
                ExerciseName = "ExerciseName",
                ExerciseTextBody = "ExerciseTextBody",
                DifficultyLevel = 10
            };
            var mock = new Mock<IExerciseRepository>();
            mock.Setup(s => s.GetExerciseById(1)).Returns(exercise);

            //Act:
            var exerciseService = new ExerciseService(mock.Object);

            var returnData = exerciseService.GetExerciceById(1);

            //Assert:
            returnData.Should().BeOfType(typeof(ExerciseVM));
            returnData.Should().Equals(exerciseVM);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void CanReturnNullByGetExerciseById(int id)
        {
            //Arrange:
            var mock = new Mock<IExerciseRepository>();
            mock.Setup(s => s.GetExerciseById(id));

            //Act:
            var exerciseService = new ExerciseService(mock.Object);

            var returnData = exerciseService.GetExerciceById(id);
            //Assert:
            returnData.Should().BeNull();
        }
    }
}
