# RTask - Recruitment Task 
Recruitment Task is an application, with one endpoint.

The objective of this solution is to show complete structure, according to nowadays roles for applications development.

### Requred point for supplied solution:
1. REST API endpoint using ASP.NET Core.
2. Get data from any source.
3. Prepare data in bussines layer.
4. Return prepared data (e.g. in JSON format).
5. Connection to data source realized via interface.
6. This interface gives possibility to easy replace data source.
7. Data from source (e.g. DataBase) signed as Domain Objects.
8. Possibility to realize bussines logic (in higher layer) and prepare DTO ready to transfer to higher leyer.
9. Each module / layer / level as separatedd assembly.
10. Domain module / Bussiner layer should be checked by few example tests.
11. Authorization, Autenthicaton not required.

### Layers:
* Domain
* Infrastructure
* Application
* UI (Web.Api)
* *Tests (in this example: test for Application layer - bussines logic.)*

### Description for pointed requirements:
1. Endpoint: https://github.com/Grzejszczyk/RTask/blob/9f4954b77843bb0dbc8824a95469f41916dfffb0/RTask.Api/Controllers/ExerciseController.cs#L24
2. GetData method: https://github.com/Grzejszczyk/RTask/blob/9f4954b77843bb0dbc8824a95469f41916dfffb0/RTask.Infrastructure/Repositories/ExerciseRepository.cs#L18
3. Data preparation. In this solution named as View Model. https://github.com/Grzejszczyk/RTask/blob/9f4954b77843bb0dbc8824a95469f41916dfffb0/RTask.Application/Services/ExerciseService.cs#L18
4. Data returned by endpoint with if statemet (found or not): https://github.com/Grzejszczyk/RTask/blob/9f4954b77843bb0dbc8824a95469f41916dfffb0/RTask.Api/Controllers/ExerciseController.cs#L27 
5. Interface for connection to data source:
https://github.com/Grzejszczyk/RTask/blob/9f4954b77843bb0dbc8824a95469f41916dfffb0/RTask.Application/Services/ExerciseService.cs#L12
6. It's easy to replace:
- new Repository must implement IExerciseRepository, which is defined in Domain layer.
- Domain layer is contacted with Infrastructure layer.
- Application layer is contracted with Infastructure.
- Each layer has dependencies IServiceCollection realizing dependency injection between layers.
- Those dependencies are simple registered in Startup class.
https://github.com/Grzejszczyk/RTask/blob/9f4954b77843bb0dbc8824a95469f41916dfffb0/RTask.Api/Startup.cs#L32
7. Entites are signed as Domain object by Repository.
8. Bussines logic placed on Application layer in Service (contracted via IExerciseService to higher level, and via IExerciseRepository to lower level).
9. For each layer solution contain assebly (.csproj file)
10. Bussines layer checked by Tests (fact and theory): https://github.com/Grzejszczyk/RTask/blob/9f4954b77843bb0dbc8824a95469f41916dfffb0/RTask.Tests/ExerciseServiceTest.cs#L13
11. N/A
